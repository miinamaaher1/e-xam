using BLL.Entities;
using BLL.EntityManagers;

namespace e_xam
{
    public partial class SelectStudentClassForm : Form
    {
        Instructor user;
        int selectedCourseId;
        public SelectStudentClassForm(Instructor _user)
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

            studentBx.DataSource = studentList;
            studentBx.DisplayMember = "ToString";

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)studentBx.SelectedItem;

            List<Exam> exams = StudentManager.getStudentCourseExams(selectedCourseId, selectedStudent.id);

            if (exams.Count == 0)
            {
                MessageBox.Show($"Student with ID {selectedStudent.id} didn't take exams in course wit id {selectedCourseId}");
            }
            else
            {
                SelectStudentExamForm stdExam = new SelectStudentExamForm(selectedStudent.id, selectedCourseId);

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
