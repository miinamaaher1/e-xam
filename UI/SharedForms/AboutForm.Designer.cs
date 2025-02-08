namespace UI.SharedForms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            pictureBox1 = new PictureBox();
            descriptionTitleLbl = new Label();
            teamTitleLbl = new Label();
            descriptionLbl = new Label();
            teamLbl = new Label();
            okBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.splash_screen;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 785);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // descriptionTitleLbl
            // 
            descriptionTitleLbl.AutoSize = true;
            descriptionTitleLbl.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionTitleLbl.Location = new Point(643, 152);
            descriptionTitleLbl.Name = "descriptionTitleLbl";
            descriptionTitleLbl.Size = new Size(145, 55);
            descriptionTitleLbl.TabIndex = 7;
            descriptionTitleLbl.Text = "e-xam";
            // 
            // teamTitleLbl
            // 
            teamTitleLbl.AutoSize = true;
            teamTitleLbl.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamTitleLbl.Location = new Point(643, 368);
            teamTitleLbl.Name = "teamTitleLbl";
            teamTitleLbl.Size = new Size(207, 55);
            teamTitleLbl.TabIndex = 7;
            teamTitleLbl.Text = "Our Team";
            // 
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Location = new Point(643, 216);
            descriptionLbl.Name = "descriptionLbl";
            descriptionLbl.Size = new Size(441, 124);
            descriptionLbl.TabIndex = 8;
            descriptionLbl.Text = "e-xam is a conceptual digital examination\r\nplatform designed and developed by our\r\nteam as part of our assessment for the\r\nAdvanced Database course at ITI.";
            // 
            // teamLbl
            // 
            teamLbl.AutoSize = true;
            teamLbl.Location = new Point(643, 432);
            teamLbl.Name = "teamLbl";
            teamLbl.Size = new Size(228, 155);
            teamLbl.TabIndex = 9;
            teamLbl.Text = "- Ahmed Yasser\r\n- Heba Abdul Wahab\r\n- Rahma Al Sayed\r\n- Shorouk Zaghloul\r\n- Mina Maher";
            // 
            // okBtn
            // 
            okBtn.ForeColor = Color.DarkViolet;
            okBtn.Location = new Point(969, 612);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(115, 45);
            okBtn.TabIndex = 10;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(okBtn);
            Controls.Add(teamLbl);
            Controls.Add(descriptionLbl);
            Controls.Add(teamTitleLbl);
            Controls.Add(descriptionTitleLbl);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label descriptionTitleLbl;
        private Label teamTitleLbl;
        private Label descriptionLbl;
        private Label teamLbl;
        private Button okBtn;
    }
}