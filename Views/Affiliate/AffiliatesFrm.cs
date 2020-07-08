using CitasEps.Controllers;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace CitasEps.Views.Affiliate
{
    public partial class AffiliatesFrm : Form
    {
        private readonly AffiliatesController affiliatesController;
        private readonly LogsController logController;

        private List<Models.Affiliate> affiliates;

        public AffiliatesFrm()
        {
            InitializeComponent();
            affiliatesController = new AffiliatesController();
            logController = new LogsController();
        }

        private void AffiliatesFrm_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            affiliates = affiliatesController.GetAll();
            if (affiliates != null)
                ShowAffiliatesInListView();
        }

        private void ShowAffiliatesInListView()
        {
            ListViewAffiliates.Items.Clear();
            foreach (Models.Affiliate affiliate in affiliates)
            {
                string id = affiliate.GetAttribute("id").ToString();
                string name = affiliate.GetAttribute("name").ToString();
                string lastName = affiliate.GetAttribute("last_name").ToString();
                string identification = affiliate.GetAttribute("identification").ToString();
                string status = Convert.ToBoolean(affiliate.GetAttribute("status")) ? "Activo" : "No activo";

                ListViewItem item = ListViewAffiliates.Items.Add(id);
                item.SubItems.Add(name);
                item.SubItems.Add(lastName);
                item.SubItems.Add(identification);
                item.SubItems.Add(status);
            }
        }

        private void BtnCreateAffiliate_Click(object sender, EventArgs e)
        {
            CreateUpdateAffiliateFrm createUpdateAffiliateFrm = new CreateUpdateAffiliateFrm(OnCloseCreateUpdateAffiliateForm);
            createUpdateAffiliateFrm.Show();
        }

        private object OnCloseCreateUpdateAffiliateForm()
        {
            LoadData();
            return null;
        }

        private void BtnEditAffiliate_Click(object sender, EventArgs e)
        {
            string affiliateId = TxtBoxAffiliateId.Text;

            if (IsValidId(affiliateId))

                new CreateUpdateAffiliateFrm(OnCloseCreateUpdateAffiliateForm, affiliateId).Show();
            else
                ShowMessageIncorrectId();
        }

        private bool IsValidId(string affiliateId)
        {
            if (affiliateId == null || affiliateId == "")
                return false;

            bool existId = affiliates.Exists(match: (affiliate) => affiliate.GetAttribute("id").ToString() == affiliateId);

            return existId;
        }

        private void ShowMessageIncorrectId() =>
            MessageBox.Show("No se encontró el id del afiliado");

        private void BtnDeleteAffiliate_Click(object sender, EventArgs e)
        {
            string affiliateId = TxtBoxAffiliateId.Text;

            if (IsValidId(affiliateId))
                DeleteAffiliate(affiliateId);
            else
                ShowMessageIncorrectId();
        }

        private void DeleteAffiliate(string affiliateId)
        {
            bool isOk = affiliatesController.DeleteAffiliate(affiliateId);

            if (isOk)
            {
                RemoveAffiliateFromLocal(affiliateId);
                TxtBoxAffiliateId.Text = "";
                logController.CreateLog($"Se eliminó el afiliado con id: {affiliateId}");
            }
            else
                MessageBox.Show("No se pudo eliminar");
        }

        private void RemoveAffiliateFromLocal(string affiliateId)
        {
            int index =
                    affiliates.FindIndex(match: (affiliate) => affiliate.GetAttribute("id").ToString() == affiliateId);

            ListViewAffiliates.Items.RemoveAt(index);
            affiliates.RemoveAt(index);
        }
    }
}
