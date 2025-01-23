namespace e_xam
{
    partial class StudentStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentStatsForm));
            studentIdLbl = new Label();
            studentIdBx = new TextBox();
            viewBtn = new Button();
            SuspendLayout();
            // 
            // studentIdLbl
            // 
            studentIdLbl.AutoSize = true;
            studentIdLbl.Font = new Font("Segoe UI", 13.8F);
            studentIdLbl.Location = new Point(109, 135);
            studentIdLbl.Name = "studentIdLbl";
            studentIdLbl.Size = new Size(185, 31);
            studentIdLbl.TabIndex = 0;
            studentIdLbl.Text = "Enter Student ID:";
            // 
            // studentIdBx
            // 
            studentIdBx.Location = new Point(327, 141);
            studentIdBx.Name = "studentIdBx";
            studentIdBx.Size = new Size(272, 27);
            studentIdBx.TabIndex = 1;
            // 
            // viewBtn
            // 
            viewBtn.Font = new Font("Segoe UI", 13.8F);
            viewBtn.Location = new Point(279, 278);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(138, 42);
            viewBtn.TabIndex = 2;
            viewBtn.Text = "View";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // StudentStats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewBtn);
            Controls.Add(studentIdBx);
            Controls.Add(studentIdLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentStats";
            Text = "Student Stats";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentIdLbl;
        private TextBox studentIdBx;
        private Button viewBtn;
    }
}