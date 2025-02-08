namespace UI
{
    partial class TrackStatsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackStatsReportForm));
            TrackStatsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // TrackStatsReportViewer
            // 
            TrackStatsReportViewer.Dock = DockStyle.Fill;
            TrackStatsReportViewer.Location = new Point(0, 0);
            TrackStatsReportViewer.Name = "ReportViewer";
            TrackStatsReportViewer.ServerReport.BearerToken = null;
            TrackStatsReportViewer.Size = new Size(1232, 808);
            TrackStatsReportViewer.TabIndex = 0;
            // 
            // TrackStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(TrackStatsReportViewer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TrackStatsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Track Stats";
            Load += TrackStatsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer TrackStatsReportViewer;
    }
}