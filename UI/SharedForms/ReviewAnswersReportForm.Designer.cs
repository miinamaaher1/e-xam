namespace UI
{
    partial class ReviewAnswersReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewAnswersReportForm));
            reviewAnswersRV = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reviewAnswersRV
            // 
            reviewAnswersRV.Dock = DockStyle.Fill;
            reviewAnswersRV.Location = new Point(0, 0);
            reviewAnswersRV.Name = "ReportViewer";
            reviewAnswersRV.ServerReport.BearerToken = null;
            reviewAnswersRV.Size = new Size(1232, 808);
            reviewAnswersRV.TabIndex = 0;
            // 
            // ReviewAnswersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1232, 808);
            Controls.Add(reviewAnswersRV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ReviewAnswersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Review Answers";
            Load += ReviewAnswersForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reviewAnswersRV;
    }
}