namespace UI.InstructorForms
{
    partial class CourseDetailsSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseDetailsSelectForm));
            CourseLbl = new Label();
            courseCombo = new ComboBox();
            viewTopicsBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // CourseLbl
            // 
            CourseLbl.Anchor = AnchorStyles.None;
            CourseLbl.AutoSize = true;
            CourseLbl.Font = new Font("Segoe UI", 13.8F);
            CourseLbl.Location = new Point(396, 341);
            CourseLbl.Name = "CourseLbl";
            CourseLbl.Size = new Size(95, 31);
            CourseLbl.TabIndex = 0;
            CourseLbl.Text = "Course :";
            // 
            // courseCombo
            // 
            courseCombo.Anchor = AnchorStyles.None;
            courseCombo.Font = new Font("Segoe UI", 13.8F);
            courseCombo.FormattingEnabled = true;
            courseCombo.Location = new Point(539, 338);
            courseCombo.Name = "courseCombo";
            courseCombo.Size = new Size(297, 39);
            courseCombo.TabIndex = 1;
            // 
            // viewTopicsBtn
            // 
            viewTopicsBtn.Anchor = AnchorStyles.None;
            viewTopicsBtn.Font = new Font("Segoe UI", 13.8F);
            viewTopicsBtn.ForeColor = Color.DarkViolet;
            viewTopicsBtn.Location = new Point(535, 425);
            viewTopicsBtn.Name = "viewTopicsBtn";
            viewTopicsBtn.Size = new Size(163, 45);
            viewTopicsBtn.TabIndex = 2;
            viewTopicsBtn.Text = "View Topics";
            viewTopicsBtn.UseVisualStyleBackColor = true;
            viewTopicsBtn.Click += viewTopicsBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 55);
            label1.TabIndex = 0;
            label1.Text = "Select A Course";
            // 
            // ViewCourseTopicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(viewTopicsBtn);
            Controls.Add(courseCombo);
            Controls.Add(label1);
            Controls.Add(CourseLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
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
        private Label label1;
    }
}