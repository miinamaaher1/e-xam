namespace UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            userNameLbl = new Label();
            passwordLbl = new Label();
            userNameBx = new TextBox();
            passwordBx = new TextBox();
            loginBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userNameLbl
            // 
            userNameLbl.Anchor = AnchorStyles.None;
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(672, 259);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(127, 31);
            userNameLbl.TabIndex = 0;
            userNameLbl.Text = "User Name";
            // 
            // passwordLbl
            // 
            passwordLbl.Anchor = AnchorStyles.None;
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(672, 380);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(110, 31);
            passwordLbl.TabIndex = 0;
            passwordLbl.Text = "Password";
            // 
            // userNameBx
            // 
            userNameBx.Anchor = AnchorStyles.None;
            userNameBx.Location = new Point(672, 293);
            userNameBx.Name = "userNameBx";
            userNameBx.Size = new Size(406, 38);
            userNameBx.TabIndex = 1;
            // 
            // passwordBx
            // 
            passwordBx.Anchor = AnchorStyles.None;
            passwordBx.Location = new Point(672, 414);
            passwordBx.Name = "passwordBx";
            passwordBx.PasswordChar = '*';
            passwordBx.Size = new Size(406, 38);
            passwordBx.TabIndex = 2;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.None;
            loginBtn.ForeColor = Color.DarkViolet;
            loginBtn.Location = new Point(963, 505);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(115, 45);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.splash_screen;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 785);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(pictureBox1);
            Controls.Add(loginBtn);
            Controls.Add(passwordBx);
            Controls.Add(userNameBx);
            Controls.Add(passwordLbl);
            Controls.Add(userNameLbl);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLbl;
        private Label passwordLbl;
        private TextBox userNameBx;
        private TextBox passwordBx;
        private Button loginBtn;
        private PictureBox pictureBox1;
    }
}
