namespace e_xam
{
    partial class StudentHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHome));
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
            showCoursesItm = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            aboutItm = new ToolStripMenuItem();
            button1 = new Button();
            menuBar.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Microsoft Sans Serif", 42F, FontStyle.Bold);
            welcomeLbl.Location = new Point(12, 43);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(285, 64);
            welcomeLbl.TabIndex = 0;
            welcomeLbl.Text = "Welcome,";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Microsoft Sans Serif", 42F, FontStyle.Bold);
            nameLbl.Location = new Point(12, 140);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(328, 64);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "placeholder";
            // 
            // trackLbl
            // 
            trackLbl.AutoSize = true;
            trackLbl.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            trackLbl.Location = new Point(19, 258);
            trackLbl.Name = "trackLbl";
            trackLbl.Size = new Size(226, 44);
            trackLbl.TabIndex = 0;
            trackLbl.Text = "Dept, Track";
            // 
            // gpaLbl
            // 
            gpaLbl.AutoSize = true;
            gpaLbl.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            gpaLbl.Location = new Point(683, 258);
            gpaLbl.Name = "gpaLbl";
            gpaLbl.Size = new Size(97, 44);
            gpaLbl.TabIndex = 0;
            gpaLbl.Text = "0.00";
            // 
            // menuBar
            // 
            menuBar.ImageScalingSize = new Size(20, 20);
            menuBar.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, reportsMenu, helpMenu });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(822, 24);
            menuBar.TabIndex = 3;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { exitItm });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(37, 20);
            fileMenu.Text = "&File";
            // 
            // exitItm
            // 
            exitItm.Name = "exitItm";
            exitItm.Size = new Size(93, 22);
            exitItm.Text = "E&xit";
            exitItm.Click += exitItm_Click;
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new ToolStripItem[] { editProfileItm });
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(39, 20);
            editMenu.Text = "&Edit";
            // 
            // editProfileItm
            // 
            editProfileItm.Name = "editProfileItm";
            editProfileItm.Size = new Size(131, 22);
            editProfileItm.Text = "Edit &Profile";
            editProfileItm.Click += editProfileItm_Click;
            // 
            // reportsMenu
            // 
            reportsMenu.DropDownItems.AddRange(new ToolStripItem[] { showCoursesItm });
            reportsMenu.Name = "reportsMenu";
            reportsMenu.Size = new Size(59, 20);
            reportsMenu.Text = "&Reports";
            // 
            // showCoursesItm
            // 
            showCoursesItm.Name = "showCoursesItm";
            showCoursesItm.Size = new Size(148, 22);
            showCoursesItm.Text = "Show &Courses";
            showCoursesItm.Click += showCoursesItm_Click;
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { aboutItm });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(44, 20);
            helpMenu.Text = "&Help";
            // 
            // aboutItm
            // 
            aboutItm.Name = "aboutItm";
            aboutItm.Size = new Size(107, 22);
            aboutItm.Text = "A&bout";
            aboutItm.Click += aboutItm_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(86, 381);
            button1.Name = "button1";
            button1.Size = new Size(87, 45);
            button1.TabIndex = 4;
            button1.Text = "courses";
            button1.UseVisualStyleBackColor = true;
            button1.Click += showCoursesItm_Click;
            // 
            // StudentHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 498);
            Controls.Add(button1);
            Controls.Add(menuBar);
            Controls.Add(trackLbl);
            Controls.Add(gpaLbl);
            Controls.Add(nameLbl);
            Controls.Add(welcomeLbl);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "StudentHome";
            Text = "e-xam home";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
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
        private Button button1;
    }
}