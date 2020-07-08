using CitasEps.Controllers;
using System;
using System.Windows.Forms;

namespace CitasEps.Views.Affiliate
{
    public partial class CreateUpdateAffiliateFrm : Form
    {
        private readonly AffiliatesController affiliatesController;
        private readonly LogsController logController;

        private Models.Affiliate affiliate;

        private readonly Func<object> OnCloseForm;

        public CreateUpdateAffiliateFrm(Func<object> OnCloseForm, string affiliateId = null)
        {
            this.OnCloseForm = OnCloseForm;

            affiliatesController = new AffiliatesController();
            logController = new LogsController();


            if (affiliateId != null)
                affiliate = affiliatesController.Get("id", affiliateId);

            InitializeComponent();
        }

        private void CreateUpdateAffiliateFrm_Load(object sender, EventArgs e)
        {
            if (affiliate != null)
            {
                TxtBoxIdentification.Text = affiliate.GetAttribute("identification").ToString();
                TxtBoxName.Text = affiliate.GetAttribute("name").ToString();
                TxtBoxLastName.Text = affiliate.GetAttribute("last_name").ToString();

                CheckBoxStatus.Checked = Convert.ToBoolean(affiliate.GetAttribute("status"));
            }
        }

        private void BtnSaveAffiliate_Click(object sender, EventArgs e)
        {
            if (affiliate == null)
                CreateAffiliate();
            else
                UpdateAffiliate();

        }

        private void CreateAffiliate()
        {
            bool isOk = false;
            int id = affiliatesController.CreateAffiliate(BuildAffiliate());

            if (id != -1)
            {
                isOk = true;
                affiliate = affiliatesController.Get("id", id.ToString());
                logController.CreateLog($"Se creó un nuevo afiliado con id: {id}");
            }

            ShowOperationStatusMessage(isOk);
        }

        private void UpdateAffiliate()
        {
            int affiliateId = Convert.ToInt32(affiliate.GetAttribute("id"));
            bool isOk = affiliatesController.UpdateAffiliate(BuildAffiliate(affiliateId));

            if (isOk)
                logController.CreateLog($"Se editó el afiliado con id: {affiliateId}");

            ShowOperationStatusMessage(isOk);
        }

        private Models.Affiliate BuildAffiliate(int affiliateId = 0)
        {
            string name = TxtBoxName.Text;
            string lastName = TxtBoxLastName.Text;
            string identification = TxtBoxIdentification.Text;

            bool status = CheckBoxStatus.Checked;

            return new Models.Affiliate(affiliateId, name, lastName, identification, status);
        }

        private void ShowOperationStatusMessage(bool isOk)
        {
            string msg = (isOk) ? "Operación realizada con éxito" : "No se pudo realizar la operación, intenta nuevamente";
            MessageBox.Show(msg);
        }

        private void CreateUpdateAffiliateFrm_FormClosed(object sender, FormClosedEventArgs e) => OnCloseForm();
    }
}
