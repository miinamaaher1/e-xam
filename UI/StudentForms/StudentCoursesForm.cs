using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;

namespace UI
{
    public partial class StudentCoursesForm : Form
    {
        CourseList courselist;
        int studentid;
        string coursename;
        int trakid;
        public StudentCoursesForm(int _id, int _trakid)
        {
            studentid = _id;
            trakid = _trakid;
            coursename = default;
            courselist = CourseManager.getStudentCourses(studentid);
            InitializeComponent();
            loadcourses();
        }

        private void loadcourses()
        {
            courses.Controls.Clear();

            foreach (Course course in courselist)
            {

                Panel coursePanel = new Panel
                {
                    Size = new Size(1168, 65),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0, 0, 0, 20)
                };

                Label courseName = new Label
                {
                    Text = course.name,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14),
                    Location = new Point(30, 15),

                };


                Button btnCourse = new Button
                {
                    Text = "view",
                    ForeColor = Color.DarkViolet,
                    Size = new Size(115, 45),
                    Font = new Font("Segoe UI", 14),
                    Location = new Point(1030, 10),
                    Tag = new Course { id = course.id, name = course.name }

                };

                btnCourse.Click += viewCourse_Click;
                coursePanel.Controls.Add(courseName);
                coursePanel.Controls.Add(btnCourse);

                courses.Controls.Add(coursePanel);

            }
        }

        private void viewCourse_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null || clickedButton.Tag == null) return;
            else
            {
                Course course = (Course)clickedButton.Tag;

                StudentExamsForm studentExam = new StudentExamsForm(studentid, course.id, trakid, course.name);

                studentExam.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                this.Hide();

                studentExam.Show();
            }
        }
    }
}




