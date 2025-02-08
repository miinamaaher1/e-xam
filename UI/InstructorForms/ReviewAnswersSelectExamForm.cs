using BLL.Entities;
using BLL.EntityManagers;

namespace UI
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
            this.AcceptButton = reviewBtn;
        }

        private void SelectStudentExamForm_Load(object sender, EventArgs e)
        {
            List<Exam> exams = StudentManager.getStudentCourseExams(courseId, studentId);

            examBx.Items.Clear();
            examBx.DataSource = exams;
        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {

            Exam exam = (Exam)examBx.SelectedItem;

            ReviewAnswersReportForm reviewAnswer = new ReviewAnswersReportForm(studentId, exam.id);

            reviewAnswer.FormClosed += (s, args) =>
            {
                this.Show();
            };

            this.Hide();
            reviewAnswer.Show();

        }
    }
}
