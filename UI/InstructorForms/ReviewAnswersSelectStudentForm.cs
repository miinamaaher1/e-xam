using BLL.Entities;
using BLL.EntityManagers;

namespace UI
{
    public partial class ReviewAnswersSelectStudentForm : Form
    {
        Instructor user;
        int selectedCourseId;
        bool hasClasses, hasStudents;

        public ReviewAnswersSelectStudentForm(Instructor _user)
        {
            user = _user;
            InitializeComponent();
            this.AcceptButton = nextBtn;
        }

        private void SelectStudentClassForm_Load(object sender, EventArgs e)
        {
            var instructorClasses = InstructorManager.getInstructorClasses(user.id);
            hasClasses = instructorClasses.Count > 0;

            classBx.Items.Clear();
            studentBx.Items.Clear();

            if (hasClasses)
            {
                classBx.DataSource = instructorClasses;
            }
            else
            {
                classBx.Items.Add("No Classes Available");
                classBx.SelectedIndex = 0;

                studentBx.Items.Add("No Students Available");
                studentBx.SelectedIndex = 0;
            }
        }

        private void classBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!hasClasses) return;

            var selectedClass = classBx.SelectedItem as CourseInstructorTrack;

            selectedCourseId = selectedClass.course.id;

            List<Student> studentList = InstructorManager.getTrackStudents(selectedClass.track.id);

            if (studentList.Count > 0)
            {
                studentBx.DataSource = studentList;

                hasStudents = true;
            }
            else
            {
                studentBx.Items.Add("No Students Available");
                studentBx.SelectedIndex = 0;

                hasStudents = false;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (!hasClasses)
            {
                MessageBox.Show("No Classes Or Students Available");
                return;
            }

            else if (!hasStudents)
            {
                MessageBox.Show("No Students Available");
                return;
            }

            var selectedStudent = studentBx.SelectedItem as Student;

            var exams = StudentManager.getStudentCourseExams(selectedCourseId, selectedStudent.id);

            if (exams.Count == 0)
            {
                MessageBox.Show("This student didn't take exams in this course!");
                return;
            }

            var stdExam = new ReviewAnswersSelectExamForm(selectedStudent.id, selectedCourseId);
            stdExam.FormClosed += (s, args) => this.Show();
            this.Hide();
            stdExam.Show();
        }
    }
}
