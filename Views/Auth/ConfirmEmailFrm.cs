using CitasEps.Controllers;
using System;
using System.Windows.Forms;


namespace CitasEps.Views.AuthUser
{
    public partial class confirm_email : Form
    {
        public string emailUser;
        public string typeFormReturn;
        private EmailConfirmCodeController emailConfirCodeController;
        private UsersController userController;



        public confirm_email()
        {
            InitializeComponent();
            emailConfirCodeController = new EmailConfirmCodeController();
            userController = new UsersController();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string txtCode = txtConfirm.Text.ToString().ToUpper();
            Models.User user = userController.GetByAttribute("email", emailUser);
            if (user == null) MessageBox.Show("Usuario no encontrado", "Error");
            else
            {
                if (emailConfirCodeController.ConfirmEmailCode(int.Parse(user.GetAttribute("id").ToString()), txtCode))
                {
                    MessageBox.Show("Codigo de confirmación correcto", "Mensaje");
                    switch (typeFormReturn)
                    {

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
                            LoginUsersFrm frmLogin = new LoginUsersFrm();
                            frmLogin.Show();
                            Close();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Codigo de confirmación incorrecto, contacte con soporte", "Error");
                }
            }
        }
    }
}
