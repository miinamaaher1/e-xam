namespace e_xam.InstructorForms
{
    partial class DisplayExamReportForm
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
            displayExamRV = new Microsoft.Reporting.WinForms.ReportViewer();
            assignExamBtn = new Button();
            SuspendLayout();
            // 
            // displayExamRV
            // 
            displayExamRV.Dock = DockStyle.Top;
            displayExamRV.Location = new Point(0, 0);
            displayExamRV.Name = "ReportViewer";
            displayExamRV.ServerReport.BearerToken = null;
            displayExamRV.Size = new Size(1232, 758);
            displayExamRV.TabIndex = 0;
            // 
            // assignExamBtn
            // 
            assignExamBtn.Location = new Point(527, 767);
            assignExamBtn.Name = "assignExamBtn";
            assignExamBtn.Size = new Size(131, 29);
            assignExamBtn.TabIndex = 1;
            assignExamBtn.Text = "Assign Exam";
            assignExamBtn.UseVisualStyleBackColor = true;
            assignExamBtn.Click += assignExamBtn_Click;
            // 
            // DisplayExamReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(assignExamBtn);
            Controls.Add(displayExamRV);
            Name = "DisplayExamReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Display Exam";
            Load += DisplayExamReportForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer displayExamRV;
        private Button assignExamBtn;
    }
}