namespace UI
{
    partial class StudentStatsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentStatsReportForm));
            studentStatsRV = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // studentStatsRV
            // 
            studentStatsRV.Dock = DockStyle.Fill;
            studentStatsRV.Location = new Point(0, 0);
            studentStatsRV.Name = "ReportViewer";
            studentStatsRV.ServerReport.BearerToken = null;
            studentStatsRV.Size = new Size(1232, 808);
            studentStatsRV.TabIndex = 0;
            // 
            // StudentStatsReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(studentStatsRV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StudentStatsReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Student Stats";
            Load += StudentReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer studentStatsRV;
    }
}