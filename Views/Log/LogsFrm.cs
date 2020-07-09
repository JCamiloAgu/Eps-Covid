using CitasEps.Controllers;
using CitasEps.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CitasEps.Views.Log
{
    public partial class LogsFrm : Form
    {
        private readonly LogsController logController;
        private readonly OfficialsController officialController;
        private readonly List<Models.Log> logs;
        public LogsFrm()
        {
            InitializeComponent();

            logController = new LogsController();
            officialController = new OfficialsController();

            logs = logController.GetAll();
            ShowItemsInListView();
        }

        private void ShowItemsInListView()
        {
            foreach (Models.Log log in logs)
            {
                DateTime dateTime = Convert.ToDateTime(log.GetAttribute("date_time"));
                string description = log.GetAttribute("description").ToString();
                string officialId = log.GetAttribute("id_officials").ToString();

                Models.Official official = officialController.GetOfficialById(officialId);
                string officialFullName = $"{official.GetAttribute("name")} {official.GetAttribute("last_name")}";

                ListViewItem item = LogsListView.Items.Add(HelpersService.DateFormatToString(dateTime));
                item.SubItems.Add(description);
                item.SubItems.Add(officialFullName);
            }
        }

        private void LogsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
