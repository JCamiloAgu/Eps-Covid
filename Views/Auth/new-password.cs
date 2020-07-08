using CitasEps.Controllers;
using System;
using System.Windows.Forms;

namespace CitasEps.Views.AuthUser {
	public partial class FrmNewPassword : Form {
		private string password;
		private string confirm;
		public int idUser;
		public string typeForm;
		private UsersController usersController;

		public FrmNewPassword() {
			InitializeComponent();
			usersController = new UsersController();
		}

		private bool InputValidator() {
			bool state = true;
			password = txtPassword.Text;
			confirm = txtConfirm.Text;

			if (confirm != password) {
				MessageBox.Show("El password no coincide con la confirmación!", "Error");
				state = false;
			}
			return state;
		}

		private void button1_Click(object sender, EventArgs e) {
			if (InputValidator()) {
				Models.User user = new Models.User(0, 0, "0", "0", "0", password);
				if(usersController.NewPassword(user, idUser)){
					MessageBox.Show("¡Contraseña cambiada con exito!", "Mensaje");
					if (typeForm == "auth") {
						MessageBox.Show("¡Por favor inicie sesión!", "Mensaje");
						login frmLogin = new login();
						frmLogin.Show();
					}		
					Close();
				}
				else{
					MessageBox.Show("La contraseña no se pudo cambiar, contacte con soporte", "Error");
				}
			}
		}
	}
}
