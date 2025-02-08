using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;

namespace UI.InstructorForms
{
    public partial class GenerateExamForm : Form
    {
        int instId;
        CourseList courses = null;
        int currentExamId;
        bool isLoaded, hasCourses;
        public GenerateExamForm(int _instId)
        {
            InitializeComponent();
            this.AcceptButton = generateExBtn;
            instId = _instId;

        }

        private void GenerateExam_Load(object sender, EventArgs e)
        {
            isLoaded = false;

            courses = CourseManager.getInstructorCourses(instId);

            if (courses.Count == 0)
            {
                courseCombo.Items.Add("No Courses Available");
                courseCombo.SelectedIndex = 0;
                hasCourses = false;
            }
            else
            {
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
                hasCourses = true;
            }
        }

        private void courseCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded)
                return;

            else if (courseCombo.SelectedIndex != -1)
            {
                tfLblMsg.Visible = false;
                mcqLblMsg.Visible = false;
                int crsId = (int)courseCombo.SelectedValue;
                SetMaxQuestionsCnt(crsId);

            }

        }

        private void SetMaxQuestionsCnt(int _crsId)
        {
            int tf = 0, mcq = 0;
            QuestionManager.GetTfMcqCount(_crsId, out tf, out mcq);
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
            if (!hasCourses)
            {
                MessageBox.Show("No Courses Available");
                return;
            }

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
                if (currentExamId == -1)
                {
                    MessageBox.Show("Error in generating exam");
                    return;
                }

                ///////////////////////////////

                generateExamReportForm insExamReport = new generateExamReportForm(currentExamId, exam.tfCount, exam.mcqCount, (int)courseCombo.SelectedValue, instId);
                insExamReport.FormClosed += (s, args) =>
                {
                    this.Close();
                };
                this.Hide();
                insExamReport.Show();

            }
            else
            {
                MessageBox.Show($"{validateMsg}");
            }

        }

        private string validateFormFields()
        {
            if (courseCombo.SelectedIndex == -1)
                return "must select a course";
            else if (tfNumUpDown.Value == 0 && mcqNumUpDown.Value == 0)
                return "must select  count of true/false or mcq questions";
            else if (durationNumUpDown.Value == 0)
                return "duration must be a positive number";
            else
                return null;
        }

    }
}
//exam11