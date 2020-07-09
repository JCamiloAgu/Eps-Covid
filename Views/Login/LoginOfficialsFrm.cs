using CitasEps.Constants;
using CitasEps.Controllers;
using System;
using System.Windows.Forms;


namespace CitasEps
{
    public partial class LoginOfficialsFrm : Form
    {
        private OfficialsController officialsController;
        private string email;
        private string password;

        public LoginOfficialsFrm()
        {
            InitializeComponent();
            officialsController = new OfficialsController();
        }

        private bool ValidateTxt()
        {
            email = txtEmail.Text;
            password = txtPassword.Text;
            return true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ValidateTxt())
            {
                Models.Official official = officialsController.GetByAttribute("email", email);
                password = MD5Hash.Hash.Content(password);
                if (official != null)
                {
                    if (password == official.GetAttribute("password").ToString() &&
                    Boolean.Parse(official.GetAttribute("status").ToString()) == true)
                    {
                        CurrentUser.id = int.Parse(official.GetAttribute("id").ToString());
                        if (official.GetAttribute("rol").ToString() == "administrador")
                        {
                            CurrentUser.rol = "admin";
                        }
                        else
                        {
                            CurrentUser.rol = "doctor";
                        }
                        Views.AdminHome frmHomeAdmin = new Views.AdminHome();
                        frmHomeAdmin.Show();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas", "Error");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginUsersFrm frmLogin = new LoginUsersFrm();
            frmLogin.Show();
            Close();
        }
    }
}
