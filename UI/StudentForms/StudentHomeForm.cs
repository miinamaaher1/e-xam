using BLL.Entities;
using BLL.EntityManagers;
using UI.SharedForms;

namespace UI
{
    public partial class StudentHomeForm : Form
    {
        Student user;
        public StudentHomeForm(int _userId)
        {
            InitializeComponent();
            user = StudentManager.getStudent(_userId);
            nameLbl.Text = user.firstName + " " + user.lastName;
            gpaLbl.Text = user.gpa.ToString();
            trackLbl.Text = user.track.dept.name + ", " + user.track.name;
        }

        private void exitItm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editProfileItm_Click(object sender, EventArgs e)
        {
            // insert the edit profile form here
            EditProfileForm editProfileForm = new EditProfileForm(user.id);
            editProfileForm.FormClosed += (s, args) =>
            {
                user = StudentManager.getStudent(user.id);
                nameLbl.Text = user.firstName + " " + user.lastName;
                this.Show();
            };
            this.Hide();
            editProfileForm.Show();
        }

        private void showCoursesItm_Click(object sender, EventArgs e)
        {
            // insert the show courses (course name and view button) form here

            StudentCoursesForm studentcourse = new StudentCoursesForm(user.id, user.track.id);
            studentcourse.FormClosed += (s, args) =>
            {
                user = StudentManager.getStudent(user.id);
                gpaLbl.Text = user.gpa.ToString();
                this.Show();
            };
            this.Hide();
            studentcourse.Show();

        }

        private void aboutItm_Click(object sender, EventArgs e)
        {
            // insert the about form here
            AboutForm aboutForm = new AboutForm();
            aboutForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            aboutForm.Show();
        }

        private void myStatsItem_Click(object sender, EventArgs e)
        {
            // insert the about form here
            StudentStatsReportForm myStatsForm = new StudentStatsReportForm(user.id);
            myStatsForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            myStatsForm.Show();
        }
    }
}
