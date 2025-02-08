namespace UI
{
    partial class EditProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileForm));
            editProfileTabs = new TabControl();
            personalInfoTab = new TabPage();
            femaleBtn = new RadioButton();
            maleBtn = new RadioButton();
            saveGenderBtn = new Button();
            saveSsnBtn = new Button();
            saveLastNameBtn = new Button();
            saveFirstNameBtn = new Button();
            ssnBx = new TextBox();
            lastNameBx = new TextBox();
            firstNameBx = new TextBox();
            genderLbl = new Label();
            ssnLbl = new Label();
            lastNameLbl = new Label();
            firstNameLbl = new Label();
            credentialsTab = new TabPage();
            saveNewPasswordBtn = new Button();
            newUserNameSaveBtn = new Button();
            confirmPasswordBx = new TextBox();
            newPasswordBx = new TextBox();
            oldPasswordBx = new TextBox();
            newUserNameBx = new TextBox();
            confirmPassordLbl = new Label();
            newPasswordLbl = new Label();
            oldPasswordLbl = new Label();
            newUserNameLbl = new Label();
            editProfileTabs.SuspendLayout();
            personalInfoTab.SuspendLayout();
            credentialsTab.SuspendLayout();
            SuspendLayout();
            // 
            // editProfileTabs
            // 
            editProfileTabs.Controls.Add(personalInfoTab);
            editProfileTabs.Controls.Add(credentialsTab);
            editProfileTabs.Dock = DockStyle.Fill;
            editProfileTabs.Location = new Point(0, 0);
            editProfileTabs.Margin = new Padding(5);
            editProfileTabs.Name = "editProfileTabs";
            editProfileTabs.SelectedIndex = 0;
            editProfileTabs.Size = new Size(1232, 808);
            editProfileTabs.TabIndex = 0;
            // 
            // personalInfoTab
            // 
            personalInfoTab.BackColor = Color.Transparent;
            personalInfoTab.Controls.Add(femaleBtn);
            personalInfoTab.Controls.Add(maleBtn);
            personalInfoTab.Controls.Add(saveGenderBtn);
            personalInfoTab.Controls.Add(saveSsnBtn);
            personalInfoTab.Controls.Add(saveLastNameBtn);
            personalInfoTab.Controls.Add(saveFirstNameBtn);
            personalInfoTab.Controls.Add(ssnBx);
            personalInfoTab.Controls.Add(lastNameBx);
            personalInfoTab.Controls.Add(firstNameBx);
            personalInfoTab.Controls.Add(genderLbl);
            personalInfoTab.Controls.Add(ssnLbl);
            personalInfoTab.Controls.Add(lastNameLbl);
            personalInfoTab.Controls.Add(firstNameLbl);
            personalInfoTab.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            personalInfoTab.Location = new Point(4, 40);
            personalInfoTab.Margin = new Padding(5);
            personalInfoTab.Name = "personalInfoTab";
            personalInfoTab.Padding = new Padding(5);
            personalInfoTab.Size = new Size(1224, 764);
            personalInfoTab.TabIndex = 0;
            personalInfoTab.Text = "Personal Info";
            // 
            // femaleBtn
            // 
            femaleBtn.Anchor = AnchorStyles.None;
            femaleBtn.AutoSize = true;
            femaleBtn.Location = new Point(653, 504);
            femaleBtn.Name = "femaleBtn";
            femaleBtn.Size = new Size(108, 35);
            femaleBtn.TabIndex = 18;
            femaleBtn.TabStop = true;
            femaleBtn.Text = "Female";
            femaleBtn.UseVisualStyleBackColor = true;
            // 
            // maleBtn
            // 
            maleBtn.Anchor = AnchorStyles.None;
            maleBtn.AutoSize = true;
            maleBtn.Location = new Point(464, 504);
            maleBtn.Name = "maleBtn";
            maleBtn.Size = new Size(86, 35);
            maleBtn.TabIndex = 19;
            maleBtn.TabStop = true;
            maleBtn.Text = "Male";
            maleBtn.UseVisualStyleBackColor = true;
            // 
            // saveGenderBtn
            // 
            saveGenderBtn.Anchor = AnchorStyles.None;
            saveGenderBtn.ForeColor = Color.DarkViolet;
            saveGenderBtn.Location = new Point(799, 499);
            saveGenderBtn.Name = "saveGenderBtn";
            saveGenderBtn.Size = new Size(115, 45);
            saveGenderBtn.TabIndex = 14;
            saveGenderBtn.Text = "Save";
            saveGenderBtn.UseVisualStyleBackColor = true;
            saveGenderBtn.Click += saveGenderBtn_Click;
            // 
            // saveSsnBtn
            // 
            saveSsnBtn.Anchor = AnchorStyles.None;
            saveSsnBtn.ForeColor = Color.DarkViolet;
            saveSsnBtn.Location = new Point(799, 407);
            saveSsnBtn.Name = "saveSsnBtn";
            saveSsnBtn.Size = new Size(115, 45);
            saveSsnBtn.TabIndex = 15;
            saveSsnBtn.Text = "Save";
            saveSsnBtn.UseVisualStyleBackColor = true;
            saveSsnBtn.Click += saveSsnBtn_Click;
            // 
            // saveLastNameBtn
            // 
            saveLastNameBtn.Anchor = AnchorStyles.None;
            saveLastNameBtn.ForeColor = Color.DarkViolet;
            saveLastNameBtn.Location = new Point(799, 314);
            saveLastNameBtn.Name = "saveLastNameBtn";
            saveLastNameBtn.Size = new Size(115, 45);
            saveLastNameBtn.TabIndex = 16;
            saveLastNameBtn.Text = "Save";
            saveLastNameBtn.UseVisualStyleBackColor = true;
            saveLastNameBtn.Click += saveLastNameBtn_Click;
            // 
            // saveFirstNameBtn
            // 
            saveFirstNameBtn.Anchor = AnchorStyles.None;
            saveFirstNameBtn.ForeColor = Color.DarkViolet;
            saveFirstNameBtn.Location = new Point(799, 221);
            saveFirstNameBtn.Name = "saveFirstNameBtn";
            saveFirstNameBtn.Size = new Size(115, 45);
            saveFirstNameBtn.TabIndex = 17;
            saveFirstNameBtn.Text = "Save";
            saveFirstNameBtn.UseVisualStyleBackColor = true;
            saveFirstNameBtn.Click += saveFirstNameBtn_Click;
            // 
            // ssnBx
            // 
            ssnBx.Anchor = AnchorStyles.None;
            ssnBx.Location = new Point(464, 411);
            ssnBx.Name = "ssnBx";
            ssnBx.Size = new Size(297, 38);
            ssnBx.TabIndex = 11;
            // 
            // lastNameBx
            // 
            lastNameBx.Anchor = AnchorStyles.None;
            lastNameBx.Location = new Point(464, 318);
            lastNameBx.Name = "lastNameBx";
            lastNameBx.Size = new Size(297, 38);
            lastNameBx.TabIndex = 12;
            // 
            // firstNameBx
            // 
            firstNameBx.Anchor = AnchorStyles.None;
            firstNameBx.Location = new Point(464, 225);
            firstNameBx.Name = "firstNameBx";
            firstNameBx.Size = new Size(297, 38);
            firstNameBx.TabIndex = 13;
            // 
            // genderLbl
            // 
            genderLbl.Anchor = AnchorStyles.None;
            genderLbl.AutoSize = true;
            genderLbl.Location = new Point(345, 506);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(89, 31);
            genderLbl.TabIndex = 10;
            genderLbl.Text = "Gender";
            // 
            // ssnLbl
            // 
            ssnLbl.Anchor = AnchorStyles.None;
            ssnLbl.AutoSize = true;
            ssnLbl.Location = new Point(379, 414);
            ssnLbl.Name = "ssnLbl";
            ssnLbl.Size = new Size(55, 31);
            ssnLbl.TabIndex = 9;
            ssnLbl.Text = "SSN";
            // 
            // lastNameLbl
            // 
            lastNameLbl.Anchor = AnchorStyles.None;
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(312, 321);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(122, 31);
            lastNameLbl.TabIndex = 8;
            lastNameLbl.Text = "Last Name";
            // 
            // firstNameLbl
            // 
            firstNameLbl.Anchor = AnchorStyles.None;
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(310, 228);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(124, 31);
            firstNameLbl.TabIndex = 7;
            firstNameLbl.Text = "First Name";
            // 
            // credentialsTab
            // 
            credentialsTab.BackColor = Color.Transparent;
            credentialsTab.Controls.Add(saveNewPasswordBtn);
            credentialsTab.Controls.Add(newUserNameSaveBtn);
            credentialsTab.Controls.Add(confirmPasswordBx);
            credentialsTab.Controls.Add(newPasswordBx);
            credentialsTab.Controls.Add(oldPasswordBx);
            credentialsTab.Controls.Add(newUserNameBx);
            credentialsTab.Controls.Add(confirmPassordLbl);
            credentialsTab.Controls.Add(newPasswordLbl);
            credentialsTab.Controls.Add(oldPasswordLbl);
            credentialsTab.Controls.Add(newUserNameLbl);
            credentialsTab.Location = new Point(4, 40);
            credentialsTab.Name = "credentialsTab";
            credentialsTab.Padding = new Padding(3);
            credentialsTab.Size = new Size(1224, 764);
            credentialsTab.TabIndex = 2;
            credentialsTab.Text = "Credentials";
            // 
            // saveNewPasswordBtn
            // 
            saveNewPasswordBtn.Anchor = AnchorStyles.None;
            saveNewPasswordBtn.ForeColor = Color.DarkViolet;
            saveNewPasswordBtn.Location = new Point(799, 310);
            saveNewPasswordBtn.Name = "saveNewPasswordBtn";
            saveNewPasswordBtn.Size = new Size(115, 45);
            saveNewPasswordBtn.TabIndex = 17;
            saveNewPasswordBtn.Text = "Save";
            saveNewPasswordBtn.UseVisualStyleBackColor = true;
            saveNewPasswordBtn.Click += saveNewPasswordBtn_Click;
            // 
            // newUserNameSaveBtn
            // 
            newUserNameSaveBtn.Anchor = AnchorStyles.None;
            newUserNameSaveBtn.ForeColor = Color.DarkViolet;
            newUserNameSaveBtn.Location = new Point(799, 218);
            newUserNameSaveBtn.Name = "newUserNameSaveBtn";
            newUserNameSaveBtn.Size = new Size(115, 45);
            newUserNameSaveBtn.TabIndex = 17;
            newUserNameSaveBtn.Text = "Save";
            newUserNameSaveBtn.UseVisualStyleBackColor = true;
            newUserNameSaveBtn.Click += newUserNameSaveBtn_Click;
            // 
            // confirmPasswordBx
            // 
            confirmPasswordBx.Anchor = AnchorStyles.None;
            confirmPasswordBx.Location = new Point(464, 498);
            confirmPasswordBx.Name = "confirmPasswordBx";
            confirmPasswordBx.PasswordChar = '*';
            confirmPasswordBx.Size = new Size(297, 38);
            confirmPasswordBx.TabIndex = 11;
            // 
            // newPasswordBx
            // 
            newPasswordBx.Anchor = AnchorStyles.None;
            newPasswordBx.Location = new Point(464, 406);
            newPasswordBx.Name = "newPasswordBx";
            newPasswordBx.PasswordChar = '*';
            newPasswordBx.Size = new Size(297, 38);
            newPasswordBx.TabIndex = 11;
            // 
            // oldPasswordBx
            // 
            oldPasswordBx.Anchor = AnchorStyles.None;
            oldPasswordBx.Location = new Point(464, 314);
            oldPasswordBx.Name = "oldPasswordBx";
            oldPasswordBx.PasswordChar = '*';
            oldPasswordBx.Size = new Size(297, 38);
            oldPasswordBx.TabIndex = 12;
            // 
            // newUserNameBx
            // 
            newUserNameBx.Anchor = AnchorStyles.None;
            newUserNameBx.Location = new Point(464, 222);
            newUserNameBx.Name = "newUserNameBx";
            newUserNameBx.Size = new Size(297, 38);
            newUserNameBx.TabIndex = 13;
            // 
            // confirmPassordLbl
            // 
            confirmPassordLbl.Anchor = AnchorStyles.None;
            confirmPassordLbl.AutoSize = true;
            confirmPassordLbl.Location = new Point(240, 501);
            confirmPassordLbl.Name = "confirmPassordLbl";
            confirmPassordLbl.Size = new Size(197, 31);
            confirmPassordLbl.TabIndex = 10;
            confirmPassordLbl.Text = "Confirm Password";
            // 
            // newPasswordLbl
            // 
            newPasswordLbl.Anchor = AnchorStyles.None;
            newPasswordLbl.AutoSize = true;
            newPasswordLbl.Location = new Point(275, 409);
            newPasswordLbl.Name = "newPasswordLbl";
            newPasswordLbl.Size = new Size(162, 31);
            newPasswordLbl.TabIndex = 8;
            newPasswordLbl.Text = "New Password";
            // 
            // oldPasswordLbl
            // 
            oldPasswordLbl.Anchor = AnchorStyles.None;
            oldPasswordLbl.AutoSize = true;
            oldPasswordLbl.Location = new Point(284, 317);
            oldPasswordLbl.Name = "oldPasswordLbl";
            oldPasswordLbl.Size = new Size(153, 31);
            oldPasswordLbl.TabIndex = 8;
            oldPasswordLbl.Text = "Old Password";
            // 
            // newUserNameLbl
            // 
            newUserNameLbl.Anchor = AnchorStyles.None;
            newUserNameLbl.AutoSize = true;
            newUserNameLbl.Location = new Point(310, 225);
            newUserNameLbl.Name = "newUserNameLbl";
            newUserNameLbl.Size = new Size(127, 31);
            newUserNameLbl.TabIndex = 7;
            newUserNameLbl.Text = "User Name";
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 808);
            Controls.Add(editProfileTabs);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "EditProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-xam - Edit Profile";
            editProfileTabs.ResumeLayout(false);
            personalInfoTab.ResumeLayout(false);
            personalInfoTab.PerformLayout();
            credentialsTab.ResumeLayout(false);
            credentialsTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl editProfileTabs;
        private TabPage personalInfoTab;
        private Button updateGenderBtn;
        private Button updateSsnBtn;
        private Button updateLastNameBtn;
        private TabPage credentialsTab;
        private RadioButton femaleBtn;
        private RadioButton maleBtn;
        private Button saveGenderBtn;
        private Button saveSsnBtn;
        private Button saveLastNameBtn;
        private Button saveFirstNameBtn;
        private TextBox ssnBx;
        private TextBox lastNameBx;
        private TextBox firstNameBx;
        private Label genderLbl;
        private Label ssnLbl;
        private Label lastNameLbl;
        private Label firstNameLbl;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button newUserNameSaveBtn;
        private TextBox newPasswordBx;
        private TextBox oldPasswordBx;
        private TextBox newUserNameBx;
        private Label confirmPassordLbl;
        private Label label2;
        private Label oldPasswordLbl;
        private Label newUserNameLbl;
        private TextBox confirmPasswordBx;
        private Button saveNewPasswordBtn;
        private Label newPasswordLbl;
    }
}