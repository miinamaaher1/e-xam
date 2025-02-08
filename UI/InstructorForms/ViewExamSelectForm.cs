using BLL.Entities;
using BLL.EntityManagers;

namespace UI.InstructorForms
{
    public partial class ViewExamSelectForm : Form
    {
        int instructorId;
        bool isLoaded, hasCourses, hasExams;

        public ViewExamSelectForm(int _instructorId)
        {
            InitializeComponent();
            this.AcceptButton = getExamBtn;
            instructorId = _instructorId;
            isLoaded = false;
        }

        private void SelectExamForm_Load(object sender, EventArgs e)
        {
            isLoaded = false;

            List<Course> courses = CourseManager.getInstructorCourses(instructorId);

            if (courses.Count > 0)
            {
                coursesCombo.DataSource = CourseManager.getInstructorCourses(instructorId);
                coursesCombo.DisplayMember = "name";
                coursesCombo.ValueMember = "id";
                coursesCombo.SelectedIndex = -1;

                isLoaded = true;
                hasCourses = true;
            }
            else
            {
                coursesCombo.Items.Add("No Courses Available");
                coursesCombo.SelectedIndex = 0;

                ExamsCombo.Items.Add("No Exams Available");
                ExamsCombo.SelectedIndex = 0;

                hasExams = false;
                isLoaded = false;
                hasCourses = false;
            }

        }

        private void coursesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded && coursesCombo.SelectedIndex != -1)
            {
                ExamsCombo.DataSource = null;
                List<int> examsId = ExamManager.GetExamsIdByCrsId((int)coursesCombo.SelectedValue);

                if (examsId.Count == 0)
                {
                    MessageBox.Show($"there is no exams for Course {((Course)coursesCombo.SelectedItem).name}");

                    ExamsCombo.Items.Add("No Exams Available");
                    ExamsCombo.SelectedIndex = 0;
                    hasExams = false;
                }

                else
                {
                    ExamsCombo.DataSource = examsId;
                    ExamsCombo.SelectedIndex = -1;
                    hasExams = true;

                }
            }
        }

        private void getExamBtn_Click(object sender, EventArgs e)
        {
            if (!hasCourses)
            {
                MessageBox.Show("No Courses Available");
                return;
            }
            else if (!hasExams)
            {
                MessageBox.Show("No Exams Available");
                return;
            }
            else if (coursesCombo.SelectedIndex == -1)
            {
                MessageBox.Show("must select Course");
                return;
            }
            else if (ExamsCombo.SelectedIndex == -1)
            {
                MessageBox.Show("must select Exam ID");
                return;
            }
            else ///call form
            {
                ViewExamReportForm displayExamReport = new ViewExamReportForm((int)ExamsCombo.SelectedValue, (int)coursesCombo.SelectedValue, instructorId);
                displayExamReport.FormClosed += (s, args) =>
                {
                    this.Close();
                };
                this.Hide();
                displayExamReport.Show(); ;
            }


        }
    }
}
