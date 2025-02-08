namespace UI
{
    partial class StudentCoursesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCoursesForm));
            courselbal = new Label();
            courses = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // courselbal
            // 
            courselbal.AutoSize = true;
            courselbal.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courselbal.Location = new Point(12, 9);
            courselbal.Name = "courselbal";
            courselbal.Size = new Size(179, 55);
            courselbal.TabIndex = 0;
            courselbal.Text = "Courses";
            // 
            // courses
            // 
            courses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            courses.AutoScroll = true;
            courses.AutoSize = true;
            courses.FlowDirection = FlowDirection.TopDown;
            courses.Location = new Point(12, 90);
            courses.Margin = new Padding(3, 4, 3, 4);
            courses.Name = "courses";
            courses.Size = new Size(1208, 705);
            courses.TabIndex = 1;
            // 
            // Studentcourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(courses);
            Controls.Add(courselbal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Studentcourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - My Courses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label courselbal;
        private FlowLayoutPanel courses;
    }
}