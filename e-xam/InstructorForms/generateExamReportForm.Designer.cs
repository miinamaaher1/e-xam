namespace e_xam.InstructorForms
{
    partial class generateExamReportForm
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
            generateExamRV = new Microsoft.Reporting.WinForms.ReportViewer();
            assignExamBtn = new Button();
            generateAnotherQBtn = new Button();
            SuspendLayout();
            // 
            // generateExamRV
            // 
            generateExamRV.Location = new Point(0, 0);
            generateExamRV.Name = "ReportViewer";
            generateExamRV.ServerReport.BearerToken = null;
            generateExamRV.Size = new Size(800, 400);
            generateExamRV.TabIndex = 0;
            // 
            // assignExamBtn
            // 
            assignExamBtn.Location = new Point(420, 409);
            assignExamBtn.Name = "assignExamBtn";
            assignExamBtn.Size = new Size(199, 29);
            assignExamBtn.TabIndex = 1;
            assignExamBtn.Text = "Assign Exam to track";
            assignExamBtn.UseVisualStyleBackColor = true;
            assignExamBtn.Click += assignExamBtn_Click;
            // 
            // generateAnotherQBtn
            // 
            generateAnotherQBtn.Location = new Point(127, 409);
            generateAnotherQBtn.Name = "generateAnotherQBtn";
            generateAnotherQBtn.Size = new Size(232, 29);
            generateAnotherQBtn.TabIndex = 2;
            generateAnotherQBtn.Text = "Generate another Questions";
            generateAnotherQBtn.UseVisualStyleBackColor = true;
            generateAnotherQBtn.Click += generateAnotherQBtn_Click;
            // 
            // generateExamReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(generateAnotherQBtn);
            Controls.Add(assignExamBtn);
            Controls.Add(generateExamRV);
            Name = "generateExamReportForm";
            Text = "GenerateExamReportForm";
            Load += generateExamReportForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer generateExamRV;
        private Button assignExamBtn;
        private Button generateAnotherQBtn;
    }
}