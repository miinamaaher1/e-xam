namespace UI
{
    partial class InstructorClassesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorClassesReportForm));
            instructorClassesRV = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // instructorClassesRV
            // 
            instructorClassesRV.Dock = DockStyle.Fill;
            instructorClassesRV.Location = new Point(0, 0);
            instructorClassesRV.Name = "ReportViewer";
            instructorClassesRV.ServerReport.BearerToken = null;
            instructorClassesRV.Size = new Size(1232, 808);
            instructorClassesRV.TabIndex = 0;
            // 
            // InstructorClassesReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(instructorClassesRV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "InstructorClassesReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - My Classes";
            Load += InstructorClassesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer instructorClassesRV;
    }
}