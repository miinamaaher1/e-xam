namespace UI
{
    partial class ReviewAnswersSelectExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewAnswersSelectExamForm));
            ExamLbl = new Label();
            examBx = new ComboBox();
            reviewBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ExamLbl
            // 
            ExamLbl.Anchor = AnchorStyles.None;
            ExamLbl.AutoSize = true;
            ExamLbl.Font = new Font("Segoe UI", 13.8F);
            ExamLbl.Location = new Point(375, 340);
            ExamLbl.Name = "ExamLbl";
            ExamLbl.Size = new Size(141, 31);
            ExamLbl.TabIndex = 0;
            ExamLbl.Text = "Select Exam:";
            // 
            // examBx
            // 
            examBx.Anchor = AnchorStyles.None;
            examBx.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            examBx.FormattingEnabled = true;
            examBx.Location = new Point(560, 337);
            examBx.Name = "examBx";
            examBx.Size = new Size(297, 39);
            examBx.TabIndex = 1;
            // 
            // reviewBtn
            // 
            reviewBtn.Anchor = AnchorStyles.None;
            reviewBtn.Font = new Font("Segoe UI", 13.8F);
            reviewBtn.ForeColor = Color.DarkViolet;
            reviewBtn.Location = new Point(514, 427);
            reviewBtn.Name = "reviewBtn";
            reviewBtn.Size = new Size(205, 45);
            reviewBtn.TabIndex = 2;
            reviewBtn.Text = "Review Answers";
            reviewBtn.UseVisualStyleBackColor = true;
            reviewBtn.Click += reviewBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 55);
            label1.TabIndex = 3;
            label1.Text = "Select An Exam";
            // 
            // SelectStudentExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(label1);
            Controls.Add(reviewBtn);
            Controls.Add(examBx);
            Controls.Add(ExamLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectStudentExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Review Answer";
            Load += SelectStudentExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExamLbl;
        private ComboBox examBx;
        private Button reviewBtn;
        private Label label1;
    }
}