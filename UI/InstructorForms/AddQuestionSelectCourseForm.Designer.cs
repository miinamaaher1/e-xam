namespace UI
{
    partial class AddQuestionSelectCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionSelectCourseForm));
            coursesComboBox = new ComboBox();
            okBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // coursesComboBox
            // 
            coursesComboBox.Anchor = AnchorStyles.None;
            coursesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            coursesComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coursesComboBox.FormattingEnabled = true;
            coursesComboBox.Location = new Point(538, 340);
            coursesComboBox.Name = "coursesComboBox";
            coursesComboBox.Size = new Size(297, 39);
            coursesComboBox.TabIndex = 1;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.None;
            okBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            okBtn.ForeColor = Color.DarkViolet;
            okBtn.Location = new Point(559, 424);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(115, 45);
            okBtn.TabIndex = 2;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 55);
            label1.TabIndex = 0;
            label1.Text = "Select A Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(397, 343);
            label2.Name = "label2";
            label2.Size = new Size(95, 31);
            label2.TabIndex = 3;
            label2.Text = "Course :";
            // 
            // AddQCourseSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(okBtn);
            Controls.Add(coursesComboBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddQCourseSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Add Question";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox coursesComboBox;
        private Button okBtn;
        private Label label1;
        private Label label2;
    }
}