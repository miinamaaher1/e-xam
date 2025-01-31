using BLL.Entities;
using BLL.EntityManagers;

namespace e_xam
{
    public partial class SelectStudentExamForm : Form
    {
        int studentId;
        int courseId;
        public SelectStudentExamForm(int _studentId, int _courseId)
        {
            studentId = _studentId;
            courseId = _courseId;

            InitializeComponent();
        }

        private void SelectStudentExamForm_Load(object sender, EventArgs e)
        {
            List<Exam> exams = StudentManager.getStudentCourseExams(courseId, studentId);

            if (exams.Count == 0)
            {
                MessageBox.Show($"Student with ID {studentId} didn't take exams in course wit id {courseId}");
            }
            else
            {
                examBx.Items.Clear();
                examBx.DataSource = exams;
                examBx.DisplayMember = "ToString";
            }
        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            Exam exam = (Exam)examBx.SelectedItem;

            ReviewAnswersForm reviewAnswer = new ReviewAnswersForm(studentId, exam.id);

            reviewAnswer.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };

            this.Hide();
            reviewAnswer.Show();

        }
    }
}
