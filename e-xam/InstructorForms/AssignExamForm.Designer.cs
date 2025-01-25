namespace e_xam.InstructorForms
{
    partial class AssignExamForm
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
            AssignExamGV = new DataGridView();
            saveExamTracksBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AssignExamGV).BeginInit();
            SuspendLayout();
            // 
            // AssignExamGV
            // 
            AssignExamGV.AllowUserToAddRows = false;
            AssignExamGV.AllowUserToDeleteRows = false;
            AssignExamGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssignExamGV.Dock = DockStyle.Top;
            AssignExamGV.Location = new Point(0, 0);
            AssignExamGV.Name = "AssignExamGV";
            AssignExamGV.RowHeadersWidth = 51;
            AssignExamGV.Size = new Size(800, 233);
            AssignExamGV.TabIndex = 0;

            // 
            // saveExamTracksBtn
            // 
            saveExamTracksBtn.Location = new Point(340, 359);
            saveExamTracksBtn.Name = "saveExamTracksBtn";
            saveExamTracksBtn.Size = new Size(94, 29);
            saveExamTracksBtn.TabIndex = 1;
            saveExamTracksBtn.Text = "Save";
            saveExamTracksBtn.UseVisualStyleBackColor = true;
            saveExamTracksBtn.Click += saveExamTracksBtn_Click;
            // 
            // AssignExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveExamTracksBtn);
            Controls.Add(AssignExamGV);
            Name = "AssignExamForm";
            Text = "AssignExamForm";
            Load += AssignExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)AssignExamGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AssignExamGV;
        private Button saveExamTracksBtn;
    }
}