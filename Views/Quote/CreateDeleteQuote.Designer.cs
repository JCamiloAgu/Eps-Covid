namespace CitasEps.Views.Quote
{
    partial class CreateDeleteQuote
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
            this.DateTimePickerQuoteDate = new System.Windows.Forms.DateTimePicker();
            this.BtnSaveOrDeleteQuote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxUserIdentification = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTimePickerQuoteDate
            // 
            this.DateTimePickerQuoteDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerQuoteDate.Location = new System.Drawing.Point(68, 91);
            this.DateTimePickerQuoteDate.Name = "DateTimePickerQuoteDate";
            this.DateTimePickerQuoteDate.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerQuoteDate.TabIndex = 22;
            this.DateTimePickerQuoteDate.Value = new System.DateTime(2020, 6, 30, 18, 36, 34, 0);
            // 
            // BtnSaveOrDeleteQuote
            // 
            this.BtnSaveOrDeleteQuote.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSaveOrDeleteQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveOrDeleteQuote.ForeColor = System.Drawing.Color.White;
            this.BtnSaveOrDeleteQuote.Location = new System.Drawing.Point(68, 180);
            this.BtnSaveOrDeleteQuote.Name = "BtnSaveOrDeleteQuote";
            this.BtnSaveOrDeleteQuote.Size = new System.Drawing.Size(200, 23);
            this.BtnSaveOrDeleteQuote.TabIndex = 21;
            this.BtnSaveOrDeleteQuote.Text = "Guardar";
            this.BtnSaveOrDeleteQuote.UseVisualStyleBackColor = false;
            this.BtnSaveOrDeleteQuote.Click += new System.EventHandler(this.BtnSaveOrDeleteQuote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha y hora de la cita";
            // 
            // TxtBoxUserIdentification
            // 
            this.TxtBoxUserIdentification.Location = new System.Drawing.Point(68, 144);
            this.TxtBoxUserIdentification.Name = "TxtBoxUserIdentification";
            this.TxtBoxUserIdentification.Size = new System.Drawing.Size(200, 20);
            this.TxtBoxUserIdentification.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Identificación del usuario";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Nombre:";
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Location = new System.Drawing.Point(118, 40);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(0, 13);
            this.lblNameUser.TabIndex = 26;
            // 
            // CreateDeleteQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 260);
            this.Controls.Add(this.lblNameUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxUserIdentification);
            this.Controls.Add(this.DateTimePickerQuoteDate);
            this.Controls.Add(this.BtnSaveOrDeleteQuote);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateDeleteQuote";
            this.Text = "Cita médica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateUpdateQuote_FormClosed);
            this.Load += new System.EventHandler(this.CreateUpdateQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimePickerQuoteDate;
        private System.Windows.Forms.Button BtnSaveOrDeleteQuote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxUserIdentification;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblNameUser;
	}
}