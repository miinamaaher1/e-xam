namespace UI
{
    partial class StudentStatsSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentStatsSelectForm));
            studentIdLbl = new Label();
            studentIdBx = new TextBox();
            viewBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // studentIdLbl
            // 
            studentIdLbl.Anchor = AnchorStyles.None;
            studentIdLbl.AutoSize = true;
            studentIdLbl.Font = new Font("Segoe UI", 13.8F);
            studentIdLbl.Location = new Point(385, 335);
            studentIdLbl.Name = "studentIdLbl";
            studentIdLbl.Size = new Size(126, 31);
            studentIdLbl.TabIndex = 0;
            studentIdLbl.Text = "Student ID:";
            // 
            // studentIdBx
            // 
            studentIdBx.Anchor = AnchorStyles.None;
            studentIdBx.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentIdBx.Location = new Point(551, 332);
            studentIdBx.Name = "studentIdBx";
            studentIdBx.Size = new Size(297, 38);
            studentIdBx.TabIndex = 1;
            // 
            // viewBtn
            // 
            viewBtn.Anchor = AnchorStyles.None;
            viewBtn.Font = new Font("Segoe UI", 13.8F);
            viewBtn.ForeColor = Color.DarkViolet;
            viewBtn.Location = new Point(559, 431);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(115, 45);
            viewBtn.TabIndex = 2;
            viewBtn.Text = "View";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(342, 55);
            label1.TabIndex = 3;
            label1.Text = "Select A student";
            // 
            // StudentStatsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(label1);
            Controls.Add(viewBtn);
            Controls.Add(studentIdBx);
            Controls.Add(studentIdLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StudentStatsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Student Stats";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentIdLbl;
        private TextBox studentIdBx;
        private Button viewBtn;
        private Label label1;
    }
}