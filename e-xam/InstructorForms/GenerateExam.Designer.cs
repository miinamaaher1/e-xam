namespace e_xam.InstructorForms
{
    partial class GenerateExam
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
            endDateDtPicker = new DateTimePicker();
            startDateDtPicker = new DateTimePicker();
            mcqNumUpDown = new NumericUpDown();
            tfNumUpDown = new NumericUpDown();
            durationNumUpDown = new NumericUpDown();
            tilteTxtBox = new TextBox();
            courseLbl = new Label();
            trackLbl = new Label();
            McqLbl = new Label();
            tfLbl = new Label();
            durationLbl = new Label();
            titleLbl = new Label();
            startDateLbl = new Label();
            endDateLbl = new Label();
            minutesLbl = new Label();
            generateExBtn = new Button();
            trackscheckedList = new CheckedListBox();
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
            courseCombo.Location = new Point(339, 32);
            courseCombo.Name = "courseCombo";
            courseCombo.Size = new Size(151, 28);
            courseCombo.TabIndex = 0;
            courseCombo.SelectedIndexChanged += courseCombo_SelectedIndexChanged;
            // 
            // endDateDtPicker
            // 
            endDateDtPicker.Format = DateTimePickerFormat.Short;
            endDateDtPicker.Location = new Point(278, 332);
            endDateDtPicker.Name = "endDateDtPicker";
            endDateDtPicker.Size = new Size(250, 27);
            endDateDtPicker.TabIndex = 2;
            // 
            // startDateDtPicker
            // 
            startDateDtPicker.Format = DateTimePickerFormat.Short;
            startDateDtPicker.Location = new Point(278, 282);
            startDateDtPicker.Name = "startDateDtPicker";
            startDateDtPicker.Size = new Size(250, 27);
            startDateDtPicker.TabIndex = 3;
            startDateDtPicker.Value = new DateTime(2025, 1, 20, 20, 2, 6, 0);
            // 
            // mcqNumUpDown
            // 
            mcqNumUpDown.Location = new Point(340, 89);
            mcqNumUpDown.Name = "mcqNumUpDown";
            mcqNumUpDown.Size = new Size(150, 27);
            mcqNumUpDown.TabIndex = 4;
            // 
            // tfNumUpDown
            // 
            tfNumUpDown.Location = new Point(339, 137);
            tfNumUpDown.Name = "tfNumUpDown";
            tfNumUpDown.Size = new Size(150, 27);
            tfNumUpDown.TabIndex = 5;
            // 
            // durationNumUpDown
            // 
            durationNumUpDown.Location = new Point(339, 190);
            durationNumUpDown.Name = "durationNumUpDown";
            durationNumUpDown.Size = new Size(150, 27);
            durationNumUpDown.TabIndex = 6;
            // 
            // tilteTxtBox
            // 
            tilteTxtBox.Location = new Point(340, 237);
            tilteTxtBox.Name = "tilteTxtBox";
            tilteTxtBox.Size = new Size(150, 27);
            tilteTxtBox.TabIndex = 7;
            // 
            // courseLbl
            // 
            courseLbl.AutoSize = true;
            courseLbl.Location = new Point(189, 32);
            courseLbl.Name = "courseLbl";
            courseLbl.Size = new Size(54, 20);
            courseLbl.TabIndex = 13;
            courseLbl.Text = "Course";
            // 
            // trackLbl
            // 
            trackLbl.AutoSize = true;
            trackLbl.Location = new Point(553, 35);
            trackLbl.Name = "trackLbl";
            trackLbl.Size = new Size(43, 20);
            trackLbl.TabIndex = 14;
            trackLbl.Text = "Track";
            // 
            // McqLbl
            // 
            McqLbl.AutoSize = true;
            McqLbl.Location = new Point(189, 96);
            McqLbl.Name = "McqLbl";
            McqLbl.Size = new Size(111, 20);
            McqLbl.TabIndex = 15;
            McqLbl.Text = "MCQ Questions";
            // 
            // tfLbl
            // 
            tfLbl.AutoSize = true;
            tfLbl.Location = new Point(189, 144);
            tfLbl.Name = "tfLbl";
            tfLbl.Size = new Size(144, 20);
            tfLbl.TabIndex = 16;
            tfLbl.Text = "True/False Questions";
            // 
            // durationLbl
            // 
            durationLbl.AutoSize = true;
            durationLbl.Location = new Point(189, 197);
            durationLbl.Name = "durationLbl";
            durationLbl.Size = new Size(67, 20);
            durationLbl.TabIndex = 17;
            durationLbl.Text = "Duration";
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Location = new Point(189, 240);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(75, 20);
            titleLbl.TabIndex = 18;
            titleLbl.Text = "Exam title";
            // 
            // startDateLbl
            // 
            startDateLbl.AutoSize = true;
            startDateLbl.Location = new Point(193, 287);
            startDateLbl.Name = "startDateLbl";
            startDateLbl.Size = new Size(74, 20);
            startDateLbl.TabIndex = 19;
            startDateLbl.Text = "Start date";
            // 
            // endDateLbl
            // 
            endDateLbl.AutoSize = true;
            endDateLbl.Location = new Point(193, 339);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(68, 20);
            endDateLbl.TabIndex = 20;
            endDateLbl.Text = "End date";
            // 
            // minutesLbl
            // 
            minutesLbl.AutoSize = true;
            minutesLbl.Location = new Point(495, 197);
            minutesLbl.Name = "minutesLbl";
            minutesLbl.Size = new Size(61, 20);
            minutesLbl.TabIndex = 21;
            minutesLbl.Text = "minutes";
            // 
            // generateExBtn
            // 
            generateExBtn.Location = new Point(304, 376);
            generateExBtn.Name = "generateExBtn";
            generateExBtn.Size = new Size(164, 29);
            generateExBtn.TabIndex = 22;
            generateExBtn.Text = "generate Exam ";
            generateExBtn.UseVisualStyleBackColor = true;
            generateExBtn.Click += generateExBtn_Click;
            // 
            // trackscheckedList
            // 
            trackscheckedList.FormattingEnabled = true;
            trackscheckedList.Location = new Point(612, 32);
            trackscheckedList.Name = "trackscheckedList";
            trackscheckedList.Size = new Size(150, 202);
            trackscheckedList.TabIndex = 23;
            // 
            // MsgLbl
            // 
            MsgLbl.AutoSize = true;
            MsgLbl.Location = new Point(357, 421);
            MsgLbl.Name = "MsgLbl";
            MsgLbl.Size = new Size(50, 20);
            MsgLbl.TabIndex = 24;
            MsgLbl.Text = "label1";
            MsgLbl.Visible = false;
            // 
            // GenerateExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(MsgLbl);
            Controls.Add(trackscheckedList);
            Controls.Add(generateExBtn);
            Controls.Add(minutesLbl);
            Controls.Add(endDateLbl);
            Controls.Add(startDateLbl);
            Controls.Add(titleLbl);
            Controls.Add(durationLbl);
            Controls.Add(tfLbl);
            Controls.Add(McqLbl);
            Controls.Add(trackLbl);
            Controls.Add(courseLbl);
            Controls.Add(tilteTxtBox);
            Controls.Add(durationNumUpDown);
            Controls.Add(tfNumUpDown);
            Controls.Add(mcqNumUpDown);
            Controls.Add(startDateDtPicker);
            Controls.Add(endDateDtPicker);
            Controls.Add(courseCombo);
            Name = "GenerateExam";
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
        private DateTimePicker endDateDtPicker;
        private DateTimePicker startDateDtPicker;
        private NumericUpDown mcqNumUpDown;
        private NumericUpDown tfNumUpDown;
        private NumericUpDown durationNumUpDown;
        private TextBox tilteTxtBox;
        private Label courseLbl;
        private Label trackLbl;
        private Label McqLbl;
        private Label tfLbl;
        private Label durationLbl;
        private Label titleLbl;
        private Label startDateLbl;
        private Label endDateLbl;
        private Label minutesLbl;
        private Button generateExBtn;
        private CheckedListBox trackscheckedList;
        private Label MsgLbl;
    }
}