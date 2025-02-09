namespace UI
{
    partial class StudentHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHomeForm));
            welcomeLbl = new Label();
            nameLbl = new Label();
            trackLbl = new Label();
            gpaLbl = new Label();
            menuBar = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            exitItm = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            editProfileItm = new ToolStripMenuItem();
            reportsMenu = new ToolStripMenuItem();
            myStatsItem = new ToolStripMenuItem();
            showCoursesItm = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            aboutItm = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // welcomeLbl
            // 
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
            trackLbl.Font = new Font("Raleway ExtraBold", 28.1999989F, FontStyle.Bold);
            trackLbl.Location = new Point(519, 149);
            trackLbl.Name = "trackLbl";
            trackLbl.RightToLeft = RightToLeft.No;
            trackLbl.Size = new Size(289, 65);
            trackLbl.TabIndex = 0;
            trackLbl.Text = "Dept, Track";
            // 
            // gpaLbl
            // 
            gpaLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gpaLbl.AutoSize = true;
            gpaLbl.Font = new Font("Raleway ExtraBold", 28.1999989F, FontStyle.Bold);
            gpaLbl.Location = new Point(1016, 246);
            gpaLbl.Name = "gpaLbl";
            gpaLbl.Size = new Size(155, 65);
            gpaLbl.TabIndex = 0;
            gpaLbl.Text = "00.00";
            gpaLbl.TextAlign = ContentAlignment.TopRight;
            // 
            // menuBar
            // 
            menuBar.ImageScalingSize = new Size(20, 20);
            menuBar.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, reportsMenu, helpMenu });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(1232, 28);
            menuBar.TabIndex = 3;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { exitItm });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(46, 24);
            fileMenu.Text = "&File";
            // 
            // exitItm
            // 
            exitItm.Name = "exitItm";
            exitItm.Size = new Size(116, 26);
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
            reportsMenu.DropDownItems.AddRange(new ToolStripItem[] { myStatsItem, showCoursesItm });
            reportsMenu.Name = "reportsMenu";
            reportsMenu.Size = new Size(74, 24);
            reportsMenu.Text = "&Reports";
            // 
            // myStatsItem
            // 
            myStatsItem.Name = "myStatsItem";
            myStatsItem.Size = new Size(183, 26);
            myStatsItem.Text = "&My Stats";
            myStatsItem.Click += myStatsItem_Click;
            // 
            // showCoursesItm
            // 
            showCoursesItm.Name = "showCoursesItm";
            showCoursesItm.Size = new Size(183, 26);
            showCoursesItm.Text = "Show &Courses";
            showCoursesItm.Click += showCoursesItm_Click;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Raleway ExtraBold", 28.1999989F, FontStyle.Bold);
            label1.ForeColor = Color.DarkViolet;
            label1.Location = new Point(1154, 246);
            label1.Name = "label1";
            label1.Size = new Size(66, 65);
            label1.TabIndex = 0;
            label1.Text = "%";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.splash_screen;
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 765);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // StudentHomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(pictureBox1);
            Controls.Add(menuBar);
            Controls.Add(trackLbl);
            Controls.Add(label1);
            Controls.Add(gpaLbl);
            Controls.Add(nameLbl);
            Controls.Add(welcomeLbl);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "StudentHomeForm";
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
        private Label gpaLbl;
        private MenuStrip menuBar;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem exitItm;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem editProfileItm;
        private ToolStripMenuItem reportsMenu;
        private ToolStripMenuItem helpMenu;
        private ToolStripMenuItem aboutItm;
        private ToolStripMenuItem showCoursesItm;
        private Label label1;
        private ToolStripMenuItem myStatsItem;
        private PictureBox pictureBox1;
    }
}