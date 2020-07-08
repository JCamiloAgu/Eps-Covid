namespace CitasEps.Views.Official
{
    partial class OfficialsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxOfficialId = new System.Windows.Forms.TextBox();
            this.BtnEditOfficial = new System.Windows.Forms.Button();
            this.BtnDeleteOfficial = new System.Windows.Forms.Button();
            this.BtnCreateOfficial = new System.Windows.Forms.Button();
            this.ListViewOfficials = new System.Windows.Forms.ListView();
            this.officialId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officialName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officialLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officialIdentification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officialEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officialRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officialStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnShowSchedule = new System.Windows.Forms.Button();
            this.BtnShowCalendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id del funcionario";
            // 
            // TxtBoxOfficialId
            // 
            this.TxtBoxOfficialId.Location = new System.Drawing.Point(15, 70);
            this.TxtBoxOfficialId.Name = "TxtBoxOfficialId";
            this.TxtBoxOfficialId.Size = new System.Drawing.Size(196, 20);
            this.TxtBoxOfficialId.TabIndex = 10;
            // 
            // BtnEditOfficial
            // 
            this.BtnEditOfficial.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEditOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditOfficial.ForeColor = System.Drawing.Color.White;
            this.BtnEditOfficial.Location = new System.Drawing.Point(336, 67);
            this.BtnEditOfficial.Name = "BtnEditOfficial";
            this.BtnEditOfficial.Size = new System.Drawing.Size(75, 23);
            this.BtnEditOfficial.TabIndex = 9;
            this.BtnEditOfficial.Text = "Editar";
            this.BtnEditOfficial.UseVisualStyleBackColor = false;
            this.BtnEditOfficial.Click += new System.EventHandler(this.BtnEditOfficial_Click);
            // 
            // BtnDeleteOfficial
            // 
            this.BtnDeleteOfficial.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnDeleteOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteOfficial.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteOfficial.Location = new System.Drawing.Point(417, 67);
            this.BtnDeleteOfficial.Name = "BtnDeleteOfficial";
            this.BtnDeleteOfficial.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteOfficial.TabIndex = 8;
            this.BtnDeleteOfficial.Text = "Eliminar";
            this.BtnDeleteOfficial.UseVisualStyleBackColor = false;
            this.BtnDeleteOfficial.Click += new System.EventHandler(this.BtnDeleteOfficial_Click);
            // 
            // BtnCreateOfficial
            // 
            this.BtnCreateOfficial.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCreateOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateOfficial.ForeColor = System.Drawing.Color.White;
            this.BtnCreateOfficial.Location = new System.Drawing.Point(255, 67);
            this.BtnCreateOfficial.Name = "BtnCreateOfficial";
            this.BtnCreateOfficial.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateOfficial.TabIndex = 7;
            this.BtnCreateOfficial.Text = "Añadir";
            this.BtnCreateOfficial.UseVisualStyleBackColor = false;
            this.BtnCreateOfficial.Click += new System.EventHandler(this.BtnCreateOfficial_Click);
            // 
            // ListViewOfficials
            // 
            this.ListViewOfficials.BackColor = System.Drawing.Color.White;
            this.ListViewOfficials.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewOfficials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.officialId,
            this.officialName,
            this.officialLastName,
            this.officialIdentification,
            this.officialEmail,
            this.officialRol,
            this.officialStatus});
            this.ListViewOfficials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListViewOfficials.ForeColor = System.Drawing.Color.Black;
            this.ListViewOfficials.HideSelection = false;
            this.ListViewOfficials.Location = new System.Drawing.Point(0, 114);
            this.ListViewOfficials.Name = "ListViewOfficials";
            this.ListViewOfficials.Size = new System.Drawing.Size(1080, 536);
            this.ListViewOfficials.TabIndex = 6;
            this.ListViewOfficials.UseCompatibleStateImageBehavior = false;
            this.ListViewOfficials.View = System.Windows.Forms.View.Details;
            // 
            // officialId
            // 
            this.officialId.Text = "ID";
            this.officialId.Width = 72;
            // 
            // officialName
            // 
            this.officialName.Text = "Nombre";
            this.officialName.Width = 134;
            // 
            // officialLastName
            // 
            this.officialLastName.Text = "Apellido";
            this.officialLastName.Width = 110;
            // 
            // officialIdentification
            // 
            this.officialIdentification.Text = "Identificación";
            this.officialIdentification.Width = 100;
            // 
            // officialEmail
            // 
            this.officialEmail.Text = "Correo electrónico";
            this.officialEmail.Width = 143;
            // 
            // officialRol
            // 
            this.officialRol.Text = "Rol";
            this.officialRol.Width = 75;
            // 
            // officialStatus
            // 
            this.officialStatus.Text = "Estado";
            this.officialStatus.Width = 72;
            // 
            // BtnShowSchedule
            // 
            this.BtnShowSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnShowSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowSchedule.ForeColor = System.Drawing.Color.White;
            this.BtnShowSchedule.Location = new System.Drawing.Point(809, 67);
            this.BtnShowSchedule.Name = "BtnShowSchedule";
            this.BtnShowSchedule.Size = new System.Drawing.Size(115, 23);
            this.BtnShowSchedule.TabIndex = 12;
            this.BtnShowSchedule.Text = "Ver agenda";
            this.BtnShowSchedule.UseVisualStyleBackColor = false;
            this.BtnShowSchedule.Click += new System.EventHandler(this.BtnShowSchedule_Click);
            // 
            // BtnShowCalendar
            // 
            this.BtnShowCalendar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnShowCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowCalendar.ForeColor = System.Drawing.Color.White;
            this.BtnShowCalendar.Location = new System.Drawing.Point(930, 67);
            this.BtnShowCalendar.Name = "BtnShowCalendar";
            this.BtnShowCalendar.Size = new System.Drawing.Size(115, 23);
            this.BtnShowCalendar.TabIndex = 13;
            this.BtnShowCalendar.Text = "Ver calendario";
            this.BtnShowCalendar.UseVisualStyleBackColor = false;
            this.BtnShowCalendar.Click += new System.EventHandler(this.BtnShowCalendar_Click);
            // 
            // OfficialsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.Controls.Add(this.BtnShowCalendar);
            this.Controls.Add(this.BtnShowSchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxOfficialId);
            this.Controls.Add(this.BtnEditOfficial);
            this.Controls.Add(this.BtnDeleteOfficial);
            this.Controls.Add(this.BtnCreateOfficial);
            this.Controls.Add(this.ListViewOfficials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OfficialsFrm";
            this.Text = "OfficialsFrm";
            this.Load += new System.EventHandler(this.OfficialsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxOfficialId;
        private System.Windows.Forms.Button BtnEditOfficial;
        private System.Windows.Forms.Button BtnDeleteOfficial;
        private System.Windows.Forms.Button BtnCreateOfficial;
        private System.Windows.Forms.ListView ListViewOfficials;
        private System.Windows.Forms.ColumnHeader officialId;
        private System.Windows.Forms.ColumnHeader officialName;
        private System.Windows.Forms.ColumnHeader officialLastName;
        private System.Windows.Forms.ColumnHeader officialIdentification;
        private System.Windows.Forms.ColumnHeader officialStatus;
        private System.Windows.Forms.ColumnHeader officialEmail;
        private System.Windows.Forms.ColumnHeader officialRol;
        private System.Windows.Forms.Button BtnShowSchedule;
        private System.Windows.Forms.Button BtnShowCalendar;
    }
}