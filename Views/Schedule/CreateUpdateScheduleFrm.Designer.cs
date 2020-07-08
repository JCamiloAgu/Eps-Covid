namespace CitasEps.Views.Schedule
{
    partial class CreateUpdateScheduleFrm
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
            this.BtnSaveSchedule = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePickerInitHour = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerEndHour = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnSaveSchedule
            // 
            this.BtnSaveSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSaveSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveSchedule.ForeColor = System.Drawing.Color.White;
            this.BtnSaveSchedule.Location = new System.Drawing.Point(29, 130);
            this.BtnSaveSchedule.Name = "BtnSaveSchedule";
            this.BtnSaveSchedule.Size = new System.Drawing.Size(200, 23);
            this.BtnSaveSchedule.TabIndex = 15;
            this.BtnSaveSchedule.Text = "Guardar";
            this.BtnSaveSchedule.UseVisualStyleBackColor = false;
            this.BtnSaveSchedule.Click += new System.EventHandler(this.BtnSaveSchedule_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha y hora de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha y hora de inicio";
            // 
            // DateTimePickerInitHour
            // 
            this.DateTimePickerInitHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerInitHour.Location = new System.Drawing.Point(29, 42);
            this.DateTimePickerInitHour.Name = "DateTimePickerInitHour";
            this.DateTimePickerInitHour.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerInitHour.TabIndex = 17;
            this.DateTimePickerInitHour.Value = new System.DateTime(2020, 6, 29, 16, 34, 59, 0);
            // 
            // DateTimePickerEndHour
            // 
            this.DateTimePickerEndHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerEndHour.Location = new System.Drawing.Point(29, 93);
            this.DateTimePickerEndHour.Name = "DateTimePickerEndHour";
            this.DateTimePickerEndHour.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerEndHour.TabIndex = 18;
            this.DateTimePickerEndHour.Value = new System.DateTime(2020, 6, 29, 16, 34, 59, 0);
            // 
            // CreateUpdateScheduleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(262, 188);
            this.Controls.Add(this.DateTimePickerEndHour);
            this.Controls.Add(this.DateTimePickerInitHour);
            this.Controls.Add(this.BtnSaveSchedule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateUpdateScheduleFrm";
            this.Text = "Agenda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateUpdateScheduleFrm_FormClosed);
            this.Load += new System.EventHandler(this.CreateUpdateScheduleFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSaveSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimePickerInitHour;
        private System.Windows.Forms.DateTimePicker DateTimePickerEndHour;
    }
}