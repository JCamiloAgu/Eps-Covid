using CitasEps.Controllers;
using CitasEps.Models;
using CitasEps.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasEps.Views.AuthUser
{
    public partial class FrmForgotPassword : Form
    {
        private UsersController usersController;
        private EmailConfirmCodeController emailConfirCodeController;

        public FrmForgotPassword()
        {
            InitializeComponent();
            usersController = new UsersController();
            emailConfirCodeController = new EmailConfirmCodeController();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LoginUsersFrm frmLogin = new LoginUsersFrm();
            frmLogin.Show();
            Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string emailUser = txtEmail.Text;
            Models.User user = usersController.GetByAttribute("email", emailUser);
            if (user == null) MessageBox.Show("Usuario no encontrado", "Error");
            else
            {
                //3) Generar codigo de confirmacion para email
                string code = HelpersService.GetCode();
                int idUser = int.Parse(user.GetAttribute("id").ToString());
                EmailConfirmCode emailConfirmCode = new EmailConfirmCode(0, idUser, code, false);
                if (emailConfirCodeController.Update(idUser, emailConfirmCode))
                {

                    // Proceso asincrono para enviar email
                    Task.Run(async () =>
                    {
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
