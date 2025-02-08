namespace UI
{
    partial class StudentExamsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentExamsForm));
            coursename = new Label();
            examspanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // coursename
            // 
            coursename.AutoSize = true;
            coursename.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coursename.Location = new Point(14, 9);
            coursename.Name = "coursename";
            coursename.Size = new Size(284, 55);
            coursename.TabIndex = 0;
            coursename.Text = "Course Name";
            // 
            // examspanel
            // 
            examspanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            examspanel.AutoScrollMargin = new Size(2, 2);
            examspanel.AutoSize = true;
            examspanel.BackColor = SystemColors.Control;
            examspanel.FlowDirection = FlowDirection.TopDown;
            examspanel.Location = new Point(12, 90);
            examspanel.Margin = new Padding(3, 4, 3, 4);
            examspanel.Name = "examspanel";
            examspanel.Size = new Size(1208, 705);
            examspanel.TabIndex = 1;
            examspanel.WrapContents = false;
            // 
            // StudentExams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(examspanel);
            Controls.Add(coursename);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "StudentExams";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - My Exams";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label coursename;
        private FlowLayoutPanel examspanel;
    }
}