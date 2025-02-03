using BLL.Entities;
using BLL.EntityManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_xam.InstructorForms
{
    public partial class SelectExamForm : Form
    {
        int instructorId;
        bool isLoaded;
        //BindingList<int> ExamsId;

        public SelectExamForm(int _instructorId)
        {
            InitializeComponent();
            instructorId = _instructorId;
            isLoaded = false;
            //ExamsId = new BindingList<int>();
        }

        private void SelectExamForm_Load(object sender, EventArgs e)
        {
            isLoaded = false;

            coursesCombo.DataSource = CourseManager.getInstructorCourses(instructorId);
            coursesCombo.DisplayMember = "name";
            coursesCombo.ValueMember = "id";
            coursesCombo.SelectedIndex = -1;

            //ExamsCombo.DataSource = ExamsId;
            isLoaded = true;

        }

        private void coursesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded && coursesCombo.SelectedIndex != -1)
            {
                ExamsCombo.DataSource = null;
                List<int> examsId = ExamManager.GetExamsIdByCrsId((int)coursesCombo.SelectedValue);
                if (examsId.Count == 0)
                    MessageBox.Show($"there is no exams for Course {((Course)coursesCombo.SelectedItem).name}");
                else
                {
                    ExamsCombo.DataSource = examsId;
                    ExamsCombo.SelectedIndex = -1;

                }
            }
        }

        private void getExamBtn_Click(object sender, EventArgs e)
        {
            if (coursesCombo.SelectedIndex == -1)
            {
                MessageBox.Show("must select Course");
                return;
            }
            else if (ExamsCombo.SelectedIndex == -1)
            {
                MessageBox.Show("must select Exam ID");
                return;
            }
            else///////////////////////////////////////////////call form
            {
                DisplayExamReportForm  displayExamReport = new DisplayExamReportForm((int)ExamsCombo.SelectedValue, (int)coursesCombo.SelectedValue,instructorId);
                displayExamReport.FormClosed += (s, args) =>
                {
                    this.Close();
                };
                this.Hide();
                displayExamReport.Show(); ;
            }


        }
    }
}
