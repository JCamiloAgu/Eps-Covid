using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CitasEps.Views.Quote;
using CitasEps.Constants;

namespace CitasEps.Views.User {
	public partial class Home : Form {
		public Home() {
			InitializeComponent();
			OpenFormChild(new QuoteUser());
		}



		private void OpenFormChild(object formChild) {
			if (containerPanel.Controls.Count > 0)
				containerPanel.Controls.RemoveAt(0);

			Form form = formChild as Form;
			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			containerPanel.Controls.Add(form);
			containerPanel.Tag = form;
			form.Show();
		}

		private void Home_Load(object sender, EventArgs e) {
			string CurrentUserName = CurrentUser.currentUserName;
			profileItemName.Text = CurrentUserName + " ▼";
		}

		private void citasToolStripMenuItem_Click(object sender, EventArgs e) => OpenFormChild(new QuoteUser());

		private void medicosToolStripMenuItem_Click(object sender, EventArgs e) => OpenFormChild(new Doctors.DoctorsListUser());

		private void perfilToolStripMenuItem_Click(object sender, EventArgs e) {
			FrmUserProfile frmProfile = new FrmUserProfile();
			frmProfile.Show();
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e) {
			login frmLogin = new login();
			frmLogin.Show();
			Close();
		}
	}
}
