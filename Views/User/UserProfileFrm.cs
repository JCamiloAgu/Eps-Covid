using CitasEps.Constants;
using CitasEps.Controllers;
using System;
using System.Windows.Forms;

namespace CitasEps.Views.User
{
    public partial class FrmUserProfile : Form
    {
        private string password;
        private int idUser = CurrentUser.id;
        private UsersController usersController;
        private AffiliatesController affiliatesController;


        public FrmUserProfile()
        {
            InitializeComponent();
            usersController = new UsersController();
            affiliatesController = new AffiliatesController();
        }

        private void LoadData()
        {
            Models.User user = usersController.GetByAttribute("id", idUser.ToString());
            Models.Affiliate affiliate = affiliatesController.Get("id", user.GetAttribute("id_affiliates").ToString());
            lblName.Text = CurrentUser.fullName;
            lblIdentification.Text = affiliate.GetAttribute("identification").ToString();
            txtAddress.Text = user.GetAttribute("address").ToString();
            txtEmail.Text = user.GetAttribute("email").ToString();
            txtPhone.Text = user.GetAttribute("phone").ToString();
            password = user.GetAttribute("password").ToString();
        }

        private void profile_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCurrentPassword frmPass = new FrmCurrentPassword();
            frmPass.password = password;
            frmPass.idUser = idUser;
            frmPass.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string addres = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            Models.User user = new Models.User(idUser, 0, phone, addres, email, "");
            usersController.UpdateUser(user);
            MessageBox.Show("Información editada con exito", "Mensaje");
            LoadData();
        }
    }
}
