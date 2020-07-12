using CitasEps.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CitasEps.Views.Quote
{
    public partial class UserQuoteFrm : Form
    {
        private readonly string idQuote;
        private readonly QuotesController quotesController;
        private readonly UsersController usersController;
        private readonly AffiliatesController affiliatesController;
        private readonly MediaController mediaController;
        private readonly List<string> ids = new List<string>();


        public UserQuoteFrm(string idQuote)
        {
            InitializeComponent();
            this.idQuote = idQuote;
            quotesController = new QuotesController();
            usersController = new UsersController();
            affiliatesController = new AffiliatesController();
            mediaController = new MediaController();
        }

        private void LoadData()
        {
            listViewMedia.Items.Clear();
            Models.Quote quote = quotesController.GetById(idQuote);
            Models.User user = usersController.GetByAttribute("id", quote.GetAttribute("id_users").ToString());
            Models.Affiliate affiliate = affiliatesController.Get("id", user.GetAttribute("id_affiliates").ToString());
            List<Models.Media> mediaList = mediaController.GetAllByUser(user.GetAttribute("id").ToString());
            lblDate.Text = quote.GetAttribute("date_time").ToString();
            lblEmail.Text = user.GetAttribute("email").ToString();
            lblPhone.Text = user.GetAttribute("phone").ToString();
            lblName.Text = affiliate.GetAttribute("name").ToString() + " " + affiliate.GetAttribute("last_name").ToString();
            lblCurrentMedia.Text = "Sin asignar";
            foreach (var item in mediaList)
            {
                ListViewItem colums = listViewMedia.Items.Add(item.GetAttribute("id").ToString());
                colums.SubItems.Add(item.GetAttribute("name").ToString());
                ids.Add(item.GetAttribute("id").ToString());
                if (item.GetAttribute("id").ToString() == quote.GetAttribute("id_media").ToString())
                {
                    lblCurrentMedia.Text = item.GetAttribute("name").ToString();
                }
            }
        }

        private void userQuoteView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idMedia = txtQuote.Text;
            txtQuote.Text = "";
            int findResult = ids.IndexOf(idMedia);
            if (findResult != -1)
            {
                Models.Quote quote = new Models.Quote(int.Parse(idQuote), 0, 0, int.Parse(idMedia), DateTime.Now);
                quotesController.UpdateQuoute(quote);
                MessageBox.Show("Cita asignada con exito", "Mensaje");
                LoadData();
            }
            else
            {
                MessageBox.Show("Medio no encontrado", "Error");
            }
        }
    }
}
