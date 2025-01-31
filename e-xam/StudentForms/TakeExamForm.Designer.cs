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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeExamForm));
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
            examTitleLbl.Location = new Point(25, 20);
            examTitleLbl.Name = "examTitleLbl";
            examTitleLbl.Size = new Size(224, 55);
            examTitleLbl.TabIndex = 0;
            examTitleLbl.Text = "Exam Title";
            // 
            // examQuestionsPanel
            // 
            examQuestionsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            examQuestionsPanel.AutoScroll = true;
            examQuestionsPanel.Location = new Point(31, 105);
            examQuestionsPanel.Name = "examQuestionsPanel";
            examQuestionsPanel.Size = new Size(1170, 623);
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
            timerLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timerLbl.AutoSize = true;
            timerLbl.Font = new Font("Raleway SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLbl.Location = new Point(1075, 23);
            timerLbl.Name = "timerLbl";
            timerLbl.Size = new Size(133, 55);
            timerLbl.TabIndex = 3;
            timerLbl.Text = "00:00";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(558, 750);
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
            ClientSize = new Size(1232, 808);
            Controls.Add(timerLbl);
            Controls.Add(button1);
            Controls.Add(examQuestionsPanel);
            Controls.Add(examTitleLbl);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "TakeExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Exam";
            Resize += TakeExamForm_Resize;
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