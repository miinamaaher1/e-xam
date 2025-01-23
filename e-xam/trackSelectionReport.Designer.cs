namespace e_xam
{
    partial class TrackStatsForm
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
            trackSelectLbl = new Label();
            tracksComboBox = new ComboBox();
            viewTrackBtn = new Button();
            SuspendLayout();
            // 
            // trackSelectLbl
            // 
            trackSelectLbl.AutoSize = true;
            trackSelectLbl.Font = new Font("Segoe UI", 20F);
            trackSelectLbl.Location = new Point(37, 52);
            trackSelectLbl.Name = "trackSelectLbl";
            trackSelectLbl.Size = new Size(325, 46);
            trackSelectLbl.TabIndex = 0;
            trackSelectLbl.Text = "Please select a track:";
            // 
            // tracksComboBox
            // 
            tracksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tracksComboBox.Font = new Font("Segoe UI", 20F);
            tracksComboBox.FormattingEnabled = true;
            tracksComboBox.Location = new Point(244, 187);
            tracksComboBox.Name = "tracksComboBox";
            tracksComboBox.Size = new Size(332, 53);
            tracksComboBox.Sorted = true;
            tracksComboBox.TabIndex = 1;
            // 
            // viewTrackBtn
            // 
            viewTrackBtn.Location = new Point(354, 312);
            viewTrackBtn.Name = "viewTrackBtn";
            viewTrackBtn.Size = new Size(127, 48);
            viewTrackBtn.TabIndex = 2;
            viewTrackBtn.Text = "View";
            viewTrackBtn.UseVisualStyleBackColor = true;
            viewTrackBtn.Click += viewTrackBtn_Click;
            // 
            // trackSelectionReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewTrackBtn);
            Controls.Add(tracksComboBox);
            Controls.Add(trackSelectLbl);
            Name = "trackSelectionReport";
            Text = "Track Selection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label trackSelectLbl;
        private ComboBox tracksComboBox;
        private Button viewTrackBtn;
    }
}