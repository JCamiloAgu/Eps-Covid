using CitasEps.Constants;
using CitasEps.Controllers;
using CitasEps.Views.AuthUser;
using CitasEps.Views.User;
using System;
using System.Windows.Forms;

namespace CitasEps
{
    public partial class LoginUsersFrm : Form
    {

        private UsersController usersController;
        private AffiliatesController affiliatesController;

        private string email;
        private string password;

        public LoginUsersFrm()
        {
            InitializeComponent();
            usersController = new UsersController();
            affiliatesController = new AffiliatesController();
        }

        // Abrir registro de usuario
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register frmRegister = new register();
            frmRegister.Show();
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPassword frmForgotPassword = new FrmForgotPassword();
            frmForgotPassword.Show();
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginOfficialsFrm frmLoginOfficials = new LoginOfficialsFrm();
            frmLoginOfficials.Show();
            Close();
        }

        private bool ValidateTxt()
        {
            email = txtEmail.Text;
            password = txtPassword.Text;
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateTxt())
            {
                Models.User user = usersController.GetByAttribute("email", email);
                password = MD5Hash.Hash.Content(password);
                if (user != null)
                {
                    if (password == user.GetAttribute("password").ToString())
                    {
                        Models.Affiliate affiliate = affiliatesController.Get("id", user.GetAttribute("id_affiliates").ToString());
                        CurrentUser.id = int.Parse(user.GetAttribute("id").ToString());
                        CurrentUser.fullName = affiliate.GetAttribute("name").ToString() + " " + affiliate.GetAttribute("last_name").ToString();
                        HomeFrm frmHomeUser = new HomeFrm();
                        frmHomeUser.Show();
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
    }
}
