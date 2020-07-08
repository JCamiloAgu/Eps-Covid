namespace CitasEps.Views.Affiliate
{
    partial class AffiliatesFrm
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
            this.ListViewAffiliates = new System.Windows.Forms.ListView();
            this.affiliateId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.affiliateName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.affiliateLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.affiliateIdentification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.affiliateStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnCreateAffiliate = new System.Windows.Forms.Button();
            this.BtnDeleteAffiliate = new System.Windows.Forms.Button();
            this.BtnEditAffiliate = new System.Windows.Forms.Button();
            this.TxtBoxAffiliateId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListViewAffiliates
            // 
            this.ListViewAffiliates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewAffiliates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.affiliateId,
            this.affiliateName,
            this.affiliateLastName,
            this.affiliateIdentification,
            this.affiliateStatus});
            this.ListViewAffiliates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ListViewAffiliates.HideSelection = false;
            this.ListViewAffiliates.Location = new System.Drawing.Point(0, 121);
            this.ListViewAffiliates.Name = "ListViewAffiliates";
            this.ListViewAffiliates.Size = new System.Drawing.Size(1080, 529);
            this.ListViewAffiliates.TabIndex = 0;
            this.ListViewAffiliates.UseCompatibleStateImageBehavior = false;
            this.ListViewAffiliates.View = System.Windows.Forms.View.Details;
            // 
            // affiliateId
            // 
            this.affiliateId.Text = "ID";
            this.affiliateId.Width = 201;
            // 
            // affiliateName
            // 
            this.affiliateName.Text = "Nombre";
            this.affiliateName.Width = 181;
            // 
            // affiliateLastName
            // 
            this.affiliateLastName.Text = "Apellido";
            this.affiliateLastName.Width = 137;
            // 
            // affiliateIdentification
            // 
            this.affiliateIdentification.Text = "Identificación";
            this.affiliateIdentification.Width = 156;
            // 
            // affiliateStatus
            // 
            this.affiliateStatus.Text = "Estado";
            this.affiliateStatus.Width = 119;
            // 
            // BtnCreateAffiliate
            // 
            this.BtnCreateAffiliate.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCreateAffiliate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateAffiliate.ForeColor = System.Drawing.Color.White;
            this.BtnCreateAffiliate.Location = new System.Drawing.Point(12, 29);
            this.BtnCreateAffiliate.Name = "BtnCreateAffiliate";
            this.BtnCreateAffiliate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateAffiliate.TabIndex = 1;
            this.BtnCreateAffiliate.Text = "Añadir";
            this.BtnCreateAffiliate.UseVisualStyleBackColor = false;
            this.BtnCreateAffiliate.Click += new System.EventHandler(this.BtnCreateAffiliate_Click);
            // 
            // BtnDeleteAffiliate
            // 
            this.BtnDeleteAffiliate.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnDeleteAffiliate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteAffiliate.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAffiliate.Location = new System.Drawing.Point(246, 92);
            this.BtnDeleteAffiliate.Name = "BtnDeleteAffiliate";
            this.BtnDeleteAffiliate.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteAffiliate.TabIndex = 2;
            this.BtnDeleteAffiliate.Text = "Eliminar";
            this.BtnDeleteAffiliate.UseVisualStyleBackColor = false;
            this.BtnDeleteAffiliate.Click += new System.EventHandler(this.BtnDeleteAffiliate_Click);
            // 
            // BtnEditAffiliate
            // 
            this.BtnEditAffiliate.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEditAffiliate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditAffiliate.ForeColor = System.Drawing.Color.White;
            this.BtnEditAffiliate.Location = new System.Drawing.Point(153, 92);
            this.BtnEditAffiliate.Name = "BtnEditAffiliate";
            this.BtnEditAffiliate.Size = new System.Drawing.Size(75, 23);
            this.BtnEditAffiliate.TabIndex = 3;
            this.BtnEditAffiliate.Text = "Editar";
            this.BtnEditAffiliate.UseVisualStyleBackColor = false;
            this.BtnEditAffiliate.Click += new System.EventHandler(this.BtnEditAffiliate_Click);
            // 
            // TxtBoxAffiliateId
            // 
            this.TxtBoxAffiliateId.Location = new System.Drawing.Point(12, 94);
            this.TxtBoxAffiliateId.Name = "TxtBoxAffiliateId";
            this.TxtBoxAffiliateId.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxAffiliateId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id del afiliado";
            // 
            // AffiliatesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxAffiliateId);
            this.Controls.Add(this.BtnEditAffiliate);
            this.Controls.Add(this.BtnDeleteAffiliate);
            this.Controls.Add(this.BtnCreateAffiliate);
            this.Controls.Add(this.ListViewAffiliates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AffiliatesFrm";
            this.Text = "Affiliates";
            this.Load += new System.EventHandler(this.AffiliatesFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewAffiliates;
        private System.Windows.Forms.Button BtnCreateAffiliate;
        private System.Windows.Forms.Button BtnDeleteAffiliate;
        private System.Windows.Forms.Button BtnEditAffiliate;
        private System.Windows.Forms.TextBox TxtBoxAffiliateId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader affiliateId;
        private System.Windows.Forms.ColumnHeader affiliateName;
        private System.Windows.Forms.ColumnHeader affiliateLastName;
        private System.Windows.Forms.ColumnHeader affiliateIdentification;
        private System.Windows.Forms.ColumnHeader affiliateStatus;
    }
}