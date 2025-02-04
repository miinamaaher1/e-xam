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
            Student student = StudentManager.getStudent(Convert.ToInt32(studentIdBx.Text));

            if (student == null)
            {
                MessageBox.Show("Student Not Found!");
                return;
            }
            else
            {
                StudentStatsReportForm studentReport = new StudentStatsReportForm(student.id);

                // Subscribe to the FormClosed event
                studentReport.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Show();
                };
                this.Hide();
                studentReport.Show();
            }

        }
    }
}
