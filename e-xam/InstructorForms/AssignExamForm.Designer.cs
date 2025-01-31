namespace e_xam.InstructorForms
{
    partial class AssignExamForm
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
            saveExamTracksBtn = new Button();
            tracksCheckedListB = new CheckedListBox();
            startDatetimeP = new DateTimePicker();
            enddateTimeP = new DateTimePicker();
            startDateLbl = new Label();
            endDateLbl = new Label();
            tracksLbl = new Label();
            doneButton = new Button();
            SuspendLayout();
            // 
            // saveExamTracksBtn
            // 
            saveExamTracksBtn.Location = new Point(259, 336);
            saveExamTracksBtn.Name = "saveExamTracksBtn";
            saveExamTracksBtn.Size = new Size(94, 29);
            saveExamTracksBtn.TabIndex = 1;
            saveExamTracksBtn.Text = "Save";
            saveExamTracksBtn.UseVisualStyleBackColor = true;
            saveExamTracksBtn.Click += saveExamTracksBtn_Click;
            // 
            // tracksCheckedListB
            // 
            tracksCheckedListB.AllowDrop = true;
            tracksCheckedListB.FormattingEnabled = true;
            tracksCheckedListB.Location = new Point(315, 139);
            tracksCheckedListB.Name = "tracksCheckedListB";
            tracksCheckedListB.Size = new Size(145, 136);
            tracksCheckedListB.TabIndex = 2;
            // 
            // startDatetimeP
            // 
            startDatetimeP.Location = new Point(315, 44);
            startDatetimeP.Name = "startDatetimeP";
            startDatetimeP.Size = new Size(250, 27);
            startDatetimeP.TabIndex = 3;
            // 
            // enddateTimeP
            // 
            enddateTimeP.Location = new Point(315, 92);
            enddateTimeP.Name = "enddateTimeP";
            enddateTimeP.Size = new Size(250, 27);
            enddateTimeP.TabIndex = 4;
            // 
            // startDateLbl
            // 
            startDateLbl.AutoSize = true;
            startDateLbl.Location = new Point(194, 44);
            startDateLbl.Name = "startDateLbl";
            startDateLbl.Size = new Size(72, 20);
            startDateLbl.TabIndex = 5;
            startDateLbl.Text = "start date";
            // 
            // endDateLbl
            // 
            endDateLbl.AutoSize = true;
            endDateLbl.Location = new Point(194, 92);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(68, 20);
            endDateLbl.TabIndex = 6;
            endDateLbl.Text = "end date";
            // 
            // tracksLbl
            // 
            tracksLbl.AutoSize = true;
            tracksLbl.Location = new Point(194, 139);
            tracksLbl.Name = "tracksLbl";
            tracksLbl.Size = new Size(85, 20);
            tracksLbl.TabIndex = 7;
            tracksLbl.Text = "select Track";
            // 
            // doneButton
            // 
            doneButton.Location = new Point(403, 336);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(94, 29);
            doneButton.TabIndex = 8;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // AssignExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(doneButton);
            Controls.Add(tracksLbl);
            Controls.Add(endDateLbl);
            Controls.Add(startDateLbl);
            Controls.Add(enddateTimeP);
            Controls.Add(startDatetimeP);
            Controls.Add(tracksCheckedListB);
            Controls.Add(saveExamTracksBtn);
            Name = "AssignExamForm";
            Text = "AssignExamForm";
            Load += AssignExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveExamTracksBtn;
        private CheckedListBox tracksCheckedListB;
        private DateTimePicker startDatetimeP;
        private DateTimePicker enddateTimeP;
        private Label startDateLbl;
        private Label endDateLbl;
        private Label tracksLbl;
        private Button doneButton;
    }
}