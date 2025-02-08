using BLL.Entities;
using BLL.EntityManagers;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = loginBtn;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user = UserManager.login(userNameBx.Text, passwordBx.Text);

            if (user.id == 0)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }
            else if (user.type == 's')
            {
                StudentHomeForm studentHome = new StudentHomeForm(user.id);

                // Subscribe to the FormClosed event
                studentHome.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Close();
                };
                this.Hide();
                studentHome.Show();
            }
            else
            {
                InstructorHomeForm instructorHome = new InstructorHomeForm(user.id);

                // Subscribe to the FormClosed event
                instructorHome.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Close();
                };
                this.Hide();
                instructorHome.Show();
            }
        }
    }
}
