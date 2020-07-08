using CitasEps.Controllers;
using CitasEps.Models;
using CitasEps.Views.Quote;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CitasEps.Constants;

namespace CitasEps {
	public partial class CalendarAppoinment : Form {

		private readonly SchedulesController schedulesController;
		private readonly OfficialsController officialController;
		private readonly QuotesController quotesController;
		private string rol;

		List<string> daysOfWeek = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
		private List<Label> labelsAppoinments = new List<Label>();

		Calendar calendar;
		DateTime dateTime;

		string officialId;

		public CalendarAppoinment(string officialId, string rol) {
			InitializeComponent();

			this.officialId = officialId;
			this.rol = rol;

			schedulesController = new SchedulesController();
			officialController = new OfficialsController();
			quotesController = new QuotesController();

			calendar = new Calendar(containerDays);
			dateTime = DateTime.Now;

			// Se generan 42 cajas porque el primer día de un mes no simpre empieza un domingo
			calendar.generateBoxDays(42);
			calendar.generateNameDays(nameDaysContainer);

			setDateInLabel();
		}

		// Este metodo atrae las citas disponibles que pueden haber en un DETERMINADO MES
		public List<SheduleAppoinment> getSheduleAppoinments() {
			List<SheduleAppoinment> sheduleAppoinments = new List<SheduleAppoinment>();

			Official official = officialController.GetOfficialById(officialId); ;
			List<Schedule> schedules = schedulesController.GetAllByOfficialId(officialId);
			List<Quote> quotes = quotesController.GetAllByOfficialId(officialId);

			schedules = schedules.FindAll((s) => Convert.ToDateTime(s.GetAttribute("init_hour")).ToString("yyyy-MM") == dateTime.ToString("yyyy-MM"));

			if (schedules != null && schedules.Count > 0) {
				foreach (Schedule schedule in schedules) {
					DateTime initHour = Convert.ToDateTime(schedule.GetAttribute("init_hour"));
					DateTime endHour = Convert.ToDateTime(schedule.GetAttribute("end_hour"));


					while (initHour < endHour) {
						int quoteIndex = quotes.FindIndex(quote =>
															Convert.ToDateTime(
															quote.GetAttribute("date_time").ToString()) == initHour
															&& quote.GetAttribute("id_officials")?.ToString() == schedule.GetAttribute("id_officials")?.ToString());

						int? quoteId = null;

						if (quoteIndex != -1)
							quoteId = Convert.ToInt32(quotes[quoteIndex].GetAttribute("id").ToString());

						sheduleAppoinments.Add(new SheduleAppoinment(official, initHour, quoteId));
						initHour = initHour.AddMinutes(40);
					}
				}
			}

			return sheduleAppoinments;
		}

		// Metodo principal donde se generan todos los controles del calendario (RESPECTO A UN MES Y AÑO)
		public void setDateInLabel() {
			int year = Convert.ToInt32(dateTime.ToString("yyyy"));
			int numberMonth = Convert.ToInt32(dateTime.ToString("MM"));

			Month month = calendar.months[numberMonth - 1];
			int numberFirstDayOfWeek = getFirstDayOfWeek(year, numberMonth) + 1;

			LBDescriptionDate.Text = month.getName() + ", " + year.ToString();

			calendar.generateLabelBoxDay(numberFirstDayOfWeek, month.getTotalDays(year));
			labelsAppoinments = calendar.addAppoinment(numberFirstDayOfWeek, getSheduleAppoinments());
			setEventHandleLabelsAppointments();
		}

		// Se establece el evento de click a todos los LABELS de citas que hay en el calendario
		private void setEventHandleLabelsAppointments() {
			foreach (Label item in labelsAppoinments) {
				item.Click += new EventHandler(this.click_appoinment);
			}
		}

		// Se obtiene la posición del primer día de un mes
		public int getFirstDayOfWeek(int year, int numberMonth) {
			DateTime date = new DateTime(Convert.ToInt32(year), numberMonth, 1);
			return daysOfWeek.FindIndex(day => day.Equals(date.DayOfWeek.ToString()));
		}


