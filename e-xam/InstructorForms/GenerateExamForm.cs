using BLL.Entities;
using BLL.EntityList;
using BLL.EntityLists;
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
    public partial class GenerateExamForm : Form
    {
        int instId;
        CourseList courses = null;
        int currentExamId;
        bool isLoaded;
        public GenerateExamForm(int _instId)
        {
            InitializeComponent();
            MsgLbl.Visible = false;
            instId = _instId;

        }

        private void GenerateExam_Load(object sender, EventArgs e)
        {
            isLoaded = false;

            courses = CourseManager.getInstructorCourses(instId);
            courseCombo.DataSource = courses;
            courseCombo.DisplayMember = "Name";
            courseCombo.ValueMember = "id";
            courseCombo.SelectedIndex = -1;
            mcqLblMsg.Visible = false;
            tfLblMsg.Visible = false;
            tfNumUpDown.Minimum = 0;
            mcqNumUpDown.Minimum = 0;
            tfNumUpDown.Maximum = 0;
            mcqNumUpDown.Maximum = 0;
            isLoaded = true;
        }

        private void courseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded)
                return;

            else if (courseCombo.SelectedIndex != -1)
            {
                tfLblMsg.Visible = false;
                mcqLblMsg.Visible =false;
                int crsId = (int)courseCombo.SelectedValue;
                SetMaxQuestionsCnt(crsId);

            }

        }

        private void SetMaxQuestionsCnt(int _crsId)
        {
            int tf = 0, mcq = 0;
            QuestionsManager.GetTfMcqCount(_crsId, out tf, out mcq);
            tfNumUpDown.Maximum = tf;
            mcqNumUpDown.Maximum = mcq;
            if (tf == 0)
            {
                tfLblMsg.Text = " There are no True/False Questions";
                tfLblMsg.Visible = true;
            }
            else
                tfLblMsg.Visible = false;
            if (mcq == 0)
            {
                tfLblMsg.Text = " There are no MCQ Questions";
                mcqLblMsg.Visible = true;
            }
            else
                mcqLblMsg.Visible = false;

        }

        private void generateExBtn_Click(object sender, EventArgs e)
        {
            string validateMsg = validateFormFields();
            if (validateMsg == null)
            {
                Exam exam = new Exam();

                exam.course = new Course() { id = (int)courseCombo.SelectedValue };

                exam.mcqCount = (int)mcqNumUpDown.Value;
                exam.tfCount = (int)tfNumUpDown.Value;
                exam.duration = (int)durationNumUpDown.Value;
                exam.title = tilteTxtBox.Text == "" ? "exam" : tilteTxtBox.Text;

                currentExamId = ExamManager.generateExam(exam);

                ///////////////////////////////

                generateExamReportForm insExamReport = new generateExamReportForm(currentExamId ,(int)courseCombo.SelectedValue,instId);
                insExamReport.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                this.Hide();
                insExamReport.Show();

                //////////////////////////////

                MsgLbl.Text = $"exam id:{currentExamId}";
                MsgLbl.Visible = true;

            }
            else
            {
                MsgLbl.Text = $"{validateMsg}";
                MsgLbl.Visible = true;
            }

        }

        private string validateFormFields()
        {
            if (courseCombo.SelectedIndex == -1)
                return "must select course";
            else if (tfNumUpDown.Value ==0&& mcqNumUpDown.Value == 0)
                return "must select  count of true/false or mcq questions";
            else if (durationNumUpDown.Value == 0)
                return "must determine count of mcq questions";

            else
                return null;
        }


    }
}
//exam11