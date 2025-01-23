namespace e_xam.InstructorForms
{
    partial class GenerateExamForm
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
            courseCombo = new ComboBox();
            mcqNumUpDown = new NumericUpDown();
            tfNumUpDown = new NumericUpDown();
            durationNumUpDown = new NumericUpDown();
            tilteTxtBox = new TextBox();
            courseLbl = new Label();
            McqLbl = new Label();
            tfLbl = new Label();
            durationLbl = new Label();
            titleLbl = new Label();
            minutesLbl = new Label();
            generateExBtn = new Button();
            MsgLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)mcqNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tfNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)durationNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // courseCombo
            // 
            courseCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            courseCombo.FormattingEnabled = true;
            courseCombo.Location = new Point(392, 73);
            courseCombo.Name = "courseCombo";
            courseCombo.Size = new Size(151, 28);
            courseCombo.TabIndex = 0;
            // 
            // mcqNumUpDown
            // 
            mcqNumUpDown.Location = new Point(393, 131);
            mcqNumUpDown.Name = "mcqNumUpDown";
            mcqNumUpDown.Size = new Size(150, 27);
            mcqNumUpDown.TabIndex = 4;
            // 
            // tfNumUpDown
            // 
            tfNumUpDown.Location = new Point(393, 187);
            tfNumUpDown.Name = "tfNumUpDown";
            tfNumUpDown.Size = new Size(150, 27);
            tfNumUpDown.TabIndex = 5;
            // 
            // durationNumUpDown
            // 
            durationNumUpDown.Location = new Point(392, 241);
            durationNumUpDown.Name = "durationNumUpDown";
            durationNumUpDown.Size = new Size(150, 27);
            durationNumUpDown.TabIndex = 6;
            // 
            // tilteTxtBox
            // 
            tilteTxtBox.Location = new Point(392, 287);
            tilteTxtBox.Name = "tilteTxtBox";
            tilteTxtBox.Size = new Size(150, 27);
            tilteTxtBox.TabIndex = 7;
            // 
            // courseLbl
            // 
            courseLbl.AutoSize = true;
            courseLbl.Location = new Point(227, 81);
            courseLbl.Name = "courseLbl";
            courseLbl.Size = new Size(54, 20);
            courseLbl.TabIndex = 13;
            courseLbl.Text = "Course";
            // 
            // McqLbl
            // 
            McqLbl.AutoSize = true;
            McqLbl.Location = new Point(227, 131);
            McqLbl.Name = "McqLbl";
            McqLbl.Size = new Size(111, 20);
            McqLbl.TabIndex = 15;
            McqLbl.Text = "MCQ Questions";
            // 
            // tfLbl
            // 
            tfLbl.AutoSize = true;
            tfLbl.Location = new Point(227, 194);
            tfLbl.Name = "tfLbl";
            tfLbl.Size = new Size(144, 20);
            tfLbl.TabIndex = 16;
            tfLbl.Text = "True/False Questions";
            // 
            // durationLbl
            // 
            durationLbl.AutoSize = true;
            durationLbl.Location = new Point(227, 241);
            durationLbl.Name = "durationLbl";
            durationLbl.Size = new Size(67, 20);
            durationLbl.TabIndex = 17;
            durationLbl.Text = "Duration";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Location = new Point(227, 290);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(75, 20);
            titleLbl.TabIndex = 18;
            titleLbl.Text = "Exam title";
            // 
            // minutesLbl
            // 
            minutesLbl.AutoSize = true;
            minutesLbl.Location = new Point(589, 243);
            minutesLbl.Name = "minutesLbl";
            minutesLbl.Size = new Size(61, 20);
            minutesLbl.TabIndex = 21;
            minutesLbl.Text = "minutes";
            // 
            // generateExBtn
            // 
            generateExBtn.Location = new Point(282, 343);
            generateExBtn.Name = "generateExBtn";
            generateExBtn.Size = new Size(164, 29);
            generateExBtn.TabIndex = 22;
            generateExBtn.Text = "generate Exam ";
            generateExBtn.UseVisualStyleBackColor = true;
            generateExBtn.Click += generateExBtn_Click;
            // 
            // MsgLbl
            // 
            MsgLbl.AutoSize = true;
            MsgLbl.Location = new Point(343, 396);
            MsgLbl.Name = "MsgLbl";
            MsgLbl.Size = new Size(50, 20);
            MsgLbl.TabIndex = 24;
            MsgLbl.Text = "label1";
            MsgLbl.Visible = false;
            // 
            // GenerateExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(MsgLbl);
            Controls.Add(generateExBtn);
            Controls.Add(minutesLbl);
            Controls.Add(titleLbl);
            Controls.Add(durationLbl);
            Controls.Add(tfLbl);
            Controls.Add(McqLbl);
            Controls.Add(courseLbl);
            Controls.Add(tilteTxtBox);
            Controls.Add(durationNumUpDown);
            Controls.Add(tfNumUpDown);
            Controls.Add(mcqNumUpDown);
            Controls.Add(courseCombo);
            Name = "GenerateExamForm";
            Text = "GenerateExam";
            Load += GenerateExam_Load;
            ((System.ComponentModel.ISupportInitialize)mcqNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)tfNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)durationNumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox courseCombo;
        private NumericUpDown mcqNumUpDown;
        private NumericUpDown tfNumUpDown;
        private NumericUpDown durationNumUpDown;
        private TextBox tilteTxtBox;
        private Label courseLbl;
        private Label McqLbl;
        private Label tfLbl;
        private Label durationLbl;
        private Label titleLbl;
        private Label minutesLbl;
        private Button generateExBtn;
        private Label MsgLbl;
    }
}