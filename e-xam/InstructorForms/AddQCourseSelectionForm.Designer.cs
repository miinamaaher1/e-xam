namespace e_xam
{
    partial class AddQCourseSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQCourseSelectionForm));
            coursesComboBox = new ComboBox();
            okBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // coursesComboBox
            // 
            coursesComboBox.Anchor = AnchorStyles.None;
            coursesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            coursesComboBox.Font = new Font("Segoe UI", 15F);
            coursesComboBox.FormattingEnabled = true;
            coursesComboBox.Location = new Point(498, 379);
            coursesComboBox.Name = "coursesComboBox";
            coursesComboBox.Size = new Size(236, 43);
            coursesComboBox.TabIndex = 1;
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.None;
            okBtn.Location = new Point(562, 456);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(108, 35);
            okBtn.TabIndex = 2;
            okBtn.Text = "Ok";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(320, 318);
            label1.Name = "label1";
            label1.Size = new Size(307, 35);
            label1.TabIndex = 0;
            label1.Text = "Please choose the course :";
            // 
            // AddQCourseSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(label1);
            Controls.Add(okBtn);
            Controls.Add(coursesComboBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
    }
}