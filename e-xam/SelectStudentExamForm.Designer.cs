namespace e_xam
{
    partial class SelectStudentExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectStudentExamForm));
            ExamLbl = new Label();
            examBx = new ComboBox();
            reviewBtn = new Button();
            SuspendLayout();
            // 
            // ExamLbl
            // 
            ExamLbl.AutoSize = true;
            ExamLbl.Font = new Font("Segoe UI", 13.8F);
            ExamLbl.Location = new Point(85, 161);
            ExamLbl.Name = "ExamLbl";
            ExamLbl.Size = new Size(226, 31);
            ExamLbl.TabIndex = 0;
            ExamLbl.Text = "Select Student Exam:";
            // 
            // examBx
            // 
            examBx.FormattingEnabled = true;
            examBx.Location = new Point(345, 167);
            examBx.Name = "examBx";
            examBx.Size = new Size(256, 28);
            examBx.TabIndex = 1;
            // 
            // reviewBtn
            // 
            reviewBtn.Font = new Font("Segoe UI", 13.8F);
            reviewBtn.Location = new Point(245, 320);
            reviewBtn.Name = "reviewBtn";
            reviewBtn.Size = new Size(209, 40);
            reviewBtn.TabIndex = 2;
            reviewBtn.Text = "Review Answers";
            reviewBtn.UseVisualStyleBackColor = true;
            reviewBtn.Click += this.reviewBtn_Click;
            // 
            // SelectStudentExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reviewBtn);
            Controls.Add(examBx);
            Controls.Add(ExamLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectStudentExamForm";
            Text = "Answer Sheet";
            Load += SelectStudentExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExamLbl;
        private ComboBox examBx;
        private Button reviewBtn;
    }
}