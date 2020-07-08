namespace CitasEps.Views.Log
{
    partial class Logs
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
			this.LogsListView = new System.Windows.Forms.ListView();
			this.dateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.official = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// LogsListView
			// 
			this.LogsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.LogsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LogsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateTime,
            this.description,
            this.official});
			this.LogsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LogsListView.HideSelection = false;
			this.LogsListView.Location = new System.Drawing.Point(0, 0);
			this.LogsListView.Name = "LogsListView";
			this.LogsListView.Size = new System.Drawing.Size(800, 450);
			this.LogsListView.TabIndex = 0;
			this.LogsListView.UseCompatibleStateImageBehavior = false;
			this.LogsListView.View = System.Windows.Forms.View.Details;
			this.LogsListView.SelectedIndexChanged += new System.EventHandler(this.LogsListView_SelectedIndexChanged);
			// 
			// dateTime
			// 
			this.dateTime.Text = "Fecha";
			this.dateTime.Width = 204;
			// 
			// description
			// 
			this.description.Text = "Descripción";
			this.description.Width = 330;
			// 
			// official
			// 
			this.official.Text = "Funcionario";
			this.official.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.official.Width = 260;
			// 
			// Logs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LogsListView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Logs";
			this.Text = "Logs";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LogsListView;
        private System.Windows.Forms.ColumnHeader dateTime;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader official;
    }
}