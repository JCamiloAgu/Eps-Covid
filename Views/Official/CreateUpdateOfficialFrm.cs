using CitasEps.Controllers;
using System;
using System.Windows.Forms;

namespace CitasEps.Views.Official
{
    public partial class CreateUpdateOfficialFrm : Form
    {
        private readonly OfficialsController officialsController;
        private readonly LogsController logController;

        private Models.Official official;

        private readonly Func<object> OnCloseForm;

        public CreateUpdateOfficialFrm(Func<object> OnCloseForm, string officialId = null)
        {
            this.OnCloseForm = OnCloseForm;

            officialsController = new OfficialsController();
            logController = new LogsController();


            if (officialId != null)
                official = officialsController.GetOfficialById(officialId);

            InitializeComponent();
        }

        private void CreateUpdateOfficialFrm_Load(object sender, EventArgs e)
        {
            if (official != null)
            {
                TxtBoxName.Text = official.GetAttribute("name").ToString();
                TxtBoxLastName.Text = official.GetAttribute("last_name").ToString();
                TxtBoxIdentification.Text = official.GetAttribute("identification").ToString();
                TxtBoxEmail.Text = official.GetAttribute("email").ToString();

                TxtBoxPwd.Visible = false;
                LabelPassword.Visible = false;

                CheckBoxStatus.Checked = Convert.ToBoolean(official.GetAttribute("status"));

                string rol = official.GetAttribute("rol").ToString();

                if (rol == "medico")
                    RadioButtonDoctor.Checked = true;
                else
                    RadioButtonAdmin.Checked = true;
            }

            RadioButtonAdmin.Checked = true;
        }

        private void BtnSaveOfficial_Click(object sender, EventArgs e)
        {
            if (official == null)
                CreateOfficial();
            else
                UpdateOfficial();
        }

        private void CreateOfficial()
        {
            bool isOk = false;
            int id = officialsController.CreateOfficial(BuildOfficial());

            if (id != -1)
            {
                isOk = true;
                official = officialsController.GetOfficialById(id.ToString());
                logController.CreateLog($"Se creó un funcionario nuevo con id: {id}");
            }

            ShowOperationStatusMessage(isOk);
        }

        private void UpdateOfficial()
        {
            int officialId = Convert.ToInt32(official.GetAttribute("id"));
            bool isOk = officialsController.UpdateOfficial(BuildOfficial(officialId));

            if (isOk)
                logController.CreateLog($"Se editó el funcionario con id: {officialId}");

            ShowOperationStatusMessage(isOk);
        }

        private Models.Official BuildOfficial(int officialId = 0)
        {
            string name = TxtBoxName.Text;
            string lastName = TxtBoxLastName.Text;
            string identification = TxtBoxIdentification.Text;
            string email= TxtBoxEmail.Text;
            string pwd= (officialId == 0) ? TxtBoxPwd.Text : null;

            bool status = CheckBoxStatus.Checked;
            string rol = (RadioButtonAdmin.Checked) ? "administrador" : "medico" ;

            return new Models.Official(officialId, identification, name, lastName, email, pwd, rol, status);
        }

        private void ShowOperationStatusMessage(bool isOk)
        {
            string msg = (isOk) ? "Operación realizada con éxito" : "No se pudo realizar la operación, intenta nuevamente";
            MessageBox.Show(msg);
        }

        private void CreateUpdateOfficialFrm_FormClosed(object sender, FormClosedEventArgs e) => OnCloseForm();
        
    }
}
