using BLL.Entities;
using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace UI.InstructorForms
{
    public partial class generateExamReportForm : Form
    {
        int examId;
        int tfCount;
        int mcqCount;
        int courseId;
        int instrcutorId;

        public generateExamReportForm(int _examId, int _tfCount, int _mcqCount, int _courseId, int _instrcutorId)
        {
            examId = _examId;
            tfCount = _tfCount;
            mcqCount = _mcqCount;
            courseId = _courseId;
            instrcutorId = _instrcutorId;
            InitializeComponent();
            this.AcceptButton = assignExamBtn;
        }

        private void generateExamReportForm_Load(object sender, EventArgs e)
        {
            string courseName, examTitle;
            int duration;
            ExamManager.getExamCourseTitle(examId, out courseName, out examTitle, out duration);
            generateExamRV.LocalReport.ReportPath = @"Reports\GenerateExamReport.rdlc";

            ReportParameter reportParameter = new ReportParameter("courseName", courseName);
            ReportParameter reportParameter2 = new ReportParameter("examTitle", examTitle);
            ReportParameter reportParameter3 = new ReportParameter("duration", duration.ToString());

            generateExamRV.LocalReport.SetParameters(reportParameter);
            generateExamRV.LocalReport.SetParameters(reportParameter2);
            generateExamRV.LocalReport.SetParameters(reportParameter3);

            RefreshReport();


        }
        private void RefreshReport()
        {
            DataTable mcQuestions = QuestionManager.getExamMcqQuestions(examId);

            DataTable tfQuestions = QuestionManager.getExamTfQuestions(examId);

            generateExamRV.LocalReport.DataSources.Clear();

            ReportDataSource mcQuestionsDS = new ReportDataSource("getExamMCQuestionsDS", mcQuestions);
            generateExamRV.LocalReport.DataSources.Add(mcQuestionsDS);

            ReportDataSource tfQuestionsDS = new ReportDataSource("getExamTFQuestionsDS", tfQuestions);
            generateExamRV.LocalReport.DataSources.Add(tfQuestionsDS);
            generateExamRV.RefreshReport();

        }
        private void assignExamBtn_Click(object sender, EventArgs e)
        {
            AssignExamForm assignExamForm = new AssignExamForm(examId, courseId, instrcutorId);

            // Subscribe to the FormClosed event
            assignExamForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Close();
            };
            this.Hide();
            assignExamForm.Show();
        }

        private void generateAnotherQBtn_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam
            {
                id = examId,
                course = new Course { id = courseId },
                mcqCount = mcqCount,
                tfCount = tfCount
            };
            int exId = ExamManager.generateAnotherExamQ(exam);
            if (exId == -1)
            {
                MessageBox.Show("Error in generating another Questions");
                return;
            }
            RefreshReport();
        }
    }
}
