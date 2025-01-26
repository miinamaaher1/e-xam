namespace e_xam.StudentForms
{
    partial class TakeExamForm
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
            examTitleLbl = new Label();
            examQuestionsPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // examTitleLbl
            // 
            examTitleLbl.AutoSize = true;
            examTitleLbl.Font = new Font("Raleway SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examTitleLbl.Location = new Point(30, 20);
            examTitleLbl.Name = "examTitleLbl";
            examTitleLbl.Size = new Size(224, 55);
            examTitleLbl.TabIndex = 0;
            examTitleLbl.Text = "Exam Title";
            // 
            // examQuestionsPanel
            // 
            examQuestionsPanel.AutoScroll = true;
            examQuestionsPanel.Location = new Point(30, 105);
            examQuestionsPanel.Name = "examQuestionsPanel";
            examQuestionsPanel.Size = new Size(760, 381);
            examQuestionsPanel.TabIndex = 1;
            // 
            // TakeExamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 498);
            Controls.Add(examQuestionsPanel);
            Controls.Add(examTitleLbl);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "TakeExamForm";
            Text = "Exam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label examTitleLbl;
        private FlowLayoutPanel examQuestionsPanel;
    }
}