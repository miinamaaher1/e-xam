using BLL.Entities;
using BLL.EntityManagers;

namespace UI
{
    enum fields
    {
        first,
        last,
        ssn,
        gender,
        user,
        all
    }
    public partial class EditProfileForm : Form
    {
        User user;
        public EditProfileForm(int _id)
        {
            user = new User();
            user.id = _id;
            InitializeComponent();
            updateFields(fields.all);
        }

        private void saveFirstNameBtn_Click(object sender, EventArgs e)
        {
            if (UserManager.updateFirstName(user.id, firstNameBx.Text) > 0)
            {
                MessageBox.Show("First Name Updated Succesfully!");
            }
            else
            {
                MessageBox.Show("Couldn't Update First Name!");
            }
            updateFields(fields.first);
        }

        private void saveLastNameBtn_Click(object sender, EventArgs e)
        {
            if (UserManager.updateLastName(user.id, lastNameBx.Text) > 0)
            {
                MessageBox.Show("Last Name Updated Succesfully!");
            }
            else
            {
                MessageBox.Show("Couldn't Update Last Name!");
            }
            updateFields(fields.last);
        }

        private void saveSsnBtn_Click(object sender, EventArgs e)
        {
            if (UserManager.updateSSN(user.id, ssnBx.Text) > 0)
            {
                MessageBox.Show("SSN Updated Succesfully!");
            }
            else
            {
                MessageBox.Show("This SSN Isn't Available!");
            }
            updateFields(fields.ssn);
        }

        private void newUserNameSaveBtn_Click(object sender, EventArgs e)
        {
            if (UserManager.updateUserName(user.id, newUserNameBx.Text) > 0)
            {
                MessageBox.Show("User Name Updated Succesfully!");
            }
            else
            {
                MessageBox.Show("This User Name Isn't Available!");
            }
            updateFields(fields.user);
        }

        private void saveNewPasswordBtn_Click(object sender, EventArgs e)
        {
            if (newPasswordBx.Text != confirmPasswordBx.Text)
            {
                MessageBox.Show("New Password Doesn't Match Confirm Password!");
            }
            else if (UserManager.updatePassword(user.id, oldPasswordBx.Text, newPasswordBx.Text) > 0)
            {
                MessageBox.Show("Password Updated Succesfully!");
            }
            else
            {
                MessageBox.Show("Old Password Is Incorrect!");
            }
        }

        private void saveGenderBtn_Click(object sender, EventArgs e)
        {
            if (maleBtn.Checked == true)
            {
                if (UserManager.updateGender(user.id, 'm') > 0)
                {
                    MessageBox.Show("Gender Updated Succesfully!");
                }
                else
                {
                    MessageBox.Show("Couldn't Update Gender!");
                }
            }
            else
            {
                if (UserManager.updateGender(user.id, 'f') > 0)
                {
                    MessageBox.Show("Gender Updated Succesfully!");
                }
                else
                {
                    MessageBox.Show("Couldn't Update Gender!");
                }
            }
            updateFields(fields.gender);
        }
        private void updateFields(fields field)
        {
            user = UserManager.getUser(user.id);

            if (field == fields.first) firstNameBx.Text = user.firstName;

            else if (field == fields.last) lastNameBx.Text = user.lastName;

            else if (field == fields.ssn) ssnBx.Text = user.ssn;

            else if (field == fields.gender)
            {
                if (user.gender == 'm')
                {
                    maleBtn.Checked = true;
                }
                else
                {
                    femaleBtn.Checked = true;
                }
            }

            else if (field == fields.user) newUserNameBx.Text = user.userName;

            else if (field == fields.all)
            {
                firstNameBx.Text = user.firstName;
                lastNameBx.Text = user.lastName;
                ssnBx.Text = user.ssn;
                if (user.gender == 'm')
                {
                    maleBtn.Checked = true;
                }
                else
                {
                    femaleBtn.Checked = true;
                }
                newUserNameBx.Text = user.userName;
            }
        }
    }
}
