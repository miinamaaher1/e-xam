namespace e_xam
{
    partial class StudentExams
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
            coursename = new Label();
            examspanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // coursename
            // 
            coursename.AutoSize = true;
            coursename.Location = new Point(66, 25);
            coursename.Name = "coursename";
            coursename.Size = new Size(38, 15);
            coursename.TabIndex = 0;
            coursename.Text = "label1";
            // 
            // examspanel
            // 
            examspanel.AutoScrollMargin = new Size(2, 2);
            examspanel.AutoSize = true;
            examspanel.BackColor = SystemColors.Control;
            examspanel.FlowDirection = FlowDirection.TopDown;
            examspanel.Location = new Point(12, 71);
            examspanel.Name = "examspanel";
            examspanel.Size = new Size(749, 378);
            examspanel.TabIndex = 1;
            examspanel.WrapContents = false;
            // 
            // StudentExams
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(examspanel);
            Controls.Add(coursename);
            Name = "StudentExams";
            Text = "StudentExams";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label coursename;
        private FlowLayoutPanel examspanel;
    }
}