using CitasEps.Constants;
using CitasEps.Controllers;
using System;
using System.Windows.Forms;


namespace CitasEps.Views.Schedule
{
    public partial class CreateUpdateScheduleFrm : Form
    {
        private readonly SchedulesController schedulesController;
        private readonly LogsController logController;

        private Models.Schedule schedule;
        private readonly Func<object> OnCloseForm;

        private string officialId;

        public CreateUpdateScheduleFrm(Func<object> OnCloseForm, string officialId, string scheduleId = null)
        {
            this.OnCloseForm = OnCloseForm;
            this.officialId = officialId;

            schedulesController = new SchedulesController();
            logController = new LogsController();


            if (scheduleId != null)
                schedule = schedulesController.GetById(scheduleId);

            InitializeComponent();
        }

        private void CreateUpdateScheduleFrm_Load(object sender, EventArgs e)
        {
            if (schedule != null)
            {
                DateTimePickerInitHour.Value = Convert.ToDateTime(schedule.GetAttribute("init_hour"));
                DateTimePickerEndHour.Value = Convert.ToDateTime(schedule.GetAttribute("end_hour"));
            }
            else
            {
                DateTimePickerInitHour.Value = DateTime.Now;
                DateTimePickerEndHour.Value = DateTime.Now;
            }
        }

        private void BtnSaveSchedule_Click(object sender, EventArgs e)
        {
            if (schedule == null)
                CreateSchedule();
            else
                UpdateSchedule();

        }

        private void CreateSchedule()
        {
            bool isOk = false;
            int id = schedulesController.CreateSchedule(BuildSchedule());

            if (id != -1)
            {
                isOk = true;
                schedule = schedulesController.GetById(id.ToString());
                if (CurrentUser.rol == "admin")
                {
                    logController.CreateLog($"Se creó un nuevo agenda con id: {id}");
                }
            }

            ShowOperationStatusMessage(isOk);
        }

        private void UpdateSchedule()
        {
            int scheduleId = Convert.ToInt32(schedule.GetAttribute("id"));
            bool isOk = schedulesController.UpdateSchedule(BuildSchedule(scheduleId));

            if (isOk && CurrentUser.rol == "admin")
                logController.CreateLog($"Se editó la agenda con id: {scheduleId}");

            ShowOperationStatusMessage(isOk);
        }

        private Models.Schedule BuildSchedule(int scheduleId = 0)
        {
            DateTime initHour = DateTimePickerInitHour.Value;
            DateTime endHour = DateTimePickerEndHour.Value; ;

            return new Models.Schedule(scheduleId, Convert.ToInt32(officialId), initHour, endHour);
        }

        private void ShowOperationStatusMessage(bool isOk)
        {
            string msg = (isOk) ? "Operación realizada con éxito" : "No se pudo realizar la operación, intenta nuevamente";
            MessageBox.Show(msg);
        }

        private void CreateUpdateScheduleFrm_FormClosed(object sender, FormClosedEventArgs e) => OnCloseForm();
    }
}
