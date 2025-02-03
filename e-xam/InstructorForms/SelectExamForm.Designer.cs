namespace e_xam.InstructorForms
{
    partial class SelectExamForm
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
            courseLbl = new Label();
            ExamLbl = new Label();
            coursesCombo = new ComboBox();
            ExamsCombo = new ComboBox();
            getExamBtn = new Button();
            SuspendLayout();
            // 
            // courseLbl
            // 
            courseLbl.AutoSize = true;
            courseLbl.Location = new Point(454, 160);
            courseLbl.Name = "courseLbl";
            courseLbl.Size = new Size(54, 20);
            courseLbl.TabIndex = 0;
            courseLbl.Text = "Course";
            // 
            // ExamLbl
            // 
            ExamLbl.AutoSize = true;
            ExamLbl.Location = new Point(454, 230);
            ExamLbl.Name = "ExamLbl";
            ExamLbl.Size = new Size(64, 20);
            ExamLbl.TabIndex = 1;
            ExamLbl.Text = "Exam ID";
            // 
            // coursesCombo
            // 
            coursesCombo.FormattingEnabled = true;
            coursesCombo.Location = new Point(568, 157);
            coursesCombo.Name = "coursesCombo";
            coursesCombo.Size = new Size(151, 28);
            coursesCombo.TabIndex = 2;
            coursesCombo.SelectedIndexChanged += coursesCombo_SelectedIndexChanged;
            // 
            // ExamsCombo
            // 
            ExamsCombo.FormattingEnabled = true;
            ExamsCombo.Location = new Point(568, 227);
            ExamsCombo.Name = "ExamsCombo";
            ExamsCombo.Size = new Size(151, 28);
            ExamsCombo.TabIndex = 3;
            // 
            // getExamBtn
            // 
            getExamBtn.Location = new Point(509, 312);
            getExamBtn.Name = "getExamBtn";
            getExamBtn.Size = new Size(94, 29);
            getExamBtn.TabIndex = 4;
            getExamBtn.Text = "Get Exam";
            getExamBtn.UseVisualStyleBackColor = true;
            getExamBtn.Click += getExamBtn_Click;
            // 
            // SelectExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(getExamBtn);
            Controls.Add(ExamsCombo);
            Controls.Add(coursesCombo);
            Controls.Add(ExamLbl);
            Controls.Add(courseLbl);
            Name = "SelectExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Select Exam";
            Load += SelectExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label courseLbl;
        private Label ExamLbl;
        private ComboBox coursesCombo;
        private ComboBox ExamsCombo;
        private Button getExamBtn;
    }
}