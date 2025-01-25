namespace e_xam
{
    partial class StudentStatsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentStatsReport));
            studentStatsRV = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // studentStatsRV
            // 
            studentStatsRV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentStatsRV.Location = new Point(0, 0);
            studentStatsRV.Name = "ReportViewer";
            studentStatsRV.ServerReport.BearerToken = null;
            studentStatsRV.Size = new Size(802, 451);
            studentStatsRV.TabIndex = 0;
            // 
            // StudentReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studentStatsRV);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StudentReport";
            Text = "Student Report";
            Load += StudentReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer studentStatsRV;
    }
}