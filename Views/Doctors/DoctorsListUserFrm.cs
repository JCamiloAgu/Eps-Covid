using CitasEps.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CitasEps.Views.Doctors
{
    public partial class DoctorsListUserFrm : Form
    {
        private OfficialsController officialsController;
        private List<string> ids = new List<string>();

        public DoctorsListUserFrm()
        {
            InitializeComponent();
            officialsController = new OfficialsController();
            LoadData();
        }

        private void LoadData()
        {
            listViewDoctors.Items.Clear();
            List<Models.Official> listOfficials = officialsController.GetAllDoctors();
            foreach (var item in listOfficials)
            {
                ListViewItem colums = listViewDoctors.Items.Add(item.GetAttribute("id").ToString());
                colums.SubItems.Add(item.GetAttribute("name").ToString() + " " + item.GetAttribute("last_name").ToString());
                ids.Add(item.GetAttribute("id").ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string idDoctor = txtDoctorId.Text;
            txtDoctorId.Text = "";
            int findResult = ids.IndexOf(idDoctor);
            if (findResult != -1)
            {
                CalendarFrm frmCalendar = new CalendarFrm(idDoctor, "user");
                frmCalendar.Show();
            }
            else
            {
                MessageBox.Show("Doctor no encontrado", "Error");
            }
        }
    }
}
