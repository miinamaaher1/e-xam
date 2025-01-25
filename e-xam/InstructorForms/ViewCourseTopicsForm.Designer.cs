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
            CourseLbl = new Label();
            courseCombo = new ComboBox();
            viewTopicsBtn = new Button();
            msgLbl = new Label();
            SuspendLayout();
            // 
            // CourseLbl
            // 
            CourseLbl.AutoSize = true;
            CourseLbl.Location = new Point(251, 161);
            CourseLbl.Name = "CourseLbl";
            CourseLbl.Size = new Size(54, 20);
            CourseLbl.TabIndex = 0;
            CourseLbl.Text = "Course";
            // 
            // courseCombo
            // 
            courseCombo.FormattingEnabled = true;
            courseCombo.Location = new Point(377, 153);
            courseCombo.Name = "courseCombo";
            courseCombo.Size = new Size(151, 28);
            courseCombo.TabIndex = 1;
            // 
            // viewTopicsBtn
            // 
            viewTopicsBtn.Location = new Point(305, 223);
            viewTopicsBtn.Name = "viewTopicsBtn";
            viewTopicsBtn.Size = new Size(169, 29);
            viewTopicsBtn.TabIndex = 2;
            viewTopicsBtn.Text = "View Topics";
            viewTopicsBtn.UseVisualStyleBackColor = true;
            viewTopicsBtn.Click += viewTopicsBtn_Click;
            // 
            // msgLbl
            // 
            msgLbl.AutoSize = true;
            msgLbl.Location = new Point(324, 267);
            msgLbl.Name = "msgLbl";
            msgLbl.Size = new Size(132, 20);
            msgLbl.TabIndex = 3;
            msgLbl.Text = "Must select Course";
            // 
            // ViewCourseTopicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msgLbl);
            Controls.Add(viewTopicsBtn);
            Controls.Add(courseCombo);
            Controls.Add(CourseLbl);
            Name = "ViewCourseTopicsForm";
            Text = "ViewCourseTopicsForm";
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