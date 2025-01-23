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
        TrackList trackList = null;
        DateTime oldDate = new DateTime(1999, 1, 1);
        int currentExamId;
        bool isLoaded;
        public GenerateExamForm(int _instId)
        {
            InitializeComponent();
            MsgLbl.Visible=false;
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
            isLoaded = true;
        }

        private void generateExBtn_Click(object sender, EventArgs e)
        {
            string validateMsg = validateFormFields();
            if (validateMsg == null) { 
                Exam exam = new Exam();

                exam.course = new Course() { id = (int)courseCombo.SelectedValue };

                exam.mcqCount = (int)mcqNumUpDown.Value;
                exam.tfCount = (int)tfNumUpDown.Value;
                exam.duration=(int)durationNumUpDown.Value;
                exam.title = tilteTxtBox.Text == "" ? "exam" : tilteTxtBox.Text;

                currentExamId = ExamManager.generateExam(exam);
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

            else if (mcqNumUpDown.Value == 0)
                return "must determine count of mcq questions";
            else if (tfNumUpDown.Value == 0)
                return "must determine count of true/false questions";
            else if (durationNumUpDown.Value == 0)
                return "must determine count of mcq questions";

            else
                return null;
        }

    }
}
//exam11