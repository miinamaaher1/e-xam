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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateExamForm));
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
            label1 = new Label();
            mcqLblMsg = new Label();
            tfLblMsg = new Label();
            ((System.ComponentModel.ISupportInitialize)mcqNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tfNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)durationNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // courseCombo
            // 
            courseCombo.Anchor = AnchorStyles.None;
            courseCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            courseCombo.FormattingEnabled = true;
            courseCombo.Location = new Point(627, 177);
            courseCombo.Margin = new Padding(5);
            courseCombo.Name = "courseCombo";
            courseCombo.Size = new Size(244, 39);
            courseCombo.TabIndex = 0;
            courseCombo.SelectedIndexChanged += courseCombo_SelectedIndexChanged;
            // 
            // mcqNumUpDown
            // 
            mcqNumUpDown.Anchor = AnchorStyles.None;
            mcqNumUpDown.Location = new Point(627, 241);
            mcqNumUpDown.Margin = new Padding(5);
            mcqNumUpDown.Name = "mcqNumUpDown";
            mcqNumUpDown.Size = new Size(244, 38);
            mcqNumUpDown.TabIndex = 4;
            // 
            // tfNumUpDown
            // 
            tfNumUpDown.Anchor = AnchorStyles.None;
            tfNumUpDown.Location = new Point(627, 304);
            tfNumUpDown.Margin = new Padding(5);
            tfNumUpDown.Name = "tfNumUpDown";
            tfNumUpDown.Size = new Size(244, 38);
            tfNumUpDown.TabIndex = 5;
            // 
            // durationNumUpDown
            // 
            durationNumUpDown.Anchor = AnchorStyles.None;
            durationNumUpDown.Location = new Point(627, 367);
            durationNumUpDown.Margin = new Padding(5);
            durationNumUpDown.Name = "durationNumUpDown";
            durationNumUpDown.Size = new Size(244, 38);
            durationNumUpDown.TabIndex = 6;
            // 
            // tilteTxtBox
            // 
            tilteTxtBox.Anchor = AnchorStyles.None;
            tilteTxtBox.Location = new Point(627, 429);
            tilteTxtBox.Margin = new Padding(5);
            tilteTxtBox.Name = "tilteTxtBox";
            tilteTxtBox.Size = new Size(244, 38);
            tilteTxtBox.TabIndex = 7;
            // 
            // courseLbl
            // 
            courseLbl.Anchor = AnchorStyles.None;
            courseLbl.AutoSize = true;
            courseLbl.Location = new Point(362, 180);
            courseLbl.Margin = new Padding(5, 0, 5, 0);
            courseLbl.Name = "courseLbl";
            courseLbl.Size = new Size(84, 31);
            courseLbl.TabIndex = 13;
            courseLbl.Text = "Course";
            // 
            // McqLbl
            // 
            McqLbl.Anchor = AnchorStyles.None;
            McqLbl.AutoSize = true;
            McqLbl.Location = new Point(362, 243);
            McqLbl.Margin = new Padding(5, 0, 5, 0);
            McqLbl.Name = "McqLbl";
            McqLbl.Size = new Size(174, 31);
            McqLbl.TabIndex = 15;
            McqLbl.Text = "MCQ Questions";
            // 
            // tfLbl
            // 
            tfLbl.Anchor = AnchorStyles.None;
            tfLbl.AutoSize = true;
            tfLbl.Location = new Point(362, 306);
            tfLbl.Margin = new Padding(5, 0, 5, 0);
            tfLbl.Name = "tfLbl";
            tfLbl.Size = new Size(224, 31);
            tfLbl.TabIndex = 16;
            tfLbl.Text = "True/False Questions";
            // 
            // durationLbl
            // 
            durationLbl.Anchor = AnchorStyles.None;
            durationLbl.AutoSize = true;
            durationLbl.Location = new Point(362, 369);
            durationLbl.Margin = new Padding(5, 0, 5, 0);
            durationLbl.Name = "durationLbl";
            durationLbl.Size = new Size(103, 31);
            durationLbl.TabIndex = 17;
            durationLbl.Text = "Duration";
            // 
            // titleLbl
            // 
            titleLbl.Anchor = AnchorStyles.None;
            titleLbl.AutoSize = true;
            titleLbl.Location = new Point(362, 432);
            titleLbl.Margin = new Padding(5, 0, 5, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(119, 31);
            titleLbl.TabIndex = 18;
            titleLbl.Text = "Exam Title";
            // 
            // minutesLbl
            // 
            minutesLbl.Anchor = AnchorStyles.None;
            minutesLbl.AutoSize = true;
            minutesLbl.Location = new Point(881, 369);
            minutesLbl.Margin = new Padding(5, 0, 5, 0);
            minutesLbl.Name = "minutesLbl";
            minutesLbl.Size = new Size(53, 31);
            minutesLbl.TabIndex = 21;
            minutesLbl.Text = "min";
            // 
            // generateExBtn
            // 
            generateExBtn.Anchor = AnchorStyles.None;
            generateExBtn.Location = new Point(496, 586);
            generateExBtn.Margin = new Padding(5);
            generateExBtn.Name = "generateExBtn";
            generateExBtn.Size = new Size(240, 46);
            generateExBtn.TabIndex = 22;
            generateExBtn.Text = "Generate Exam ";
            generateExBtn.UseVisualStyleBackColor = true;
            generateExBtn.Click += generateExBtn_Click;
            // 
            // MsgLbl
            // 
            MsgLbl.Anchor = AnchorStyles.Bottom;
            MsgLbl.AutoSize = true;
            MsgLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MsgLbl.Location = new Point(591, 779);
            MsgLbl.Margin = new Padding(5, 0, 5, 0);
            MsgLbl.Name = "MsgLbl";
            MsgLbl.Size = new Size(50, 20);
            MsgLbl.TabIndex = 24;
            MsgLbl.Text = "label1";
            MsgLbl.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 25;
            label1.Text = "label1";
            // 
            // mcqLblMsg
            // 
            mcqLblMsg.Anchor = AnchorStyles.None;
            mcqLblMsg.AutoSize = true;
            mcqLblMsg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcqLblMsg.Location = new Point(881, 252);
            mcqLblMsg.Margin = new Padding(5, 0, 5, 0);
            mcqLblMsg.Name = "mcqLblMsg";
            mcqLblMsg.Size = new Size(198, 20);
            mcqLblMsg.TabIndex = 26;
            mcqLblMsg.Text = "There are no MCQ Questions";
            // 
            // tfLblMsg
            // 
            tfLblMsg.Anchor = AnchorStyles.None;
            tfLblMsg.AutoSize = true;
            tfLblMsg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tfLblMsg.Location = new Point(881, 315);
            tfLblMsg.Margin = new Padding(5, 0, 5, 0);
            tfLblMsg.Name = "tfLblMsg";
            tfLblMsg.Size = new Size(231, 20);
            tfLblMsg.TabIndex = 27;
            tfLblMsg.Text = "There are no True/False Questions";
            // 
            // GenerateExamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1232, 808);
            Controls.Add(tfLblMsg);
            Controls.Add(mcqLblMsg);
            Controls.Add(label1);
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
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "GenerateExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Generate Exam";
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
        private Label label1;
        private Label mcqLblMsg;
        private Label tfLblMsg;
    }
}