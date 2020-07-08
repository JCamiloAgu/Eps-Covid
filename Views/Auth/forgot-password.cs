using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CitasEps;
using CitasEps.Models;
using CitasEps.Controllers;
using CitasEps.Services;

namespace CitasEps.Views.AuthUser {
	public partial class FrmForgotPassword : Form {
		private UsersController usersController;
		private EmailConfirCodeController emailConfirCodeController;

		public FrmForgotPassword() {
			InitializeComponent();
			usersController = new UsersController();
			emailConfirCodeController = new EmailConfirCodeController();
		}

		private void btnCancelar_Click(object sender, EventArgs e) {
			login frmLogin = new login();
			frmLogin.Show();
			Close();
		}

		private void btnEnviar_Click(object sender, EventArgs e) {
			string emailUser = txtEmail.Text;
			Models.User user = usersController.Get("email", emailUser);
			if (user == null) MessageBox.Show("Usuario no encontrado", "Error");
			else{
				//3) Generar codigo de confirmacion para email
				string code = HelpersService.GetCode();
				int idUser = int.Parse(user.GetAttribute("id").ToString());
				Email_Confirm_Code emailConfirmCode = new Email_Confirm_Code(0, idUser, code, false);
				if (emailConfirCodeController.Update(idUser, emailConfirmCode)) {
					
				// Proceso asincrono para enviar email
					Task.Run(async () => {
						await EmailService.SendEmailAsync(emailUser.ToString(), code);
					});

					MessageBox.Show("¡Vaya a su correo para confirmar el cambio de contraseña!", "Mensaje");
					confirm_email frmConfirmEmail = new confirm_email();
					frmConfirmEmail.emailUser = emailUser; // enviar  informacion a otro formulario
					frmConfirmEmail.typeFormReturn = "newPassword";
					frmConfirmEmail.Show();
					Close();
				}

			}

		}
	}
}
