namespace UI.InstructorForms
{
    partial class ViewExamSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExamSelectForm));
            courseLbl = new Label();
            ExamLbl = new Label();
            coursesCombo = new ComboBox();
            ExamsCombo = new ComboBox();
            getExamBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // courseLbl
            // 
            courseLbl.AutoSize = true;
            courseLbl.Font = new Font("Segoe UI", 13.8F);
            courseLbl.Location = new Point(409, 311);
            courseLbl.Name = "courseLbl";
            courseLbl.Size = new Size(95, 31);
            courseLbl.TabIndex = 0;
            courseLbl.Text = "Course :";
            // 
            // ExamLbl
            // 
            ExamLbl.AutoSize = true;
            ExamLbl.Font = new Font("Segoe UI", 13.8F);
            ExamLbl.Location = new Point(396, 381);
            ExamLbl.Name = "ExamLbl";
            ExamLbl.Size = new Size(108, 31);
            ExamLbl.TabIndex = 1;
            ExamLbl.Text = "Exam ID :";
            // 
            // coursesCombo
            // 
            coursesCombo.Font = new Font("Segoe UI", 13.8F);
            coursesCombo.FormattingEnabled = true;
            coursesCombo.Location = new Point(540, 308);
            coursesCombo.Name = "coursesCombo";
            coursesCombo.Size = new Size(297, 39);
            coursesCombo.TabIndex = 2;
            coursesCombo.SelectedIndexChanged += coursesCombo_SelectedIndexChanged;
            // 
            // ExamsCombo
            // 
            ExamsCombo.Font = new Font("Segoe UI", 13.8F);
            ExamsCombo.FormattingEnabled = true;
            ExamsCombo.Location = new Point(540, 373);
            ExamsCombo.Name = "ExamsCombo";
            ExamsCombo.Size = new Size(297, 39);
            ExamsCombo.TabIndex = 3;
            // 
            // getExamBtn
            // 
            getExamBtn.Font = new Font("Segoe UI", 13.8F);
            getExamBtn.ForeColor = Color.DarkViolet;
            getExamBtn.Location = new Point(559, 456);
            getExamBtn.Name = "getExamBtn";
            getExamBtn.Size = new Size(115, 45);
            getExamBtn.TabIndex = 4;
            getExamBtn.Text = "Get Exam";
            getExamBtn.UseVisualStyleBackColor = true;
            getExamBtn.Click += getExamBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 55);
            label1.TabIndex = 5;
            label1.Text = "Select Exam";
            // 
            // SelectExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(label1);
            Controls.Add(getExamBtn);
            Controls.Add(ExamsCombo);
            Controls.Add(coursesCombo);
            Controls.Add(ExamLbl);
            Controls.Add(courseLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - View Exam";
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
        private Label label1;
    }
}