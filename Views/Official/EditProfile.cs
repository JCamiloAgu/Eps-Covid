using CitasEps.Controllers;
using System;
using System.Windows.Forms;

namespace CitasEps.Views.Official
{
    public partial class EditProfile : Form
    {
        private readonly OfficialsController officialController;
        private readonly Models.Official currentOfficial;
        private readonly int currentOfficialId;

        public EditProfile(int currentOfficialId)
        {
            this.currentOfficialId = currentOfficialId;

            InitializeComponent();
            officialController = new OfficialsController();

            currentOfficial = officialController.GetOfficialById(currentOfficialId.ToString());
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            TxtBoxIdentification.Text = currentOfficial.GetAttribute("identification").ToString();
            TxtBoxName.Text = currentOfficial.GetAttribute("name").ToString();
            TxtBoxLastName.Text = currentOfficial.GetAttribute("last_name").ToString();
            TxtBoxEmail.Text = currentOfficial.GetAttribute("email").ToString();
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            string identification = TxtBoxIdentification.Text;
            string name = TxtBoxName.Text;
            string lastName = TxtBoxLastName.Text;
            string email = TxtBoxEmail.Text;
            string pwd = TxtBoxPwd.Text;
            string rol = currentOfficial.GetAttribute("rol").ToString();
            bool status = Convert.ToBoolean(currentOfficial.GetAttribute("status"));

            Models.Official editedOfficial = new Models.Official(currentOfficialId, identification, name, lastName, email, pwd, rol, status);

            bool isUpdated = officialController.UpdateOfficial(editedOfficial);

            string msg = (isUpdated) ? "Se actualizó" : "No se pudo actualizar";
            MessageBox.Show(msg);
        }
    }
}
