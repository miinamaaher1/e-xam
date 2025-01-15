using BLL.Entities;
using BLL.EntityManagers;
using System.Data;


namespace e_xam
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user = UserManager.login(userNameBx.Text, passwordBx.Text);

            if (user.id == 0)
            {
                MessageBox.Show("Invalid username or password");
                return;
            } else if (user.type == 's')
            {
                Student student = StudentManager.getStudent(user.id);
                MessageBox.Show("Welcome " + student.firstName + " " + student.lastName);
                // this.Hide();
                // new StudentForm(conn, student).Show();
            }
            else
            {
                Instructor instructor = InstructorManager.getInstructor(user.id);
                MessageBox.Show("Welcome " + instructor.firstName + " " + instructor.lastName);
                // this.Hide();
                // new InstructorForm(conn, instructor).Show();
            }
        }
    }
}
