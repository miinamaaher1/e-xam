namespace e_xam
{
    partial class Studentcourse
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
            courselbal = new Label();
            courses = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // courselbal
            // 
            courselbal.AutoSize = true;
            courselbal.Font = new Font("Simplified Arabic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courselbal.Location = new Point(98, 38);
            courselbal.Name = "courselbal";
            courselbal.Size = new Size(104, 41);
            courselbal.TabIndex = 0;
            courselbal.Text = "Courses";
            // 
            // courses
            // 
            courses.Location = new Point(21, 82);
            courses.Name = "courses";
            courses.Size = new Size(313, 254);
            courses.TabIndex = 1;
            // 
            // Studentcourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(courses);
            Controls.Add(courselbal);
            Name = "Studentcourse";
            Text = "Studentcourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label courselbal;
        private FlowLayoutPanel courses;
    }
}