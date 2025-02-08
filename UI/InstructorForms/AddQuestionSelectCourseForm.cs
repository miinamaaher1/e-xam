using BLL.EntityManagers;

namespace UI
{
    public partial class AddQuestionSelectCourseForm : Form
    {
        private int inst_id;
        bool hasCourses;
        Dictionary<string, int> courses = new Dictionary<string, int>();

        public AddQuestionSelectCourseForm(int _inst_id)
        {
            InitializeComponent();
            this.AcceptButton = okBtn;
            inst_id = _inst_id;
            courses = CourseManager.getCoursesByInstId(inst_id);
            if (courses.Count == 0)
            {
                coursesComboBox.Items.Add("No Courses Available");
                coursesComboBox.SelectedIndex = 0;
                hasCourses = false;
            }
            else
            {
                foreach (var course in courses)
                {
                    coursesComboBox.Items.Add(course.Key);
                }
                coursesComboBox.SelectedIndex = 0;
                hasCourses = true;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!hasCourses)
            {
                MessageBox.Show("No Courses Available");
                return;
            }
            AddQuestionForm addQuestionForm = new AddQuestionForm(courses[coursesComboBox.Text], inst_id);

            // Subscribe to the FormClosed event
            addQuestionForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            addQuestionForm.Show();
        }
    }
}
