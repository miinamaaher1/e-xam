namespace UI.InstructorForms
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
            label1 = new Label();
            SuspendLayout();
            // 
            // saveExamTracksBtn
            // 
            saveExamTracksBtn.Anchor = AnchorStyles.None;
            saveExamTracksBtn.ForeColor = Color.DarkViolet;
            saveExamTracksBtn.Location = new Point(559, 674);
            saveExamTracksBtn.Margin = new Padding(5);
            saveExamTracksBtn.Name = "saveExamTracksBtn";
            saveExamTracksBtn.Size = new Size(115, 45);
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
            tracksCheckedListB.Location = new Point(501, 396);
            tracksCheckedListB.Margin = new Padding(5);
            tracksCheckedListB.Name = "tracksCheckedListB";
            tracksCheckedListB.Size = new Size(404, 169);
            tracksCheckedListB.TabIndex = 2;
            // 
            // startDatetimeP
            // 
            startDatetimeP.Anchor = AnchorStyles.None;
            startDatetimeP.Location = new Point(501, 244);
            startDatetimeP.Margin = new Padding(5);
            startDatetimeP.Name = "startDatetimeP";
            startDatetimeP.Size = new Size(404, 38);
            startDatetimeP.TabIndex = 3;
            // 
            // enddateTimeP
            // 
            enddateTimeP.Anchor = AnchorStyles.None;
            enddateTimeP.Location = new Point(501, 317);
            enddateTimeP.Margin = new Padding(5);
            enddateTimeP.Name = "enddateTimeP";
            enddateTimeP.Size = new Size(404, 38);
            enddateTimeP.TabIndex = 4;
            // 
            // startDateLbl
            // 
            startDateLbl.Anchor = AnchorStyles.None;
            startDateLbl.AutoSize = true;
            startDateLbl.Location = new Point(328, 250);
            startDateLbl.Margin = new Padding(5, 0, 5, 0);
            startDateLbl.Name = "startDateLbl";
            startDateLbl.Size = new Size(126, 31);
            startDateLbl.TabIndex = 5;
            startDateLbl.Text = "Start Date :";
            // 
            // endDateLbl
            // 
            endDateLbl.Anchor = AnchorStyles.None;
            endDateLbl.AutoSize = true;
            endDateLbl.Location = new Point(336, 323);
            endDateLbl.Margin = new Padding(5, 0, 5, 0);
            endDateLbl.Name = "endDateLbl";
            endDateLbl.Size = new Size(118, 31);
            endDateLbl.TabIndex = 6;
            endDateLbl.Text = "End Date :";
            // 
            // tracksLbl
            // 
            tracksLbl.Anchor = AnchorStyles.None;
            tracksLbl.AutoSize = true;
            tracksLbl.Location = new Point(377, 396);
            tracksLbl.Margin = new Padding(5, 0, 5, 0);
            tracksLbl.Name = "tracksLbl";
            tracksLbl.Size = new Size(77, 31);
            tracksLbl.TabIndex = 7;
            tracksLbl.Text = "Track :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(298, 55);
            label1.TabIndex = 9;
            label1.Text = "Select A Track";
            // 
            // AssignExamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(label1);
            Controls.Add(tracksLbl);
            Controls.Add(endDateLbl);
            Controls.Add(startDateLbl);
            Controls.Add(enddateTimeP);
            Controls.Add(startDatetimeP);
            Controls.Add(tracksCheckedListB);
            Controls.Add(saveExamTracksBtn);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
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
        private Label label1;
    }
}