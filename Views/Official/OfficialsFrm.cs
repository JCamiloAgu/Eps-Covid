using CitasEps.Constants;
using CitasEps.Controllers;
using CitasEps.Views.Schedule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CitasEps.Views.Official
{
    public partial class OfficialsFrm : Form
    {
        private readonly OfficialsController officialsController;
        private readonly LogsController logController;

        private List<Models.Official> officials = new List<Models.Official>();

        public OfficialsFrm()
        {
            InitializeComponent();
            officialsController = new OfficialsController();
            logController = new LogsController();
            if (CurrentUser.rol == "doctor")
            {
                BtnCreateOfficial.Hide();
                BtnEditOfficial.Hide();
                BtnDeleteOfficial.Hide();
                BtnCreateOfficial.Hide();
                TxtBoxOfficialId.Hide();
                label1.Hide();
            }

        }
        private void OfficialsFrm_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            if (CurrentUser.rol == "doctor")
            {
                officials.Add(officialsController.GetByAttribute("id", CurrentUser.id.ToString()));
            }
            else
            {
                officials = officialsController.GetAll();
            }
            if (officials != null)
                ShowOfficialsInListView();
        }

        private void ShowOfficialsInListView()
        {
            ListViewOfficials.Items.Clear();
            foreach (Models.Official official in officials)
            {
                string id = official.GetAttribute("id").ToString();
                string name = official.GetAttribute("name").ToString();
                string lastName = official.GetAttribute("last_name").ToString();
                string identification = official.GetAttribute("identification").ToString();
                string email = official.GetAttribute("email").ToString();
                string rol = official.GetAttribute("rol").ToString();
                string status = Convert.ToBoolean(official.GetAttribute("status")) ? "Activo" : "No activo";

                ListViewItem item = ListViewOfficials.Items.Add(id);
                item.SubItems.Add(name);
                item.SubItems.Add(lastName);
                item.SubItems.Add(identification);
                item.SubItems.Add(email);
                item.SubItems.Add(rol);
                item.SubItems.Add(status);
            }
        }

        private void BtnCreateOfficial_Click(object sender, EventArgs e)
        {
            CreateUpdateOfficialFrm createUpdateOfficialFrm = new CreateUpdateOfficialFrm(OnCloseCreateUpdateOfficialForm);
            createUpdateOfficialFrm.Show();
        }

        private object OnCloseCreateUpdateOfficialForm()
        {
            LoadData();
            return null;
        }

        private void BtnEditOfficial_Click(object sender, EventArgs e)
        {
            string officialId = TxtBoxOfficialId.Text;

            if (IsValidId(officialId))

                new CreateUpdateOfficialFrm(OnCloseCreateUpdateOfficialForm, officialId).Show();
            else
                ShowMessageIncorrectId();
        }


        private void BtnDeleteOfficial_Click(object sender, EventArgs e)
        {
            string officialId = TxtBoxOfficialId.Text;

            if (IsValidId(officialId))
                DeleteOfficial(officialId);
            else
                ShowMessageIncorrectId();
        }
        private void BtnShowSchedule_Click(object sender, EventArgs e)
        {
            string officialId = TxtBoxOfficialId.Text;

            if (CurrentUser.rol == "doctor")
            {
                officialId = CurrentUser.id.ToString();
            }

            if (IsValidId(officialId, true))
                new SchedulesFrm(officialId).Show();
            else
                MessageBox.Show("El ID debe ser de un médico");

        }


        // Abrir calendario
        private void BtnShowCalendar_Click(object sender, EventArgs e)
        {
            string officialId = TxtBoxOfficialId.Text;
            if (CurrentUser.rol == "doctor")
            {
                officialId = CurrentUser.id.ToString();
            }

            if (IsValidId(officialId, true))
                new CalendarFrm(officialId, CurrentUser.rol).Show();
            else
                MessageBox.Show("El ID debe ser de un médico");
        }


        private bool IsValidId(string officialId, bool isForShowSchedule = false)
        {
            if (officialId == null || officialId == "")
                return false;

            bool existId = officials.Exists(match: (official) => official.GetAttribute("id").ToString() == officialId);


            return (isForShowSchedule) ? (existId && IsValidRol(officialId)) : existId;
        }

        private bool IsValidRol(string officialId)
        {
            Models.Official official = officials.Find(match: (official) => official.GetAttribute("id").ToString() == officialId);
            return (official.GetAttribute("rol").ToString() == "medico");
        }

        private void ShowMessageIncorrectId() =>
                MessageBox.Show("No se encontró el id del funcionario");

        private void DeleteOfficial(string officialId)
        {
            bool isOk = officialsController.DeleteOfficial(officialId);

            if (isOk)
            {
                RemoveOfficialFromLocal(officialId);
                TxtBoxOfficialId.Text = "";
                logController.CreateLog($"Se eliminó el funcionario con id: {officialId}");
            }
            else
                MessageBox.Show("No se pudo eliminar");
        }

        private void RemoveOfficialFromLocal(string officialId)
        {
            int index =
                            officials.FindIndex(match: (official) => official.GetAttribute("id").ToString() == officialId);

            ListViewOfficials.Items.RemoveAt(index);
            officials.RemoveAt(index);
        }


    }
}
