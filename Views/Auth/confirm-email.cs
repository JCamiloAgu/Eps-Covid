using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitasEps.Controllers;


namespace CitasEps.Views.AuthUser {
	public partial class confirm_email : Form {
		public string emailUser;
		public string typeFormReturn;
		private EmailConfirCodeController emailConfirCodeController;
		private UsersController userController;

		

		public confirm_email() {
			InitializeComponent();
			emailConfirCodeController = new EmailConfirCodeController();
			userController = new UsersController();
		}

		private void btnSend_Click(object sender, EventArgs e) {
			string txtCode = txtConfirm.Text.ToString().ToUpper();
			Models.User user = userController.Get("email", emailUser);
			if (user == null) MessageBox.Show("Usuario no encontrado", "Error");
			else {
				if(emailConfirCodeController.Confirm(int.Parse(user.GetAttribute("id").ToString()), txtCode)){
					MessageBox.Show("Codigo de confirmación correcto", "Mensaje");
					switch (typeFormReturn) {

						// Recuperación de contraseña
						case ("newPassword"):
						MessageBox.Show("Por favor crea una nueva contraseña", "Mensaje");
						FrmNewPassword frmNewPass = new FrmNewPassword();
						frmNewPass.idUser = int.Parse(user.GetAttribute("id").ToString());
						frmNewPass.typeForm = "auth";
						frmNewPass.Show();
						Close();
						break;

						// Login
						default:
						MessageBox.Show("Por favor incia sesión", "Mensaje");
						login frmLogin = new login();
						frmLogin.Show();
						Close();
						break;
					}					
				}
				else{
					MessageBox.Show("Codigo de confirmación incorrecto, contacte con soporte", "Error");
				}
			}			
		}
	}
}
