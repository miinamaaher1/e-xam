using BLL.Entities;
using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;

namespace UI
{
    public partial class ReviewAnswersReportForm : Form
    {
        int examId;
        int studentId;
        public ReviewAnswersReportForm(int _studentId, int _examId)
        {
            examId = _examId;
            studentId = _studentId;

            InitializeComponent();
        }

        private void ReviewAnswersForm_Load(object sender, EventArgs e)
        {
            List<ReviewAnswers> answerSheetMCQ = AnswerManager.reviewStudentAnswers(examId, studentId, 'm');
            List<ReviewAnswers> answerSheetTF = AnswerManager.reviewStudentAnswers(examId, studentId, 't');

            reviewAnswersRV.LocalReport.ReportPath = @"Reports\ReviewAnswersReport.rdlc";

            ReportParameter studentIdParam = new ReportParameter("ex_id", studentId.ToString());
            ReportParameter examIdParam = new ReportParameter("std_id", examId.ToString());

            reviewAnswersRV.LocalReport.SetParameters(studentIdParam);
            reviewAnswersRV.LocalReport.SetParameters(examIdParam);

            ReportDataSource reviewAnswersMCQ = new ReportDataSource("ReviewAnswersMCQ", answerSheetMCQ);
            reviewAnswersRV.LocalReport.DataSources.Add(reviewAnswersMCQ);

            ReportDataSource reviewAnswersTF = new ReportDataSource("ReviewAnswersTF", answerSheetTF);
            reviewAnswersRV.LocalReport.DataSources.Add(reviewAnswersTF);

            reviewAnswersRV.RefreshReport();
        }
    }
}
