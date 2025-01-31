namespace e_xam.InstructorForms
{
    partial class ViewCourseTopicsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCourseTopicsForm));
            CourseLbl = new Label();
            courseCombo = new ComboBox();
            viewTopicsBtn = new Button();
            msgLbl = new Label();
            SuspendLayout();
            // 
            // CourseLbl
            // 
            CourseLbl.Anchor = AnchorStyles.None;
            CourseLbl.AutoSize = true;
            CourseLbl.Location = new Point(478, 345);
            CourseLbl.Name = "CourseLbl";
            CourseLbl.Size = new Size(54, 20);
            CourseLbl.TabIndex = 0;
            CourseLbl.Text = "Course";
            // 
            // courseCombo
            // 
            courseCombo.Anchor = AnchorStyles.None;
            courseCombo.FormattingEnabled = true;
            courseCombo.Location = new Point(604, 337);
            courseCombo.Name = "courseCombo";
            courseCombo.Size = new Size(151, 28);
            courseCombo.TabIndex = 1;
            // 
            // viewTopicsBtn
            // 
            viewTopicsBtn.Anchor = AnchorStyles.None;
            viewTopicsBtn.Location = new Point(532, 407);
            viewTopicsBtn.Name = "viewTopicsBtn";
            viewTopicsBtn.Size = new Size(169, 29);
            viewTopicsBtn.TabIndex = 2;
            viewTopicsBtn.Text = "View Topics";
            viewTopicsBtn.UseVisualStyleBackColor = true;
            viewTopicsBtn.Click += viewTopicsBtn_Click;
            // 
            // msgLbl
            // 
            msgLbl.Anchor = AnchorStyles.Bottom;
            msgLbl.AutoSize = true;
            msgLbl.Location = new Point(550, 779);
            msgLbl.Name = "msgLbl";
            msgLbl.Size = new Size(132, 20);
            msgLbl.TabIndex = 3;
            msgLbl.Text = "Must select Course";
            // 
            // ViewCourseTopicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(msgLbl);
            Controls.Add(viewTopicsBtn);
            Controls.Add(courseCombo);
            Controls.Add(CourseLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewCourseTopicsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Course Details";
            Load += ViewCourseTopicsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CourseLbl;
        private ComboBox courseCombo;
        private Button viewTopicsBtn;
        private Label msgLbl;
    }
}