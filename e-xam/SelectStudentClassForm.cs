using BLL.Entities;
using BLL.EntityManagers;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            //studentBx.Items.Clear();
            //studentBx.Text = " ";

            studentBx.DataSource = studentList;
            studentBx.DisplayMember = "ToString";

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)studentBx.SelectedItem;

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
