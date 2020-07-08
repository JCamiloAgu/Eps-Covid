using CitasEps.Controllers;
using System;
using System.Collections.Generic;
using CitasEps.Constants;
using System.Windows.Forms;

namespace CitasEps.Views.Schedule {
	public partial class SchedulesFrm : Form {
		private readonly SchedulesController schedulesController;
		private readonly OfficialsController officialController;
		private readonly LogsController logController;

		private List<Models.Schedule> schedules;
		private readonly string officialId;

		public SchedulesFrm(string officialId) {
			InitializeComponent();
			this.officialId = officialId;
			schedulesController = new SchedulesController();
			officialController = new OfficialsController();
			logController = new LogsController();
		}

		private void SchedulesFrm_Load(object sender, EventArgs e) => LoadData();

		private void LoadData() {
			schedules = schedulesController.GetAllByOfficialId(officialId);
			if (schedules != null)
				ShowSchedulesInListView();
		}

		private void ShowSchedulesInListView() {
			ListViewSchedules.Items.Clear();
			foreach (Models.Schedule schedule in schedules) {
				string id = schedule.GetAttribute("id").ToString();
				string initHour = schedule.GetAttribute("init_hour").ToString();
				string endHour = schedule.GetAttribute("end_hour").ToString();

				Models.Official official = officialController.GetOfficialById(officialId);
				string officialFullName = $"{official.GetAttribute("name")} {official.GetAttribute("last_name")}";


				ListViewItem item = ListViewSchedules.Items.Add(id);
				item.SubItems.Add(initHour);
				item.SubItems.Add(endHour);

				item.SubItems.Add(officialFullName);
			}
		}

		private void BtnCreateSchedule_Click(object sender, EventArgs e) {
			CreateUpdateScheduleFrm createUpdateScheduleFrm = new CreateUpdateScheduleFrm(OnCloseCreateUpdateScheduleForm, officialId);
			createUpdateScheduleFrm.Show();
		}

		private object OnCloseCreateUpdateScheduleForm() {
			LoadData();
			return null;
		}

		private void BtnEditSchedule_Click(object sender, EventArgs e) {
			string scheduleId = TxtBoxScheduleId.Text;

			if (IsValidId(scheduleId))

				new CreateUpdateScheduleFrm(OnCloseCreateUpdateScheduleForm, officialId, scheduleId).Show();
			else
				ShowMessageIncorrectId();
		}

		private bool IsValidId(string scheduleId) {
			if (scheduleId == null || scheduleId == "")
				return false;

			bool existId = schedules.Exists(match: (schedule) => schedule.GetAttribute("id").ToString() == scheduleId);

			return existId;
		}

		private void ShowMessageIncorrectId() =>
				MessageBox.Show("No se encontró el id de la agenda");

		private void BtnDeleteSchedule_Click(object sender, EventArgs e) {
			string scheduleId = TxtBoxScheduleId.Text;

			if (IsValidId(scheduleId))
				DeleteSchedule(scheduleId);
			else
				ShowMessageIncorrectId();
		}

		private void DeleteSchedule(string scheduleId) {
			bool isOk = schedulesController.DeleteSchedule(scheduleId);

			if (isOk) {
				RemoveScheduleFromLocal(scheduleId);
				TxtBoxScheduleId.Text = "";

				if (CurrentUser.currentUserRol == "admin")
					logController.CreateLog($"Se eliminó la agenda con id: {scheduleId}");
			}
			else
				MessageBox.Show("No se pudo eliminar");
		}

		private void RemoveScheduleFromLocal(string scheduleId) {
			int index =
							schedules.FindIndex(match: (schedule) => schedule.GetAttribute("id").ToString() == scheduleId);

			ListViewSchedules.Items.RemoveAt(index);
			schedules.RemoveAt(index);
		}


	}
}
