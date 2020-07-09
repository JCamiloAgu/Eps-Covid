namespace CitasEps.Views.Doctors {
	partial class DoctorsListUserFrm {
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
            this.listViewDoctors = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewDoctors
            // 
            this.listViewDoctors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name});
            this.listViewDoctors.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewDoctors.HideSelection = false;
            this.listViewDoctors.Location = new System.Drawing.Point(463, 49);
            this.listViewDoctors.Name = "listViewDoctors";
            this.listViewDoctors.Size = new System.Drawing.Size(316, 362);
            this.listViewDoctors.TabIndex = 0;
            this.listViewDoctors.UseCompatibleStateImageBehavior = false;
            this.listViewDoctors.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 100;
            // 
            // name
            // 
            this.name.Text = "NOMBRE";
            this.name.Width = 200;
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(25, 71);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(357, 20);
            this.txtDoctorId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID del medico";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver Calendario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione un médico para agendar una cita";
            // 
            // DoctorsListUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoctorId);
            this.Controls.Add(this.listViewDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorsListUserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsListUser";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listViewDoctors;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.TextBox txtDoctorId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
	}
}