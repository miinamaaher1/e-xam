using BLL.Entities;
using BLL.EntityManagers;

namespace e_xam
{
    public partial class ReviewAnswersSelectExamForm : Form
    {
        int studentId;
        int courseId;
        public ReviewAnswersSelectExamForm(int _studentId, int _courseId)
        {
            studentId = _studentId;
            courseId = _courseId;

            InitializeComponent();
        }

        private void SelectStudentExamForm_Load(object sender, EventArgs e)
        {
            List<Exam> exams = StudentManager.getStudentCourseExams(courseId, studentId);

            examBx.Items.Clear();
            examBx.DataSource = exams;
            examBx.DisplayMember = "ToString";
        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            Exam exam = (Exam)examBx.SelectedItem;

            ReviewAnswersReportForm reviewAnswer = new ReviewAnswersReportForm(studentId, exam.id);

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
