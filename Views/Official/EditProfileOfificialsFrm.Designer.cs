namespace CitasEps.Views.Official
{
    partial class EditProfileOfificialsFrm
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
            this.TxtBoxIdentification = new System.Windows.Forms.TextBox();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxLastName = new System.Windows.Forms.TextBox();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEditProfile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBoxIdentification
            // 
            this.TxtBoxIdentification.Location = new System.Drawing.Point(360, 161);
            this.TxtBoxIdentification.Name = "TxtBoxIdentification";
            this.TxtBoxIdentification.Size = new System.Drawing.Size(311, 20);
            this.TxtBoxIdentification.TabIndex = 0;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(360, 216);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(311, 20);
            this.TxtBoxName.TabIndex = 1;
            // 
            // TxtBoxLastName
            // 
            this.TxtBoxLastName.Location = new System.Drawing.Point(360, 267);
            this.TxtBoxLastName.Name = "TxtBoxLastName";
            this.TxtBoxLastName.Size = new System.Drawing.Size(311, 20);
            this.TxtBoxLastName.TabIndex = 2;
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(360, 321);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(311, 20);
            this.TxtBoxEmail.TabIndex = 3;
            // 
            // TxtBoxPwd
            // 
            this.TxtBoxPwd.Location = new System.Drawing.Point(360, 375);
            this.TxtBoxPwd.Name = "TxtBoxPwd";
            this.TxtBoxPwd.Size = new System.Drawing.Size(311, 20);
            this.TxtBoxPwd.TabIndex = 4;
            this.TxtBoxPwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Correo electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contraseña";
            // 
            // BtnEditProfile
            // 
            this.BtnEditProfile.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditProfile.ForeColor = System.Drawing.Color.White;
            this.BtnEditProfile.Location = new System.Drawing.Point(360, 415);
            this.BtnEditProfile.Name = "BtnEditProfile";
            this.BtnEditProfile.Size = new System.Drawing.Size(311, 23);
            this.BtnEditProfile.TabIndex = 10;
            this.BtnEditProfile.Text = "Editar";
            this.BtnEditProfile.UseVisualStyleBackColor = false;
            this.BtnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Perfil";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnEditProfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxPwd);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.TxtBoxLastName);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.TxtBoxIdentification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProfile";
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxIdentification;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.TextBox TxtBoxLastName;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.TextBox TxtBoxPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEditProfile;
        private System.Windows.Forms.Label label7;
    }
}