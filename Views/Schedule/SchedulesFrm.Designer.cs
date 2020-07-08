namespace CitasEps.Views.Schedule
{
    partial class SchedulesFrm
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
            this.TxtBoxScheduleId = new System.Windows.Forms.TextBox();
            this.BtnEditSchedule = new System.Windows.Forms.Button();
            this.BtnDeleteSchedule = new System.Windows.Forms.Button();
            this.BtnCreateSchedule = new System.Windows.Forms.Button();
            this.ListViewSchedules = new System.Windows.Forms.ListView();
            this.scheduleId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduleStartAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduleEndAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scheduleOfficial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id de la agenda";
            // 
            // TxtBoxScheduleId
            // 
            this.TxtBoxScheduleId.Location = new System.Drawing.Point(12, 80);
            this.TxtBoxScheduleId.Name = "TxtBoxScheduleId";
            this.TxtBoxScheduleId.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxScheduleId.TabIndex = 10;
            // 
            // BtnEditSchedule
            // 
            this.BtnEditSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEditSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditSchedule.ForeColor = System.Drawing.Color.White;
            this.BtnEditSchedule.Location = new System.Drawing.Point(153, 78);
            this.BtnEditSchedule.Name = "BtnEditSchedule";
            this.BtnEditSchedule.Size = new System.Drawing.Size(75, 23);
            this.BtnEditSchedule.TabIndex = 9;
            this.BtnEditSchedule.Text = "Editar";
            this.BtnEditSchedule.UseVisualStyleBackColor = false;
            this.BtnEditSchedule.Click += new System.EventHandler(this.BtnEditSchedule_Click);
            // 
            // BtnDeleteSchedule
            // 
            this.BtnDeleteSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteSchedule.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteSchedule.Location = new System.Drawing.Point(246, 78);
            this.BtnDeleteSchedule.Name = "BtnDeleteSchedule";
            this.BtnDeleteSchedule.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteSchedule.TabIndex = 8;
            this.BtnDeleteSchedule.Text = "Eliminar";
            this.BtnDeleteSchedule.UseVisualStyleBackColor = false;
            this.BtnDeleteSchedule.Click += new System.EventHandler(this.BtnDeleteSchedule_Click);
            // 
            // BtnCreateSchedule
            // 
            this.BtnCreateSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCreateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateSchedule.ForeColor = System.Drawing.Color.White;
            this.BtnCreateSchedule.Location = new System.Drawing.Point(12, 15);
            this.BtnCreateSchedule.Name = "BtnCreateSchedule";
            this.BtnCreateSchedule.Size = new System.Drawing.Size(75, 23);
            this.BtnCreateSchedule.TabIndex = 7;
            this.BtnCreateSchedule.Text = "Añadir";
            this.BtnCreateSchedule.UseVisualStyleBackColor = false;
            this.BtnCreateSchedule.Click += new System.EventHandler(this.BtnCreateSchedule_Click);
            // 
            // ListViewSchedules
            // 
            this.ListViewSchedules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListViewSchedules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.scheduleId,
            this.scheduleStartAt,
            this.scheduleEndAt,
            this.scheduleOfficial});
            this.ListViewSchedules.HideSelection = false;
            this.ListViewSchedules.Location = new System.Drawing.Point(0, 107);
            this.ListViewSchedules.Name = "ListViewSchedules";
            this.ListViewSchedules.Size = new System.Drawing.Size(800, 329);
            this.ListViewSchedules.TabIndex = 6;
            this.ListViewSchedules.UseCompatibleStateImageBehavior = false;
            this.ListViewSchedules.View = System.Windows.Forms.View.Details;
            // 
            // scheduleId
            // 
            this.scheduleId.Text = "ID";
            this.scheduleId.Width = 201;
            // 
            // scheduleStartAt
            // 
            this.scheduleStartAt.Text = "Inicio";
            this.scheduleStartAt.Width = 181;
            // 
            // scheduleEndAt
            // 
            this.scheduleEndAt.Text = "Fin";
            this.scheduleEndAt.Width = 137;
            // 
            // scheduleOfficial
            // 
            this.scheduleOfficial.Text = "Funcionario";
            this.scheduleOfficial.Width = 119;
            // 
            // SchedulesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxScheduleId);
            this.Controls.Add(this.BtnEditSchedule);
            this.Controls.Add(this.BtnDeleteSchedule);
            this.Controls.Add(this.BtnCreateSchedule);
            this.Controls.Add(this.ListViewSchedules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SchedulesFrm";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.SchedulesFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxScheduleId;
        private System.Windows.Forms.Button BtnEditSchedule;
        private System.Windows.Forms.Button BtnDeleteSchedule;
        private System.Windows.Forms.Button BtnCreateSchedule;
        private System.Windows.Forms.ListView ListViewSchedules;
        private System.Windows.Forms.ColumnHeader scheduleId;
        private System.Windows.Forms.ColumnHeader scheduleStartAt;
        private System.Windows.Forms.ColumnHeader scheduleEndAt;
        private System.Windows.Forms.ColumnHeader scheduleOfficial;
    }
}