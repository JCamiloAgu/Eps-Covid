using System;
using System.Windows.Forms;
using CitasEps.Controllers;
using CitasEps.Views.AuthUser;
using CitasEps.Constants;
using CitasEps.Views.User;

namespace CitasEps {
	public partial class login : Form {

		private UsersController usersController;
		private AffiliatesController affiliatesController;

		private string email;
		private string password;

		public login() {
			InitializeComponent();
			usersController = new UsersController();
			affiliatesController = new AffiliatesController();
		}

		// Abrir registro de usuario
		private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			register frmRegister = new register();
			frmRegister.Show();
			Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			FrmForgotPassword frmForgotPassword = new FrmForgotPassword();
			frmForgotPassword.Show();
			Close();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			LoginOfficials frmLoginOfficials = new LoginOfficials();
			frmLoginOfficials.Show();
			Close();
		}

		private bool ValidateTxt() {
			email = txtEmail.Text;
			password = txtPassword.Text;
			return true;
		}

		private void btnLogin_Click(object sender, EventArgs e) {
			if (ValidateTxt()) {
				Models.User user = usersController.Get("email", email);
				password = MD5Hash.Hash.Content(password);
				if(user != null){
					if(password == user.GetAttribute("password").ToString()){
						Models.Affiliate affiliate = affiliatesController.Get("id", user.GetAttribute("id_affiliates").ToString());
						CurrentUser.currentUserId = int.Parse(user.GetAttribute("id").ToString());
						CurrentUser.currentUserName = affiliate.GetAttribute("name").ToString() + " " + affiliate.GetAttribute("last_name").ToString();
						Home frmHomeUser = new Home();
						frmHomeUser.Show();
						Close();
					}
					else{
						MessageBox.Show("Credenciales incorrectas", "Error");
					}
				}
				else{
					MessageBox.Show("Credenciales incorrectas", "Error");
				}
			}
		}
	}
}
