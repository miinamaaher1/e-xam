namespace e_xam
{
    partial class SelectStudentClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectStudentClassForm));
            classLbl = new Label();
            classBx = new ComboBox();
            studentLbl = new Label();
            label1 = new Label();
            studentBx = new ComboBox();
            nextBtn = new Button();
            SuspendLayout();
            // 
            // classLbl
            // 
            classLbl.AutoSize = true;
            classLbl.Font = new Font("Microsoft Sans Serif", 13F);
            classLbl.Location = new Point(141, 134);
            classLbl.Name = "classLbl";
            classLbl.Size = new Size(140, 26);
            classLbl.TabIndex = 0;
            classLbl.Text = "Select Class:";
            // 
            // classBx
            // 
            classBx.FormattingEnabled = true;
            classBx.Location = new Point(366, 138);
            classBx.Name = "classBx";
            classBx.Size = new Size(257, 28);
            classBx.TabIndex = 4;
            classBx.SelectedIndexChanged += classBx_SelectedIndexChanged;
            // 
            // studentLbl
            // 
            studentLbl.AutoSize = true;
            studentLbl.Font = new Font("Microsoft Sans Serif", 13F);
            studentLbl.Location = new Point(141, 229);
            studentLbl.Name = "studentLbl";
            studentLbl.Size = new Size(166, 26);
            studentLbl.TabIndex = 5;
            studentLbl.Text = "Select Student: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 29);
            label1.Name = "label1";
            label1.Size = new Size(301, 29);
            label1.TabIndex = 6;
            label1.Text = "Review Student Answers";
            // 
            // studentBx
            // 
            studentBx.FormattingEnabled = true;
            studentBx.Location = new Point(366, 231);
            studentBx.Name = "studentBx";
            studentBx.Size = new Size(257, 28);
            studentBx.TabIndex = 7;
            // 
            // nextBtn
            // 
            nextBtn.Font = new Font("Segoe UI", 13.8F);
            nextBtn.Location = new Point(305, 339);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(120, 44);
            nextBtn.TabIndex = 8;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += this.nextBtn_Click;
            // 
            // SelectStudentClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextBtn);
            Controls.Add(studentBx);
            Controls.Add(label1);
            Controls.Add(studentLbl);
            Controls.Add(classBx);
            Controls.Add(classLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectStudentClassForm";
            Text = "Answer Sheet";
            Load += SelectStudentClassForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label classLbl;
        private ComboBox classBx;
        private Label studentLbl;
        private Label label1;
        private ComboBox studentBx;
        private Button nextBtn;
    }
}