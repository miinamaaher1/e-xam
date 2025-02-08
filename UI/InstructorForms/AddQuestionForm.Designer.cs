namespace UI
{
    partial class AddQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionForm));
            addQLbl = new Label();
            typeComboBox = new ComboBox();
            typeLbl = new Label();
            bodyTxtBox = new TextBox();
            bodyLbl = new Label();
            OptionALbl = new Label();
            optionBLbl = new Label();
            OptionCLbl = new Label();
            optionDLbl = new Label();
            answerLbl = new Label();
            optionATxtBox = new TextBox();
            optionBTxtBox = new TextBox();
            optionCTxtBox = new TextBox();
            optionDTxtBox = new TextBox();
            markLbl = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            groupBox1 = new GroupBox();
            optionDRadBtn = new RadioButton();
            optionCRadBtn = new RadioButton();
            optionBRadBtn = new RadioButton();
            optionARadBtn = new RadioButton();
            tOrFGrpBox = new GroupBox();
            falseRadBtn = new RadioButton();
            trueRadBtn = new RadioButton();
            mcqGrpBx = new GroupBox();
            markTxtBox = new TextBox();
            groupBox1.SuspendLayout();
            tOrFGrpBox.SuspendLayout();
            mcqGrpBx.SuspendLayout();
            SuspendLayout();
            // 
            // addQLbl
            // 
            addQLbl.Anchor = AnchorStyles.None;
            addQLbl.AutoSize = true;
            addQLbl.Font = new Font("Raleway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addQLbl.Location = new Point(14, 9);
            addQLbl.Margin = new Padding(5, 0, 5, 0);
            addQLbl.Name = "addQLbl";
            addQLbl.Size = new Size(340, 55);
            addQLbl.TabIndex = 0;
            addQLbl.Text = "Question Details";
            // 
            // typeComboBox
            // 
            typeComboBox.Anchor = AnchorStyles.None;
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(392, 108);
            typeComboBox.Margin = new Padding(5);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(243, 39);
            typeComboBox.TabIndex = 1;
            // 
            // typeLbl
            // 
            typeLbl.Anchor = AnchorStyles.None;
            typeLbl.AutoSize = true;
            typeLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeLbl.Location = new Point(295, 111);
            typeLbl.Margin = new Padding(5, 0, 5, 0);
            typeLbl.Name = "typeLbl";
            typeLbl.Size = new Size(73, 31);
            typeLbl.TabIndex = 0;
            typeLbl.Text = "Type :";
            // 
            // bodyTxtBox
            // 
            bodyTxtBox.Anchor = AnchorStyles.None;
            bodyTxtBox.Location = new Point(392, 172);
            bodyTxtBox.Margin = new Padding(5);
            bodyTxtBox.Name = "bodyTxtBox";
            bodyTxtBox.Size = new Size(584, 38);
            bodyTxtBox.TabIndex = 2;
            // 
            // bodyLbl
            // 
            bodyLbl.Anchor = AnchorStyles.None;
            bodyLbl.AutoSize = true;
            bodyLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bodyLbl.Location = new Point(292, 175);
            bodyLbl.Margin = new Padding(5, 0, 5, 0);
            bodyLbl.Name = "bodyLbl";
            bodyLbl.Size = new Size(76, 31);
            bodyLbl.TabIndex = 0;
            bodyLbl.Text = "Body :";
            // 
            // OptionALbl
            // 
            OptionALbl.AutoSize = true;
            OptionALbl.Font = new Font("Segoe UI", 13.8F);
            OptionALbl.Location = new Point(24, 45);
            OptionALbl.Margin = new Padding(5, 0, 5, 0);
            OptionALbl.Name = "OptionALbl";
            OptionALbl.Size = new Size(117, 31);
            OptionALbl.TabIndex = 0;
            OptionALbl.Text = "Option A :";
            // 
            // optionBLbl
            // 
            optionBLbl.AutoSize = true;
            optionBLbl.Font = new Font("Segoe UI", 13.8F);
            optionBLbl.Location = new Point(26, 117);
            optionBLbl.Margin = new Padding(5, 0, 5, 0);
            optionBLbl.Name = "optionBLbl";
            optionBLbl.Size = new Size(115, 31);
            optionBLbl.TabIndex = 0;
            optionBLbl.Text = "Option B :";
            // 
            // OptionCLbl
            // 
            OptionCLbl.AutoSize = true;
            OptionCLbl.Font = new Font("Segoe UI", 13.8F);
            OptionCLbl.Location = new Point(25, 189);
            OptionCLbl.Margin = new Padding(5, 0, 5, 0);
            OptionCLbl.Name = "OptionCLbl";
            OptionCLbl.Size = new Size(116, 31);
            OptionCLbl.TabIndex = 0;
            OptionCLbl.Text = "Option C :";
            // 
            // optionDLbl
            // 
            optionDLbl.AutoSize = true;
            optionDLbl.Font = new Font("Segoe UI", 13.8F);
            optionDLbl.Location = new Point(23, 261);
            optionDLbl.Margin = new Padding(5, 0, 5, 0);
            optionDLbl.Name = "optionDLbl";
            optionDLbl.Size = new Size(118, 31);
            optionDLbl.TabIndex = 0;
            optionDLbl.Text = "Option D :";
            // 
            // answerLbl
            // 
            answerLbl.AutoSize = true;
            answerLbl.Font = new Font("Segoe UI", 13.8F);
            answerLbl.Location = new Point(41, 333);
            answerLbl.Margin = new Padding(5, 0, 5, 0);
            answerLbl.Name = "answerLbl";
            answerLbl.Size = new Size(100, 31);
            answerLbl.TabIndex = 0;
            answerLbl.Text = "Answer :";
            // 
            // optionATxtBox
            // 
            optionATxtBox.Font = new Font("Segoe UI", 13.8F);
            optionATxtBox.Location = new Point(165, 42);
            optionATxtBox.Margin = new Padding(5);
            optionATxtBox.Name = "optionATxtBox";
            optionATxtBox.Size = new Size(299, 38);
            optionATxtBox.TabIndex = 3;
            // 
            // optionBTxtBox
            // 
            optionBTxtBox.Font = new Font("Segoe UI", 13.8F);
            optionBTxtBox.Location = new Point(165, 114);
            optionBTxtBox.Margin = new Padding(5);
            optionBTxtBox.Name = "optionBTxtBox";
            optionBTxtBox.Size = new Size(299, 38);
            optionBTxtBox.TabIndex = 4;
            // 
            // optionCTxtBox
            // 
            optionCTxtBox.Font = new Font("Segoe UI", 13.8F);
            optionCTxtBox.Location = new Point(165, 186);
            optionCTxtBox.Margin = new Padding(5);
            optionCTxtBox.Name = "optionCTxtBox";
            optionCTxtBox.Size = new Size(299, 38);
            optionCTxtBox.TabIndex = 5;
            // 
            // optionDTxtBox
            // 
            optionDTxtBox.Font = new Font("Segoe UI", 13.8F);
            optionDTxtBox.Location = new Point(165, 258);
            optionDTxtBox.Margin = new Padding(5);
            optionDTxtBox.Name = "optionDTxtBox";
            optionDTxtBox.Size = new Size(299, 38);
            optionDTxtBox.TabIndex = 6;
            // 
            // markLbl
            // 
            markLbl.Anchor = AnchorStyles.None;
            markLbl.AutoSize = true;
            markLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markLbl.Location = new Point(287, 245);
            markLbl.Margin = new Padding(5, 0, 5, 0);
            markLbl.Name = "markLbl";
            markLbl.Size = new Size(77, 31);
            markLbl.TabIndex = 0;
            markLbl.Text = "Mark :";
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.Font = new Font("Segoe UI", 13.8F);
            saveBtn.ForeColor = Color.DarkViolet;
            saveBtn.Location = new Point(423, 715);
            saveBtn.Margin = new Padding(5);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(115, 45);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.None;
            cancelBtn.Font = new Font("Segoe UI", 13.8F);
            cancelBtn.Location = new Point(695, 715);
            cancelBtn.Margin = new Padding(5);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(115, 45);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optionDRadBtn);
            groupBox1.Controls.Add(optionCRadBtn);
            groupBox1.Controls.Add(optionBRadBtn);
            groupBox1.Controls.Add(optionARadBtn);
            groupBox1.Location = new Point(165, 306);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(299, 76);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // optionDRadBtn
            // 
            optionDRadBtn.AutoSize = true;
            optionDRadBtn.Location = new Point(236, 27);
            optionDRadBtn.Margin = new Padding(5);
            optionDRadBtn.Name = "optionDRadBtn";
            optionDRadBtn.Size = new Size(47, 32);
            optionDRadBtn.TabIndex = 10;
            optionDRadBtn.TabStop = true;
            optionDRadBtn.Text = "D";
            optionDRadBtn.UseVisualStyleBackColor = true;
            // 
            // optionCRadBtn
            // 
            optionCRadBtn.AutoSize = true;
            optionCRadBtn.Location = new Point(163, 27);
            optionCRadBtn.Margin = new Padding(5);
            optionCRadBtn.Name = "optionCRadBtn";
            optionCRadBtn.Size = new Size(45, 32);
            optionCRadBtn.TabIndex = 9;
            optionCRadBtn.TabStop = true;
            optionCRadBtn.Text = "C";
            optionCRadBtn.UseVisualStyleBackColor = true;
            // 
            // optionBRadBtn
            // 
            optionBRadBtn.AutoSize = true;
            optionBRadBtn.Location = new Point(89, 27);
            optionBRadBtn.Margin = new Padding(5);
            optionBRadBtn.Name = "optionBRadBtn";
            optionBRadBtn.Size = new Size(44, 32);
            optionBRadBtn.TabIndex = 8;
            optionBRadBtn.TabStop = true;
            optionBRadBtn.Text = "B";
            optionBRadBtn.UseVisualStyleBackColor = true;
            // 
            // optionARadBtn
            // 
            optionARadBtn.AutoSize = true;
            optionARadBtn.Location = new Point(15, 27);
            optionARadBtn.Margin = new Padding(5);
            optionARadBtn.Name = "optionARadBtn";
            optionARadBtn.Size = new Size(46, 32);
            optionARadBtn.TabIndex = 7;
            optionARadBtn.TabStop = true;
            optionARadBtn.Text = "A";
            optionARadBtn.UseVisualStyleBackColor = true;
            // 
            // tOrFGrpBox
            // 
            tOrFGrpBox.Anchor = AnchorStyles.None;
            tOrFGrpBox.Controls.Add(falseRadBtn);
            tOrFGrpBox.Controls.Add(trueRadBtn);
            tOrFGrpBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tOrFGrpBox.Location = new Point(773, 293);
            tOrFGrpBox.Margin = new Padding(5);
            tOrFGrpBox.Name = "tOrFGrpBox";
            tOrFGrpBox.Padding = new Padding(5);
            tOrFGrpBox.Size = new Size(203, 176);
            tOrFGrpBox.TabIndex = 0;
            tOrFGrpBox.TabStop = false;
            tOrFGrpBox.Text = "True/False Question";
            // 
            // falseRadBtn
            // 
            falseRadBtn.AutoSize = true;
            falseRadBtn.Font = new Font("Segoe UI", 13.8F);
            falseRadBtn.Location = new Point(30, 118);
            falseRadBtn.Margin = new Padding(5);
            falseRadBtn.Name = "falseRadBtn";
            falseRadBtn.Size = new Size(85, 35);
            falseRadBtn.TabIndex = 12;
            falseRadBtn.TabStop = true;
            falseRadBtn.Text = "False";
            falseRadBtn.UseVisualStyleBackColor = true;
            // 
            // trueRadBtn
            // 
            trueRadBtn.AutoSize = true;
            trueRadBtn.Font = new Font("Segoe UI", 13.8F);
            trueRadBtn.Location = new Point(30, 43);
            trueRadBtn.Margin = new Padding(5);
            trueRadBtn.Name = "trueRadBtn";
            trueRadBtn.Size = new Size(78, 35);
            trueRadBtn.TabIndex = 11;
            trueRadBtn.TabStop = true;
            trueRadBtn.Text = "True";
            trueRadBtn.UseVisualStyleBackColor = true;
            // 
            // mcqGrpBx
            // 
            mcqGrpBx.Anchor = AnchorStyles.None;
            mcqGrpBx.Controls.Add(OptionALbl);
            mcqGrpBx.Controls.Add(optionBLbl);
            mcqGrpBx.Controls.Add(groupBox1);
            mcqGrpBx.Controls.Add(OptionCLbl);
            mcqGrpBx.Controls.Add(optionDLbl);
            mcqGrpBx.Controls.Add(answerLbl);
            mcqGrpBx.Controls.Add(optionATxtBox);
            mcqGrpBx.Controls.Add(optionBTxtBox);
            mcqGrpBx.Controls.Add(optionDTxtBox);
            mcqGrpBx.Controls.Add(optionCTxtBox);
            mcqGrpBx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mcqGrpBx.Location = new Point(227, 293);
            mcqGrpBx.Margin = new Padding(5);
            mcqGrpBx.Name = "mcqGrpBx";
            mcqGrpBx.Padding = new Padding(5);
            mcqGrpBx.Size = new Size(517, 408);
            mcqGrpBx.TabIndex = 0;
            mcqGrpBx.TabStop = false;
            mcqGrpBx.Text = "MCQ Question";
            // 
            // markTxtBox
            // 
            markTxtBox.Anchor = AnchorStyles.None;
            markTxtBox.Location = new Point(392, 242);
            markTxtBox.Margin = new Padding(5);
            markTxtBox.Name = "markTxtBox";
            markTxtBox.Size = new Size(243, 38);
            markTxtBox.TabIndex = 13;
            // 
            // AddQuestionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(mcqGrpBx);
            Controls.Add(tOrFGrpBox);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(markLbl);
            Controls.Add(markTxtBox);
            Controls.Add(bodyLbl);
            Controls.Add(bodyTxtBox);
            Controls.Add(typeLbl);
            Controls.Add(typeComboBox);
            Controls.Add(addQLbl);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "AddQuestionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Add Question";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tOrFGrpBox.ResumeLayout(false);
            tOrFGrpBox.PerformLayout();
            mcqGrpBx.ResumeLayout(false);
            mcqGrpBx.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addQLbl;
        private ComboBox typeComboBox;
        private Label typeLbl;
        private TextBox bodyTxtBox;
        private Label bodyLbl;
        private Label OptionALbl;
        private Label optionBLbl;
        private Label OptionCLbl;
        private Label optionDLbl;
        private Label answerLbl;
        private TextBox optionATxtBox;
        private TextBox optionBTxtBox;
        private TextBox optionCTxtBox;
        private TextBox optionDTxtBox;
        private Label markLbl;
        private Button saveBtn;
        private Button cancelBtn;
        private GroupBox groupBox1;
        private RadioButton optionDRadBtn;
        private RadioButton optionCRadBtn;
        private RadioButton optionBRadBtn;
        private RadioButton optionARadBtn;
        private GroupBox tOrFGrpBox;
        private RadioButton falseRadBtn;
        private RadioButton trueRadBtn;
        private GroupBox mcqGrpBx;
        private TextBox markTxtBox;
    }
}