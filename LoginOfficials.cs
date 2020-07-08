using CitasEps.Constants;
using CitasEps.Controllers;
using System;
using System.Windows.Forms;


namespace CitasEps {
	public partial class LoginOfficials : Form {
		private OfficialsController officialsController;
		private string email;
		private string password;

		public LoginOfficials() {
			InitializeComponent();
			officialsController = new OfficialsController();
		}

		private bool ValidateTxt() {
			email = txtEmail.Text;
			password = txtPassword.Text;
			return true;
		}

		private void btnSend_Click(object sender, EventArgs e) {
			if (ValidateTxt()) {
				Models.Official official = officialsController.Get("email", email);
				password = MD5Hash.Hash.Content(password);
				if (official != null) {
					if (password == official.GetAttribute("password").ToString() && 
					Boolean.Parse(official.GetAttribute("status").ToString()) == true) {
						CurrentUser.currentUserId = int.Parse(official.GetAttribute("id").ToString());
						if(official.GetAttribute("rol").ToString() == "administrador") {
							CurrentUser.currentUserRol = "admin";							
						}
						else{
							CurrentUser.currentUserRol = "doctor";							
						}
						Views.AdminHome frmHomeAdmin = new Views.AdminHome();
						frmHomeAdmin.Show();
						Close();

					}
					else {
						MessageBox.Show("Credenciales incorrectas", "Error");
					}
				}
				else {
					MessageBox.Show("Credenciales incorrectas", "Error");
				}
			}
		}

		private void btnBack_Click(object sender, EventArgs e) {
			login frmLogin = new login();
			frmLogin.Show();
			Close();
		}
	}
}
