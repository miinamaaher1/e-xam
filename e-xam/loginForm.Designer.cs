namespace e_xam
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
            SuspendLayout();
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(162, 114);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(127, 31);
            userNameLbl.TabIndex = 0;
            userNameLbl.Text = "User Name";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(179, 207);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(110, 31);
            passwordLbl.TabIndex = 1;
            passwordLbl.Text = "Password";
            // 
            // userNameBx
            // 
            userNameBx.Location = new Point(336, 111);
            userNameBx.Name = "userNameBx";
            userNameBx.Size = new Size(295, 38);
            userNameBx.TabIndex = 2;
            // 
            // passwordBx
            // 
            passwordBx.Location = new Point(336, 204);
            passwordBx.Name = "passwordBx";
            passwordBx.PasswordChar = '*';
            passwordBx.Size = new Size(295, 38);
            passwordBx.TabIndex = 3;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(347, 340);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(115, 45);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 498);
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
            Text = "e-xam login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLbl;
        private Label passwordLbl;
        private TextBox userNameBx;
        private TextBox passwordBx;
        private Button loginBtn;
    }
}
