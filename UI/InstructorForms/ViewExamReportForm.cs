using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace UI.InstructorForms
{
    public partial class ViewExamReportForm : Form
    {
        int examId;
        int courseId;
        int instrcutorId;
        public ViewExamReportForm(int _examId, int _courseId, int _instrcutorId)
        {
            InitializeComponent();
            this.AcceptButton = assignExamBtn;
            examId = _examId;
            courseId = _courseId;
            instrcutorId = _instrcutorId;
        }
        private void DisplayExamReportForm_Load(object sender, EventArgs e)
        {
            string courseName, examTitle;
            int duration;
            ExamManager.getExamCourseTitle(examId, out courseName, out examTitle, out duration);
            displayExamRV.LocalReport.ReportPath = @"Reports\GenerateExamReport.rdlc";

            ReportParameter reportParameter = new ReportParameter("courseName", courseName);
            ReportParameter reportParameter2 = new ReportParameter("examTitle", examTitle);
            ReportParameter reportParameter3 = new ReportParameter("duration", duration.ToString());

            displayExamRV.LocalReport.SetParameters(reportParameter);
            displayExamRV.LocalReport.SetParameters(reportParameter2);
            displayExamRV.LocalReport.SetParameters(reportParameter3);

            RefreshReport();
        }

        private void RefreshReport()
        {
            DataTable mcQuestions = QuestionManager.getExamMcqQuestions(examId);

            DataTable tfQuestions = QuestionManager.getExamTfQuestions(examId);

            displayExamRV.LocalReport.DataSources.Clear();

            ReportDataSource mcQuestionsDS = new ReportDataSource("getExamMCQuestionsDS", mcQuestions);
            displayExamRV.LocalReport.DataSources.Add(mcQuestionsDS);

            ReportDataSource tfQuestionsDS = new ReportDataSource("getExamTFQuestionsDS", tfQuestions);
            displayExamRV.LocalReport.DataSources.Add(tfQuestionsDS);
            displayExamRV.RefreshReport();

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
    }
}
