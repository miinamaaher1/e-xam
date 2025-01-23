namespace e_xam
{
    partial class trackReportStudItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studNumLbl = new Label();
            studNameLbl = new Label();
            gpaLbl = new Label();
            SuspendLayout();
            // 
            // studNumLbl
            // 
            studNumLbl.AutoSize = true;
            studNumLbl.Font = new Font("Segoe UI", 15F);
            studNumLbl.Location = new Point(32, 15);
            studNumLbl.Name = "studNumLbl";
            studNumLbl.Size = new Size(166, 35);
            studNumLbl.TabIndex = 0;
            studNumLbl.Text = "[stud # in list]";
            // 
            // studNameLbl
            // 
            studNameLbl.AutoSize = true;
            studNameLbl.Font = new Font("Segoe UI", 15F);
            studNameLbl.Location = new Point(188, 15);
            studNameLbl.Name = "studNameLbl";
            studNameLbl.Size = new Size(197, 35);
            studNameLbl.TabIndex = 1;
            studNameLbl.Text = "[ student name ]";
            // 
            // gpaLbl
            // 
            gpaLbl.AutoSize = true;
            gpaLbl.Font = new Font("Segoe UI", 15F);
            gpaLbl.Location = new Point(424, 15);
            gpaLbl.Name = "gpaLbl";
            gpaLbl.Size = new Size(178, 35);
            gpaLbl.TabIndex = 2;
            gpaLbl.Text = "[ student gpa ]";
            // 
            // trackReportStudItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gpaLbl);
            Controls.Add(studNameLbl);
            Controls.Add(studNumLbl);
            Name = "trackReportStudItem";
            Size = new Size(621, 64);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studNumLbl;
        private Label studNameLbl;
        private Label gpaLbl;
    }
}
