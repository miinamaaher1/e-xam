namespace UI.InstructorForms
{
    partial class CourseDetailsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseDetailsReportForm));
            CourseTopicsRV = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // CourseTopicsRV
            // 
            CourseTopicsRV.Dock = DockStyle.Fill;
            CourseTopicsRV.Location = new Point(0, 0);
            CourseTopicsRV.Name = "ReportViewer";
            CourseTopicsRV.ServerReport.BearerToken = null;
            CourseTopicsRV.Size = new Size(1232, 808);
            CourseTopicsRV.TabIndex = 0;
            // 
            // CourseTopicsReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(CourseTopicsRV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CourseTopicsReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Course Details";
            Load += CourseTopicsReportForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer CourseTopicsRV;
    }
}