		// Se obtiene la fecha actual
		public void currentDate() {
			dateTime = DateTime.Now;
			setDateInLabel();
		}

		// Last month in calendar
		private void button1_Click(object sender, EventArgs e) {
			lastMonth();
		}

		// Next month in calendar
		private void button3_Click(object sender, EventArgs e) {
			nextMonth();
		}

		// Today month in calendar
		private void button2_Click(object sender, EventArgs e) {
			currentDate();
		}

		public void nextMonth() {
			dateTime = dateTime.AddMonths(1);
			setDateInLabel();
		}

		public void lastMonth() {
			dateTime = dateTime.AddMonths(-1);
			setDateInLabel();
		}

		// Cuando click en un LABEL (Cita)
		public void click_appoinment(object sender, EventArgs e) {
			Label label = sender as Label;
			List<SheduleAppoinment> list = getSheduleAppoinments();

			int index = labelsAppoinments.FindIndex(lab => lab.Name == label.Name);
			SheduleAppoinment sheduleAppoinment = list[index];

			string officialId = sheduleAppoinment.getOfficial().GetAttribute("id").ToString();
			string quoteId = sheduleAppoinment.getQuoteId().ToString();
			DateTime quoteDateTime = sheduleAppoinment.getDateTime();
			

			switch (rol) {
				case ("user"):
				if (quoteId == "" ) {
					string message = string.Format("Quieres crear una cita para el {0}?", quoteDateTime);
					if (MessageBox.Show(message, "Mensaje", MessageBoxButtons.YesNo)==DialogResult.Yes) {
						int idUser = CurrentUser.currentUserId;
						Quote quoteNew = new Quote(0, idUser, int.Parse(officialId), 0, quoteDateTime); 
						quotesController.CreateQuote(quoteNew);
						MessageBox.Show("Cita creada con exito");
						setDateInLabel();
					}
				}
				else{
					MessageBox.Show("Cita ya existente!", "Error");
				}
				break;
				case ("doctor"):
				if (quoteId != "") {
					new UserQuoteView(quoteId).Show();
				}
				else{
					MessageBox.Show("No hay cita agendada", "Mensaje");
				}
				break;
				default:
					new CreateDeleteQuote(OnCloseQuotesFrm, officialId, quoteId, quoteDateTime).Show();
				break;
			}
		}

		private object OnCloseQuotesFrm(bool updateUI) {
			if (updateUI)
				setDateInLabel();

			return null;
		}
	}





	public class Calendar {

		// Container donde se van a generar las cajas de los días
		public Panel container;

		// Colores de los LABELS de las citas disponibles
		public List<Color> colors = new List<Color>();

		public string[] nameDays = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado" };
		public List<FlowLayoutPanel> boxDays = new List<FlowLayoutPanel>();

		// Lista de meses
		public List<Month> months = new List<Month>() {
								new Month("Enero", 31),
								new Month("Febrero", 28),
								new Month("Marzo", 31),
								new Month("Abril", 30),
								new Month("Mayo", 31),
								new Month("Junio", 30),
								new Month("Julio", 31),
								new Month("Agosto", 31),
								new Month("Septiembre", 30),
								new Month("Octubre", 31),
								new Month("Noviembre", 30),
								new Month("Diciembre", 31)
						};

		public Calendar(Panel container) {
			this.container = container;
		}

		// Generar las cajas (Controls) de los días del mes
		public void generateBoxDays(int number) {

			container.Controls.Clear();
			container.AutoScroll = true;

			for (int j = 0; j < number / 7; j++) {
				FlowLayoutPanel row = new FlowLayoutPanel();

				row.FlowDirection = FlowDirection.LeftToRight;
				row.Dock = DockStyle.Bottom;
				row.WrapContents = true;
				row.AutoSize = true;

				for (int i = 0; i < 7; i++) {

					FlowLayoutPanel fl = new FlowLayoutPanel();

					fl.Size = new Size(159, 122);
					fl.Name = "flBoxDay" + (i * (j + 1));
					fl.BackColor = Color.White;
					fl.BorderStyle = BorderStyle.FixedSingle;
					fl.AutoScroll = true;
					fl.HorizontalScroll.Enabled = false;
					fl.HorizontalScroll.Visible = false;

					row.Controls.Add(fl);

					boxDays.Add(fl);
				}

				container.Controls.Add(row);
			}
		}

