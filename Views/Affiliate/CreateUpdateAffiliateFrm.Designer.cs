namespace CitasEps.Views.Affiliate
{
    partial class CreateUpdateAffiliateFrm
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
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxLastName = new System.Windows.Forms.TextBox();
            this.TxtBoxIdentification = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxStatus = new System.Windows.Forms.CheckBox();
            this.BtnSaveAffiliate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(23, 40);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(303, 20);
            this.TxtBoxName.TabIndex = 0;
            // 
            // TxtBoxLastName
            // 
            this.TxtBoxLastName.Location = new System.Drawing.Point(23, 90);
            this.TxtBoxLastName.Name = "TxtBoxLastName";
            this.TxtBoxLastName.Size = new System.Drawing.Size(303, 20);
            this.TxtBoxLastName.TabIndex = 1;
            // 
            // TxtBoxIdentification
            // 
            this.TxtBoxIdentification.Location = new System.Drawing.Point(23, 141);
            this.TxtBoxIdentification.Name = "TxtBoxIdentification";
            this.TxtBoxIdentification.Size = new System.Drawing.Size(303, 20);
            this.TxtBoxIdentification.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identificación";
            // 
            // CheckBoxStatus
            // 
            this.CheckBoxStatus.AutoSize = true;
            this.CheckBoxStatus.ForeColor = System.Drawing.Color.Black;
            this.CheckBoxStatus.Location = new System.Drawing.Point(23, 176);
            this.CheckBoxStatus.Name = "CheckBoxStatus";
            this.CheckBoxStatus.Size = new System.Drawing.Size(68, 17);
            this.CheckBoxStatus.TabIndex = 8;
            this.CheckBoxStatus.Text = "¿Activo?";
            this.CheckBoxStatus.UseVisualStyleBackColor = true;
            // 
            // BtnSaveAffiliate
            // 
            this.BtnSaveAffiliate.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSaveAffiliate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveAffiliate.Location = new System.Drawing.Point(23, 207);
            this.BtnSaveAffiliate.Name = "BtnSaveAffiliate";
            this.BtnSaveAffiliate.Size = new System.Drawing.Size(303, 23);
            this.BtnSaveAffiliate.TabIndex = 9;
            this.BtnSaveAffiliate.Text = "Guardar";
            this.BtnSaveAffiliate.UseVisualStyleBackColor = false;
            this.BtnSaveAffiliate.Click += new System.EventHandler(this.BtnSaveAffiliate_Click);
            // 
            // CreateUpdateAffiliateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 288);
            this.Controls.Add(this.BtnSaveAffiliate);
            this.Controls.Add(this.CheckBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxIdentification);
            this.Controls.Add(this.TxtBoxLastName);
            this.Controls.Add(this.TxtBoxName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateUpdateAffiliateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afiliado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateUpdateAffiliateFrm_FormClosed);
            this.Load += new System.EventHandler(this.CreateUpdateAffiliateFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.TextBox TxtBoxLastName;
        private System.Windows.Forms.TextBox TxtBoxIdentification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxStatus;
        private System.Windows.Forms.Button BtnSaveAffiliate;
    }
}