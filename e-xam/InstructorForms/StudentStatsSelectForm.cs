using BLL.Entities;
using BLL.EntityManagers;

namespace e_xam
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
                Student student = StudentManager.getStudent(Convert.ToInt32(studentIdBx.Text));

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
