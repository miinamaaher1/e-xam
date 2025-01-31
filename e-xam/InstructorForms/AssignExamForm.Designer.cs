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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignExamForm));
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
            saveExamTracksBtn.Anchor = AnchorStyles.None;
            saveExamTracksBtn.Location = new Point(432, 608);
            saveExamTracksBtn.Margin = new Padding(5);
            saveExamTracksBtn.Name = "saveExamTracksBtn";
            saveExamTracksBtn.Size = new Size(135, 42);
            saveExamTracksBtn.TabIndex = 1;
            saveExamTracksBtn.Text = "Save";
            saveExamTracksBtn.UseVisualStyleBackColor = true;
            saveExamTracksBtn.Click += saveExamTracksBtn_Click;
            // 
            // tracksCheckedListB
            // 
            tracksCheckedListB.AllowDrop = true;
            tracksCheckedListB.Anchor = AnchorStyles.None;
            tracksCheckedListB.FormattingEnabled = true;
            tracksCheckedListB.Location = new Point(513, 311);
            tracksCheckedListB.Margin = new Padding(5);
            tracksCheckedListB.Name = "tracksCheckedListB";
            tracksCheckedListB.Size = new Size(404, 169);
            tracksCheckedListB.TabIndex = 2;
            // 
            // startDatetimeP
            // 
            startDatetimeP.Anchor = AnchorStyles.None;
            startDatetimeP.Location = new Point(513, 159);
            startDatetimeP.Margin = new Padding(5);
            startDatetimeP.Name = "startDatetimeP";
            startDatetimeP.Size = new Size(404, 38);
            startDatetimeP.TabIndex = 3;
            // 
            // enddateTimeP
            // 
            enddateTimeP.Anchor = AnchorStyles.None;
            enddateTimeP.Location = new Point(513, 232);
            enddateTimeP.Margin = new Padding(5);
            enddateTimeP.Name = "enddateTimeP";
            enddateTimeP.Size = new Size(404, 38);
            enddateTimeP.TabIndex = 4;
            // 
            // startDateLbl
            // 
            startDateLbl.Anchor = AnchorStyles.None;
            startDateLbl.AutoSize = true;
            startDateLbl.Location = new Point(316, 165);
            startDateLbl.Margin = new Padding(5, 0, 5, 0);
            startDateLbl.Name = "startDateLbl";
            startDateLbl.Size = new Size(115, 31);
            startDateLbl.TabIndex = 5;
            startDateLbl.Text = "Start Date";
            // 
            // endDateLbl
            // 
            endDateLbl.Anchor = AnchorStyles.None;
            endDateLbl.AutoSize = true;
            endDateLbl.Location = new Point(316, 238);
            endDateLbl.Margin = new Padding(5, 0, 5, 0);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(107, 31);
            endDateLbl.TabIndex = 6;
            endDateLbl.Text = "End Date";
            // 
            // tracksLbl
            // 
            tracksLbl.Anchor = AnchorStyles.None;
            tracksLbl.AutoSize = true;
            tracksLbl.Location = new Point(316, 311);
            tracksLbl.Margin = new Padding(5, 0, 5, 0);
            tracksLbl.Name = "tracksLbl";
            tracksLbl.Size = new Size(133, 31);
            tracksLbl.TabIndex = 7;
            tracksLbl.Text = "Select Track";
            // 
            // doneButton
            // 
            doneButton.Anchor = AnchorStyles.None;
            doneButton.Location = new Point(666, 608);
            doneButton.Margin = new Padding(5);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(135, 42);
            doneButton.TabIndex = 8;
            doneButton.Text = "Done";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // AssignExamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(doneButton);
            Controls.Add(tracksLbl);
            Controls.Add(endDateLbl);
            Controls.Add(startDateLbl);
            Controls.Add(enddateTimeP);
            Controls.Add(startDatetimeP);
            Controls.Add(tracksCheckedListB);
            Controls.Add(saveExamTracksBtn);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "AssignExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Generate Exam";
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