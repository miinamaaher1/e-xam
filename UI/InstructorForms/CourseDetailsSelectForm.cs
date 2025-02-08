using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;

namespace UI.InstructorForms
{
    public partial class CourseDetailsSelectForm : Form
    {
        bool isLoaded, hasCourses;
        int instId;
        CourseList courses;
        public CourseDetailsSelectForm(int _instId)
        {
            InitializeComponent();
            this.AcceptButton = viewTopicsBtn;
            instId = _instId;
        }

        private void ViewCourseTopicsForm_Load(object sender, EventArgs e)
        {

            isLoaded = false;
            courses = CourseManager.getInstructorCourses(instId);

            if (courses.Count == 0)
            {
                courseCombo.Items.Add("No Courses Available");
                courseCombo.SelectedIndex = 0;
                hasCourses = false;
            }
            else
            {
                courseCombo.DataSource = courses;
                courseCombo.DisplayMember = "Name";
                courseCombo.ValueMember = "id";
                courseCombo.SelectedIndex = -1;
                isLoaded = true;
                hasCourses = true;
            }
        }

        private void viewTopicsBtn_Click(object sender, EventArgs e)
        {
            if (!hasCourses)
            {
                MessageBox.Show("No Courses Available");
                return;
            }
            if (courseCombo.SelectedIndex != -1)
            {
                Course c = (Course)courseCombo.SelectedItem;

                CourseDetailsReportForm courseTopicsReportForm = new CourseDetailsReportForm(c.id, c.name);
                // Subscribe to the FormClosed event
                courseTopicsReportForm.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Show();
                };
                this.Hide();
                courseTopicsReportForm.Show();
            }
            else
                MessageBox.Show("No Course Selected!");
        }
    }
}
