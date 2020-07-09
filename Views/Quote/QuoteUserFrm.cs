using CitasEps.Constants;
using CitasEps.Controllers;
using CitasEps.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CitasEps.Views.Quote
{
    public partial class QuoteUserFrm : Form
    {
        private QuotesController quotesController;
        private List<string> ids = new List<string>();

        public QuoteUserFrm()
        {
            InitializeComponent();
            quotesController = new QuotesController();
            LoadData();
        }

        private void LoadData()
        {
            ListViewQuotes.Items.Clear();
            int idUser = CurrentUser.id;
            List<OfficialQuote> result = quotesController.GetAllByUser(idUser);
            foreach (var item in result)
            {
                Models.Quote quote = item.GetQuote();
                Models.Official official = item.GetOfficial();
                Media media = item.GetMedia();
                ListViewItem colums = ListViewQuotes.Items.Add(quote.GetAttribute("id").ToString());
                colums.SubItems.Add(quote.GetAttribute("date_time").ToString());
                colums.SubItems.Add(official.GetAttribute("name").ToString() + " " + official.GetAttribute("last_name").ToString());
                colums.SubItems.Add(media.GetAttribute("name").ToString());
                ids.Add(quote.GetAttribute("id").ToString());
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string idQuote = txtId.Text;
            txtId.Text = "";
            int findResult = ids.IndexOf(idQuote);
            if (findResult != -1)
            {
                quotesController.DeleteQuote(idQuote);
                MessageBox.Show("Cita cancelada con exito", "Mensaje");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cita no encontrada", "Error");
            }
        }
    }
}
