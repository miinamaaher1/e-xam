namespace UI
{
    partial class InstructorHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorHomeForm));
            welcomeLbl = new Label();
            nameLbl = new Label();
            trackLbl = new Label();
            menuBar = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            addQuestionItm = new ToolStripMenuItem();
            generateExamItm = new ToolStripMenuItem();
            exitItm = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            editProfileItm = new ToolStripMenuItem();
            reportsMenu = new ToolStripMenuItem();
            courseDetailsItm = new ToolStripMenuItem();
            instructorClassesItm = new ToolStripMenuItem();
            answerSheetItm = new ToolStripMenuItem();
            studentStatsItm = new ToolStripMenuItem();
            trackStatsItm = new ToolStripMenuItem();
            coursesExamsItm = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            aboutItm = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // welcomeLbl
            // 
            welcomeLbl.Anchor = AnchorStyles.None;
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Raleway ExtraBold", 41.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(513, 31);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(130, 97);
            welcomeLbl.TabIndex = 0;
            welcomeLbl.Text = "Hi,";
            // 
            // nameLbl
            // 
            nameLbl.Anchor = AnchorStyles.None;
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Raleway ExtraBold", 41.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLbl.Location = new Point(617, 31);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(458, 97);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "placeholder";
            // 
            // trackLbl
            // 
            trackLbl.AutoSize = true;
            trackLbl.Font = new Font("Raleway ExtraBold", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trackLbl.Location = new Point(519, 149);
            trackLbl.Name = "trackLbl";
            trackLbl.RightToLeft = RightToLeft.No;
            trackLbl.Size = new Size(139, 65);
            trackLbl.TabIndex = 0;
            trackLbl.Text = "Dept";
            // 
            // menuBar
            // 
            menuBar.ImageScalingSize = new Size(20, 20);
            menuBar.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, reportsMenu, helpMenu });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(1232, 28);
            menuBar.TabIndex = 2;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { addQuestionItm, generateExamItm, exitItm });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(46, 24);
            fileMenu.Text = "&File";
            // 
            // addQuestionItm
            // 
            addQuestionItm.Name = "addQuestionItm";
            addQuestionItm.Size = new Size(192, 26);
            addQuestionItm.Text = "Add &Question";
            addQuestionItm.Click += addQuestionItm_Click;
            // 
            // generateExamItm
            // 
            generateExamItm.Name = "generateExamItm";
            generateExamItm.Size = new Size(192, 26);
            generateExamItm.Text = "&Generate Exam";
            generateExamItm.Click += generateExamItm_Click;
            // 
            // exitItm
            // 
            exitItm.Name = "exitItm";
            exitItm.Size = new Size(192, 26);
            exitItm.Text = "E&xit";
            exitItm.Click += exitItm_Click;
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new ToolStripItem[] { editProfileItm });
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(49, 24);
            editMenu.Text = "&Edit";
            // 
            // editProfileItm
            // 
            editProfileItm.Name = "editProfileItm";
            editProfileItm.Size = new Size(165, 26);
            editProfileItm.Text = "Edit &Profile";
            editProfileItm.Click += editProfileItm_Click;
            // 
            // reportsMenu
            // 
            reportsMenu.DropDownItems.AddRange(new ToolStripItem[] { courseDetailsItm, instructorClassesItm, answerSheetItm, studentStatsItm, trackStatsItm, coursesExamsItm });
            reportsMenu.Name = "reportsMenu";
            reportsMenu.Size = new Size(74, 24);
            reportsMenu.Text = "&Reports";
            // 
            // courseDetailsItm
            // 
            courseDetailsItm.Name = "courseDetailsItm";
            courseDetailsItm.Size = new Size(197, 26);
            courseDetailsItm.Text = "&Course Details";
            courseDetailsItm.Click += courseDetailsItm_Click;
            // 
            // instructorClassesItm
            // 
            instructorClassesItm.Name = "instructorClassesItm";
            instructorClassesItm.Size = new Size(197, 26);
            instructorClassesItm.Text = "&My Classes";
            instructorClassesItm.Click += instructorClassesItm_Click;
            // 
            // answerSheetItm
            // 
            answerSheetItm.Name = "answerSheetItm";
            answerSheetItm.Size = new Size(197, 26);
            answerSheetItm.Text = "&Review Answers";
            answerSheetItm.Click += answerSheetItm_Click;
            // 
            // studentStatsItm
            // 
            studentStatsItm.Name = "studentStatsItm";
            studentStatsItm.Size = new Size(197, 26);
            studentStatsItm.Text = "&Student Stats";
            studentStatsItm.Click += studentStatsItm_Click;
            // 
            // trackStatsItm
            // 
            trackStatsItm.Name = "trackStatsItm";
            trackStatsItm.Size = new Size(197, 26);
            trackStatsItm.Text = "&Track Stats";
            trackStatsItm.Click += trackStatsItm_Click;
            // 
            // coursesExamsItm
            // 
            coursesExamsItm.Name = "coursesExamsItm";
            coursesExamsItm.Size = new Size(197, 26);
            coursesExamsItm.Text = "&View Exam";
            coursesExamsItm.Click += coursesExamsItm_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { aboutItm });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(55, 24);
            helpMenu.Text = "&Help";
            // 
            // aboutItm
            // 
            aboutItm.Name = "aboutItm";
            aboutItm.Size = new Size(133, 26);
            aboutItm.Text = "A&bout";
            aboutItm.Click += aboutItm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.splash_screen;
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 765);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // InstructorHome
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(pictureBox1);
            Controls.Add(trackLbl);
            Controls.Add(nameLbl);
            Controls.Add(welcomeLbl);
            Controls.Add(menuBar);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "InstructorHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Home";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLbl;
        private Label nameLbl;
        private Label trackLbl;
        private MenuStrip menuBar;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem reportsMenu;
        private ToolStripMenuItem addQuestionItm;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem aboutItm;
        private ToolStripMenuItem answerSheetItm;
        private ToolStripMenuItem courseDetailsItm;
        private ToolStripMenuItem instructorClassesItm;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem trackStatsItm;
        private ToolStripMenuItem studentStatsItm;
        private ToolStripMenuItem generateExamItm;
        private ToolStripMenuItem exitItm;
        private ToolStripMenuItem editProfileItm;
        private ToolStripMenuItem coursesExamsItm;
        private PictureBox pictureBox1;
    }
}