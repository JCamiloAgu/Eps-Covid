using CitasEps.Constants;
using CitasEps.Views.Affiliate;
using CitasEps.Views.Log;
using CitasEps.Views.Official;
using System;
using System.Windows.Forms;

namespace CitasEps.Views
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            OpenFormChild(new EditProfileOfificialsFrm(CurrentUser.id));
            if (CurrentUser.rol == "doctor")
            {
                BtnGoToAffiliates.Hide();
                BtnGoToLog.Hide();
                pnlBtn1.Hide();
                pnlBtn2.Hide();
            }
        }

        private void OpenFormChild(object formChild)
        {
            if (PanelContenedor.Controls.Count > 0)
                PanelContenedor.Controls.RemoveAt(0);

            Form form = formChild as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(form);
            PanelContenedor.Tag = form;
            form.Show();
        }

        private void BtnLog_Click(object sender, EventArgs e) => OpenFormChild(new LogsFrm());

        private void BtnGoToEditProfile_Click(object sender, EventArgs e) => OpenFormChild(new EditProfileOfificialsFrm(CurrentUser.id));

        private void BtnGoToAffiliates_Click(object sender, EventArgs e) => OpenFormChild(new AffiliatesFrm());

        private void BtnGoToOfficials_Click(object sender, EventArgs e) => OpenFormChild(new OfficialsFrm());

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUsersFrm frmLogin = new LoginUsersFrm();
            frmLogin.Show();
            Close();
        }
    }
}
