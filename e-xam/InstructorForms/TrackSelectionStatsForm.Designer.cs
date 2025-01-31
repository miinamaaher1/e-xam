namespace e_xam
{
    partial class TrackSelectionStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackSelectionStatsForm));
            trackSelectLbl = new Label();
            tracksComboBox = new ComboBox();
            viewTrackBtn = new Button();
            SuspendLayout();
            // 
            // trackSelectLbl
            // 
            trackSelectLbl.Anchor = AnchorStyles.None;
            trackSelectLbl.AutoSize = true;
            trackSelectLbl.Font = new Font("Segoe UI", 20F);
            trackSelectLbl.Location = new Point(347, 250);
            trackSelectLbl.Name = "trackSelectLbl";
            trackSelectLbl.Size = new Size(325, 46);
            trackSelectLbl.TabIndex = 0;
            trackSelectLbl.Text = "Please select a track:";
            // 
            // tracksComboBox
            // 
            tracksComboBox.Anchor = AnchorStyles.None;
            tracksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tracksComboBox.Font = new Font("Segoe UI", 20F);
            tracksComboBox.FormattingEnabled = true;
            tracksComboBox.Location = new Point(450, 385);
            tracksComboBox.Name = "tracksComboBox";
            tracksComboBox.Size = new Size(332, 53);
            tracksComboBox.Sorted = true;
            tracksComboBox.TabIndex = 1;
            // 
            // viewTrackBtn
            // 
            viewTrackBtn.Anchor = AnchorStyles.None;
            viewTrackBtn.Location = new Point(553, 510);
            viewTrackBtn.Name = "viewTrackBtn";
            viewTrackBtn.Size = new Size(127, 48);
            viewTrackBtn.TabIndex = 2;
            viewTrackBtn.Text = "View";
            viewTrackBtn.UseVisualStyleBackColor = true;
            viewTrackBtn.Click += viewTrackBtn_Click;
            // 
            // TrackSelectionStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(viewTrackBtn);
            Controls.Add(tracksComboBox);
            Controls.Add(trackSelectLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
    }
}