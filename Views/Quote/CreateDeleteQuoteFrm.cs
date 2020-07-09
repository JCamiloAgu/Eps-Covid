using CitasEps.Controllers;
using System;

using System.Windows.Forms;

namespace CitasEps.Views.Quote
{
    public partial class CreateDeleteQuoteFrm : Form
    {
        private readonly QuotesController quotesController;
        private readonly AffiliatesController affiliatesController;
        private readonly UsersController usersController;
        private readonly LogsController logController;

        private Models.Quote quote;
        private Models.Affiliate affiliate;

        private readonly Func<bool, object> OnCloseForm;

        private readonly string officialId;

        private bool requireRefresh = false;

        private DateTime quoteDateTime;

        public CreateDeleteQuoteFrm(Func<bool, object> OnCloseForm, string officialId, string quoteId, DateTime quoteDateTime)
        {
            InitializeComponent();
            lblName.Hide();
            lblNameUser.Text = "";

            this.OnCloseForm = OnCloseForm;
            this.officialId = officialId;
            this.quoteDateTime = quoteDateTime;

            quotesController = new QuotesController();
            logController = new LogsController();
            affiliatesController = new AffiliatesController();
            usersController = new UsersController();

            if (quoteId != null)
                quote = quotesController.GetById(quoteId);

        }

        private void CreateUpdateQuote_Load(object sender, EventArgs e)
        {

            // Si exite cita, mostrar formulario de elminar
            if (quote != null)
            {
                Models.User user = usersController.GetByAttribute("id", quote.GetAttribute("id_users").ToString());
                affiliate = affiliatesController.Get("id", user.GetAttribute("id_affiliates").ToString());
                DateTimePickerQuoteDate.Value = Convert.ToDateTime(quote.GetAttribute("date_time"));

                TxtBoxUserIdentification.Text = affiliate.GetAttribute("identification").ToString();
                lblName.Show();
                lblNameUser.Text = affiliate.GetAttribute("name").ToString() + " " + affiliate.GetAttribute("last_name").ToString();
                BtnSaveOrDeleteQuote.Text = "Eliminar";
            }
            else
            {
                lblName.Hide();
                lblNameUser.Text = "";
                DateTimePickerQuoteDate.Value = quoteDateTime;
            }

            DateTimePickerQuoteDate.Enabled = false;
        }

        private void BtnSaveOrDeleteQuote_Click(object sender, EventArgs e)
        {
            if (quote == null)
                CreateQuote();
            else
                DeleteQuote(quote.GetAttribute("id").ToString());
        }

        private void CreateQuote()
        {
            bool isOk = false;

            Models.Quote buildedQuote = BuildQuote();

            if (buildedQuote != null)
            {
                int id = quotesController.CreateQuote(buildedQuote);

                if (id != -1)
                {
                    isOk = true;
                    quote = quotesController.GetById(id.ToString());
                    logController.CreateLog($"Se creó una nueva cita con id: {id}");
                    requireRefresh = true;
                    Close();
                }

                ShowOperationStatusMessage(isOk);
            }
            else
                MessageBox.Show($"No se encontró un usuario con la identificación {TxtBoxUserIdentification.Text}");

        }

        private Models.Quote BuildQuote(int quoteId = 0)
        {
            Models.Affiliate newAffiliate = affiliatesController.Get("identification", TxtBoxUserIdentification.Text);

            if (newAffiliate != null)
            {
                Models.User user = usersController.GetByAttribute("id_affiliates", newAffiliate.GetAttribute("id").ToString());
                int userId = Convert.ToInt32(user.GetAttribute("id").ToString());
                return new Models.Quote(quoteId, userId, Convert.ToInt32(officialId), 0, DateTimePickerQuoteDate.Value);
            }
            else
                return null;
        }

        private void ShowOperationStatusMessage(bool isOk)
        {
            string msg = (isOk) ? "Operación realizada con éxito" : "No se pudo realizar la operación, intenta nuevamente";
            MessageBox.Show(msg);
        }

        private void DeleteQuote(string quoteId)
        {
            bool isOk = quotesController.DeleteQuote(quoteId);

            if (isOk)
            {
                logController.CreateLog($"Se eliminó la cita con id: {quoteId}");
                requireRefresh = true;
                Close();
            }
            else
                MessageBox.Show("No se pudo eliminar");
        }

        private void CreateUpdateQuote_FormClosed(object sender, FormClosedEventArgs e) => OnCloseForm(requireRefresh);
    }
}
