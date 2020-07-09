namespace CitasEps.Views.Official
{
    partial class CreateUpdateOfficialFrm
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
            this.BtnSaveOfficial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxIdentification = new System.Windows.Forms.TextBox();
            this.TxtBoxLastName = new System.Windows.Forms.TextBox();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.CheckBoxStatus = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.RadioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.RadioButtonDoctor = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TxtBoxPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSaveOfficial
            // 
            this.BtnSaveOfficial.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSaveOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveOfficial.ForeColor = System.Drawing.Color.White;
            this.BtnSaveOfficial.Location = new System.Drawing.Point(76, 367);
            this.BtnSaveOfficial.Name = "BtnSaveOfficial";
            this.BtnSaveOfficial.Size = new System.Drawing.Size(303, 23);
            this.BtnSaveOfficial.TabIndex = 17;
            this.BtnSaveOfficial.Text = "Guardar";
            this.BtnSaveOfficial.UseVisualStyleBackColor = false;
            this.BtnSaveOfficial.Click += new System.EventHandler(this.BtnSaveOfficial_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // TxtBoxIdentification
            // 
            this.TxtBoxIdentification.Location = new System.Drawing.Point(76, 141);
            this.TxtBoxIdentification.Name = "TxtBoxIdentification";
            this.TxtBoxIdentification.Size = new System.Drawing.Size(303, 20);
            this.TxtBoxIdentification.TabIndex = 12;
            // 
            // TxtBoxLastName
            // 
            this.TxtBoxLastName.Location = new System.Drawing.Point(76, 90);
            this.TxtBoxLastName.Name = "TxtBoxLastName";
            this.TxtBoxLastName.Size = new System.Drawing.Size(303, 20);
            this.TxtBoxLastName.TabIndex = 11;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(76, 40);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(303, 20);
            this.TxtBoxName.TabIndex = 10;
            // 
            // CheckBoxStatus
            // 
            this.CheckBoxStatus.AutoSize = true;
            this.CheckBoxStatus.Location = new System.Drawing.Point(75, 281);
            this.CheckBoxStatus.Name = "CheckBoxStatus";
            this.CheckBoxStatus.Size = new System.Drawing.Size(91, 17);
            this.CheckBoxStatus.TabIndex = 16;
            this.CheckBoxStatus.Text = "¿Está activo?";
            this.CheckBoxStatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Correo electrónico";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(76, 187);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(303, 20);
            this.TxtBoxEmail.TabIndex = 18;
            // 
            // RadioButtonAdmin
            // 
            this.RadioButtonAdmin.AutoSize = true;
            this.RadioButtonAdmin.BackColor = System.Drawing.Color.White;
            this.RadioButtonAdmin.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonAdmin.Location = new System.Drawing.Point(182, 322);
            this.RadioButtonAdmin.Name = "RadioButtonAdmin";
            this.RadioButtonAdmin.Size = new System.Drawing.Size(88, 17);
            this.RadioButtonAdmin.TabIndex = 20;
            this.RadioButtonAdmin.TabStop = true;
            this.RadioButtonAdmin.Text = "Administrador";
            this.RadioButtonAdmin.UseVisualStyleBackColor = false;
            // 
            // RadioButtonDoctor
            // 
            this.RadioButtonDoctor.AutoSize = true;
            this.RadioButtonDoctor.BackColor = System.Drawing.Color.White;
            this.RadioButtonDoctor.ForeColor = System.Drawing.Color.Black;
            this.RadioButtonDoctor.Location = new System.Drawing.Point(294, 322);
            this.RadioButtonDoctor.Name = "RadioButtonDoctor";
            this.RadioButtonDoctor.Size = new System.Drawing.Size(60, 17);
            this.RadioButtonDoctor.TabIndex = 21;
            this.RadioButtonDoctor.TabStop = true;
            this.RadioButtonDoctor.Text = "Médico";
            this.RadioButtonDoctor.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rol";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(73, 225);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(61, 13);
            this.LabelPassword.TabIndex = 24;
            this.LabelPassword.Text = "Contraseña";
            // 
            // TxtBoxPwd
            // 
            this.TxtBoxPwd.Location = new System.Drawing.Point(76, 241);
            this.TxtBoxPwd.Name = "TxtBoxPwd";
            this.TxtBoxPwd.Size = new System.Drawing.Size(303, 20);
            this.TxtBoxPwd.TabIndex = 23;
            this.TxtBoxPwd.UseSystemPasswordChar = true;
            // 
            // CreateUpdateOfficialFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 407);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.TxtBoxPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RadioButtonDoctor);
            this.Controls.Add(this.RadioButtonAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.BtnSaveOfficial);
            this.Controls.Add(this.CheckBoxStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxIdentification);
            this.Controls.Add(this.TxtBoxLastName);
            this.Controls.Add(this.TxtBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateUpdateOfficialFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateUpdateOfficialFrm_FormClosed);
            this.Load += new System.EventHandler(this.CreateUpdateOfficialFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaveOfficial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxIdentification;
        private System.Windows.Forms.TextBox TxtBoxLastName;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.CheckBox CheckBoxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.RadioButton RadioButtonAdmin;
        private System.Windows.Forms.RadioButton RadioButtonDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TxtBoxPwd;
    }
}