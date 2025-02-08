namespace UI.StudentForms
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
            submitBtn = new Button();
            SuspendLayout();
            // 
            // examTitleLbl
            // 
            examTitleLbl.AutoSize = true;
            examTitleLbl.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examTitleLbl.Location = new Point(12, 9);
            examTitleLbl.Name = "examTitleLbl";
            examTitleLbl.Size = new Size(219, 46);
            examTitleLbl.TabIndex = 0;
            examTitleLbl.Text = "Exam Title";
            // 
            // examQuestionsPanel
            // 
            examQuestionsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            examQuestionsPanel.AutoScroll = true;
            examQuestionsPanel.Location = new Point(12, 90);
            examQuestionsPanel.Name = "examQuestionsPanel";
            examQuestionsPanel.Size = new Size(1208, 642);
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
            timerLbl.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLbl.ForeColor = Color.DarkViolet;
            timerLbl.Location = new Point(1086, 9);
            timerLbl.Name = "timerLbl";
            timerLbl.Size = new Size(124, 46);
            timerLbl.TabIndex = 3;
            timerLbl.Text = "00:00";
            // 
            // submitBtn
            // 
            submitBtn.Anchor = AnchorStyles.Bottom;
            submitBtn.ForeColor = Color.DarkViolet;
            submitBtn.Location = new Point(559, 750);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(115, 45);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // TakeExamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(timerLbl);
            Controls.Add(submitBtn);
            Controls.Add(examQuestionsPanel);
            Controls.Add(examTitleLbl);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
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
        private Button submitBtn;
    }
}