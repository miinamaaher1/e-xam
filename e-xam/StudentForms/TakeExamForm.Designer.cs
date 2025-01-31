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
            components = new System.ComponentModel.Container();
            examTitleLbl = new Label();
            examQuestionsPanel = new FlowLayoutPanel();
            durationTimer = new System.Windows.Forms.Timer(components);
            timerLbl = new Label();
            button1 = new Button();
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
            examQuestionsPanel.Size = new Size(760, 302);
            examQuestionsPanel.TabIndex = 1;
            // 
            // durationTimer
            // 
            durationTimer.Enabled = true;
            durationTimer.Interval = 1000;
            durationTimer.Tick += durationTimer_Tick;
            // 
            // timerLbl
            // 
            timerLbl.AutoSize = true;
            timerLbl.Location = new Point(723, 41);
            timerLbl.Name = "timerLbl";
            timerLbl.Size = new Size(67, 31);
            timerLbl.TabIndex = 3;
            timerLbl.Text = "00:00";
            // 
            // button1
            // 
            button1.Location = new Point(353, 440);
            button1.Name = "button1";
            button1.Size = new Size(121, 37);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += submitBtn_Click;
            // 
            // TakeExamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 498);
            Controls.Add(timerLbl);
            Controls.Add(button1);
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
        private System.Windows.Forms.Timer durationTimer;
        private Label timerLbl;
        private Button button1;
    }
}