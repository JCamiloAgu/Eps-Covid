namespace CitasEps.Views.User {
	partial class HomeFrm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.containerPanel = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileItemName = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Location = new System.Drawing.Point(0, 35);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(799, 416);
            this.containerPanel.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasToolStripMenuItem,
            this.medicosToolStripMenuItem,
            this.profileItemName});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.citasToolStripMenuItem.Text = "Mis Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.medicosToolStripMenuItem.Text = "Agendar Cita";
            this.medicosToolStripMenuItem.Click += new System.EventHandler(this.medicosToolStripMenuItem_Click);
            // 
            // profileItemName
            // 
            this.profileItemName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.profileItemName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.profileItemName.Name = "profileItemName";
            this.profileItemName.Size = new System.Drawing.Size(22, 20);
            this.profileItemName.Text = " ";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.perfilToolStripMenuItem.Text = "Editar Perfil";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "HomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de citas";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel containerPanel;
		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem profileItemName;
		private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
	}
}