		// Se generan los nombres de los días de la semana
		public void generateNameDays(FlowLayoutPanel flowLayoutPanel) {

			for (int i = 0; i < nameDays.Length; i++) {

				Panel panel = new Panel();
				panel.Size = new Size(159, 47);

				Label label = new Label();
				label.Text = nameDays[i];
				label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				label.Dock = DockStyle.Fill;
				label.Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);

				panel.Controls.Add(label);
				flowLayoutPanel.Controls.Add(panel);
			}
		}

		//  Añadir cita a un dpia en especifico
		public List<Label> addAppoinment(int startIndex, List<SheduleAppoinment> sheduleAppoinments) {

			List<Label> labelsAppoinments = new List<Label>();
			int day = 1;
			int counterLabel = 0;

			for (int i = startIndex - 1; i < boxDays.Count; i++) {
				foreach (SheduleAppoinment appoinment in sheduleAppoinments) {
					if (Convert.ToInt32(appoinment.getDateTime().ToString("dd")) == day) {
						Label label = createLabelAppoinment(appoinment, counterLabel);
						labelsAppoinments.Add(label);
						boxDays[i].Controls.Add(label);

						counterLabel += 1;
					}
				}
				day += 1;
			}

			return labelsAppoinments;
		}

		public Label createLabelAppoinment(SheduleAppoinment appoinment, int index) {
			Label label = new Label();

			label.Name = "LBSheduleAppointment" + index;
			label.Text = appoinment.getDateTime().ToString("hh:mm:ss tt");
			label.TextAlign = ContentAlignment.MiddleCenter;
			label.BackColor = (appoinment.getQuoteId() == null) ? Color.White : generateColorRandom();
			label.Dock = DockStyle.Top;
			label.Size = new Size(150, 20);
			label.Cursor = Cursors.Hand;
			label.Font = new Font(FontFamily.GenericSansSerif, 11.0F);

			return label;
		}

		// Generar un color aleatorio que no este generado previamente
		private Color generateColorRandom() {
			Random random = new Random();
			Color color;

			do {
				int colorRed = random.Next(180, 255);
				int colorGreen = random.Next(255);
				int colorBlue = random.Next(255);

				color = Color.FromArgb(colorRed, colorGreen, colorBlue);

			} while (colors.FindIndex(c => c == color) != -1);

			colors.Add(color);
			return color;
		}

		// Generar un cita dentro del control de un día
		public void generateLabelBoxDay(int startIndex, int numberDaysMonth) {
			cleanLabelsBoxDay();

			for (int i = 1; i <= numberDaysMonth; i++) {
				boxDays[(i - 1) + (startIndex - 1)].Controls.Add(createLabel(i));
			}

			// Este código sirve para generar los días de los días del proximo mes
			/*int indexBox = numberDaysMonth + startIndex;
			int day = 1;

			while (indexBox <= boxDays.Count) {
					boxDays[indexBox - 1].Controls.Add(createLabel(day));
					day += 1;
					indexBox += 1;
			}*/
		}

		private Label createLabel(int index) {
			Label label = new Label();

			label.Dock = DockStyle.Top;
			label.Size = new Size(150, 30);
			label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			label.Font = new Font(FontFamily.GenericSansSerif, 11.0F);
			label.Name = "LBNumberDay" + index;
			label.Text = index.ToString();

			return label;
		}

		private void cleanLabelsBoxDay() {
			foreach (FlowLayoutPanel box in boxDays) {
				box.Controls.Clear();
			}
		}
	}

	public class Month {

		private string name;
		private int days;

		public Month(string name, int days) {
			this.name = name;
			this.days = days;
		}

		public int getTotalDays(int year) {

			int totalDays = days;
			if (name == "Febrero" && year % 4 == 0) totalDays = 29;

			return totalDays;
		}

		public string getName() {
			return name;
		}
	}
}
