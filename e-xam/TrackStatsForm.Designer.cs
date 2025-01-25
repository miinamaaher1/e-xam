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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackStatsForm));
            trackNameLbl = new Label();
            StudFLayPanel = new FlowLayoutPanel();
            okBtn = new Button();
            printBtn = new Button();
            SuspendLayout();
            // 
            // trackNameLbl
            // 
            trackNameLbl.AutoSize = true;
            trackNameLbl.Font = new Font("Segoe UI", 20F);
            trackNameLbl.Location = new Point(41, 32);
            trackNameLbl.Name = "trackNameLbl";
            trackNameLbl.Size = new Size(233, 46);
            trackNameLbl.TabIndex = 0;
            trackNameLbl.Text = "[ Track Name ]";
            // 
            // StudFLayPanel
            // 
            StudFLayPanel.AutoScroll = true;
            StudFLayPanel.Location = new Point(83, 119);
            StudFLayPanel.Name = "StudFLayPanel";
            StudFLayPanel.Size = new Size(654, 227);
            StudFLayPanel.TabIndex = 1;
            // 
            // okBtn
            // 
            okBtn.Font = new Font("Segoe UI", 12F);
            okBtn.Location = new Point(196, 387);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(131, 42);
            okBtn.TabIndex = 2;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // printBtn
            // 
            printBtn.Font = new Font("Segoe UI", 12F);
            printBtn.Location = new Point(496, 387);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(131, 42);
            printBtn.TabIndex = 3;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = true;
            // 
            // TrackStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(printBtn);
            Controls.Add(okBtn);
            Controls.Add(StudFLayPanel);
            Controls.Add(trackNameLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TrackStatsForm";
            Text = "Track Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label trackNameLbl;
        private FlowLayoutPanel StudFLayPanel;
        private Button okBtn;
        private Button printBtn;
    }
}