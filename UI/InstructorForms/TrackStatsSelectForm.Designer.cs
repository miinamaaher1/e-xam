namespace UI
{
    partial class TrackStatsSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackStatsSelectForm));
            trackSelectLbl = new Label();
            tracksComboBox = new ComboBox();
            viewTrackBtn = new Button();
            studentIdLbl = new Label();
            SuspendLayout();
            // 
            // trackSelectLbl
            // 
            trackSelectLbl.Anchor = AnchorStyles.None;
            trackSelectLbl.AutoSize = true;
            trackSelectLbl.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trackSelectLbl.Location = new Point(12, 9);
            trackSelectLbl.Name = "trackSelectLbl";
            trackSelectLbl.Size = new Size(298, 55);
            trackSelectLbl.TabIndex = 0;
            trackSelectLbl.Text = "Select A Track";
            // 
            // tracksComboBox
            // 
            tracksComboBox.Anchor = AnchorStyles.None;
            tracksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tracksComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tracksComboBox.FormattingEnabled = true;
            tracksComboBox.Location = new Point(524, 338);
            tracksComboBox.Name = "tracksComboBox";
            tracksComboBox.Size = new Size(297, 39);
            tracksComboBox.Sorted = true;
            tracksComboBox.TabIndex = 1;
            // 
            // viewTrackBtn
            // 
            viewTrackBtn.Anchor = AnchorStyles.None;
            viewTrackBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewTrackBtn.ForeColor = Color.DarkViolet;
            viewTrackBtn.Location = new Point(559, 426);
            viewTrackBtn.Name = "viewTrackBtn";
            viewTrackBtn.Size = new Size(115, 45);
            viewTrackBtn.TabIndex = 2;
            viewTrackBtn.Text = "View";
            viewTrackBtn.UseVisualStyleBackColor = true;
            viewTrackBtn.Click += viewTrackBtn_Click;
            // 
            // studentIdLbl
            // 
            studentIdLbl.Anchor = AnchorStyles.None;
            studentIdLbl.AutoSize = true;
            studentIdLbl.Font = new Font("Segoe UI", 13.8F);
            studentIdLbl.Location = new Point(411, 341);
            studentIdLbl.Name = "studentIdLbl";
            studentIdLbl.Size = new Size(77, 31);
            studentIdLbl.TabIndex = 3;
            studentIdLbl.Text = "Track :";
            // 
            // TrackSelectionStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(studentIdLbl);
            Controls.Add(viewTrackBtn);
            Controls.Add(tracksComboBox);
            Controls.Add(trackSelectLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TrackSelectionStatsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Track Stats";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label trackSelectLbl;
        private ComboBox tracksComboBox;
        private Button viewTrackBtn;
        private Label studentIdLbl;
    }
}