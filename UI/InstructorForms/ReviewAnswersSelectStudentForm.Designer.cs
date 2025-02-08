namespace UI
{
    partial class ReviewAnswersSelectStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewAnswersSelectStudentForm));
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
            classLbl.Anchor = AnchorStyles.None;
            classLbl.AutoSize = true;
            classLbl.Font = new Font("Segoe UI", 13.8F);
            classLbl.Location = new Point(388, 289);
            classLbl.Name = "classLbl";
            classLbl.Size = new Size(138, 31);
            classLbl.TabIndex = 0;
            classLbl.Text = "Select Class:";
            // 
            // classBx
            // 
            classBx.Anchor = AnchorStyles.None;
            classBx.Font = new Font("Segoe UI", 13.8F);
            classBx.FormattingEnabled = true;
            classBx.Location = new Point(580, 286);
            classBx.Name = "classBx";
            classBx.Size = new Size(297, 39);
            classBx.TabIndex = 4;
            classBx.SelectedIndexChanged += classBx_SelectedIndexChanged;
            // 
            // studentLbl
            // 
            studentLbl.Anchor = AnchorStyles.None;
            studentLbl.AutoSize = true;
            studentLbl.Font = new Font("Segoe UI", 13.8F);
            studentLbl.Location = new Point(355, 369);
            studentLbl.Name = "studentLbl";
            studentLbl.Size = new Size(171, 31);
            studentLbl.TabIndex = 5;
            studentLbl.Text = "Select Student: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 55);
            label1.TabIndex = 6;
            label1.Text = "Select A Student";
            // 
            // studentBx
            // 
            studentBx.Anchor = AnchorStyles.None;
            studentBx.Font = new Font("Segoe UI", 13.8F);
            studentBx.FormattingEnabled = true;
            studentBx.Location = new Point(580, 366);
            studentBx.Name = "studentBx";
            studentBx.Size = new Size(297, 39);
            studentBx.TabIndex = 7;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.None;
            nextBtn.Font = new Font("Segoe UI", 13.8F);
            nextBtn.ForeColor = Color.DarkViolet;
            nextBtn.Location = new Point(559, 478);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(115, 45);
            nextBtn.TabIndex = 8;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // SelectStudentClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(nextBtn);
            Controls.Add(studentBx);
            Controls.Add(label1);
            Controls.Add(studentLbl);
            Controls.Add(classBx);
            Controls.Add(classLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectStudentClassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Review Answers";
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