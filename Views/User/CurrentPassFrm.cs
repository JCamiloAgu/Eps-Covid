using CitasEps.Views.AuthUser;
using System;
using System.Windows.Forms;

namespace CitasEps.Views.User
{
    public partial class FrmCurrentPassword : Form
    {
        public string password;
        public int idUser;
        public FrmCurrentPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = MD5Hash.Hash.Content(txtPass.Text);
            if (password == pass)
            {
                FrmNewPassword frmNew = new FrmNewPassword();
                frmNew.idUser = idUser;
                frmNew.typeForm = "edit";
                frmNew.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Error");
            }
        }
    }
}
