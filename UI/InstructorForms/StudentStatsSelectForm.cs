using BLL.Entities;
using BLL.EntityManagers;

namespace UI
{
    public partial class StudentStatsSelectForm : Form
    {
        public StudentStatsSelectForm()
        {
            InitializeComponent();
            this.AcceptButton = viewBtn;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentIdBx.Text))
            {
                MessageBox.Show("Please enter a student ID.");
            }
            else
            {
                int studId;
                if (!Int32.TryParse(studentIdBx.Text, out studId))
                {
                    MessageBox.Show("Enter a valid ID!");
                    return;
                }

                Student student = StudentManager.getStudent(studId);

                if (student == null)
                {
                    MessageBox.Show("Student Not Found!");
                    return;
                }
                else
                {
                    StudentStatsReportForm studentReport = new StudentStatsReportForm(student.id);

                    studentReport.FormClosed += (s, args) =>
                    {
                        this.Show();
                    };
                    this.Hide();
                    studentReport.Show();
                }
            }

        }
    }
}
