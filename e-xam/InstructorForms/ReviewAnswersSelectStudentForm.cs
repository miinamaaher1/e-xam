using BLL.Entities;
using BLL.EntityManagers;

namespace e_xam
{
    public partial class ReviewAnswersSelectStudentForm : Form
    {
        Instructor user;
        int selectedCourseId;
        public ReviewAnswersSelectStudentForm(Instructor _user)
        {
            user = _user;
            InitializeComponent();
        }

        private void SelectStudentClassForm_Load(object sender, EventArgs e)
        {
            List<CourseInstructorTrack> instructorClasses = InstructorManager.getInstructorClasses(user.id);

            classBx.Items.Clear();
            classBx.DataSource = instructorClasses;
            classBx.DisplayMember = "ToString";

        }
        private void classBx_SelectedIndexChanged(object sender, EventArgs e)
        {

            CourseInstructorTrack selectedClass = (CourseInstructorTrack)classBx.SelectedItem;

            int selectedTrack = selectedClass.track.id;
            selectedCourseId = selectedClass.course.id;

            List<Student> studentList = InstructorManager.getTrackStudents(selectedTrack);

            //studentBx.Items.Clear();
            //studentBx.Text = " ";

            studentBx.DataSource = studentList;
            studentBx.DisplayMember = "ToString";

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)studentBx.SelectedItem;

            List<Exam> exams = StudentManager.getStudentCourseExams(selectedCourseId, selectedStudent.id);

            if (exams.Count == 0)
            {
                MessageBox.Show($"This Student didn't take exams in this course!");
            }
            else
            {
                ReviewAnswersSelectExamForm stdExam = new ReviewAnswersSelectExamForm(selectedStudent.id, selectedCourseId);

                stdExam.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Show();
                };
                this.Hide();
                stdExam.Show();
            }
        }
    }
}
