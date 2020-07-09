using CitasEps.Constants;
using CitasEps.Views.Quote;
using System;
using System.Windows.Forms;

namespace CitasEps.Views.User
{
    public partial class HomeFrm : Form
    {
        public HomeFrm()
        {
            InitializeComponent();
            OpenFormChild(new QuoteUserFrm());
        }



        private void OpenFormChild(object formChild)
        {
            if (containerPanel.Controls.Count > 0)
                containerPanel.Controls.RemoveAt(0);

            Form form = formChild as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            form.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string CurrentUserName = CurrentUser.fullName;
            profileItemName.Text = CurrentUserName + " ▼";
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e) => OpenFormChild(new QuoteUserFrm());

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e) => OpenFormChild(new Doctors.DoctorsListUserFrm());

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserProfile frmProfile = new FrmUserProfile();
            frmProfile.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUsersFrm frmLogin = new LoginUsersFrm();
            frmLogin.Show();
            Close();
        }
    }
}
