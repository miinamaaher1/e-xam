using BLL.Entities;
using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;

namespace e_xam
{
    public partial class ReviewAnswersForm : Form
    {
        Exam exam;
        int examId;
        int studentId;
        public ReviewAnswersForm(int _studentId, int _examId)
        {
            examId = _examId;
            studentId = _studentId;

            InitializeComponent();
        }

        private void ReviewAnswersForm_Load(object sender, EventArgs e)
        {
            exam = InstructorManager.reviewStudentAnswers(examId, studentId);
            List<ReviewAnswers> reviewAns = new List<ReviewAnswers>();

            foreach (Question question in exam.questions)
            {
                if (question.type == 'm')
                {
                    foreach (Option option in question.options)
                    {
                        reviewAns.Add
                         (
                               new ReviewAnswers
                               {
                                   Option = (char)option.num,
                                   OptionBody = option.body,
                                   Question = question.body,
                                   StudentAnswer = question.selectedAns,
                                   RightAnswer = question.ans

                               }
                         );
                    }
                  
                }
                else if(question.type == 't')
                {
                    reviewAns.Add
                    (
                            new ReviewAnswers
                            {
                                Option = '1',
                                OptionBody = "True",
                                Question = question.body,
                                StudentAnswer = question.selectedAns,
                                RightAnswer = question.ans
                            }
                    );

                    reviewAns.Add
                    (
                            new ReviewAnswers
                            {
                                Option = '2',
                                OptionBody = "False",
                                Question = question.body,
                                StudentAnswer = question.selectedAns,
                                RightAnswer = question.ans

                            }
                    );
                }
            }

            reviewAnswersRV.LocalReport.ReportPath = @"Reports\ReviewAnswersReport.rdlc";

            ReportParameter studentIdParam = new ReportParameter("ex_id",studentId.ToString());
            ReportParameter examIdParam = new ReportParameter("std_id", exam.id.ToString());

            reviewAnswersRV.LocalReport.SetParameters(studentIdParam);
            reviewAnswersRV.LocalReport.SetParameters(examIdParam);

            ReportDataSource reviewAnswersDataSource = new ReportDataSource("ReviewAnswersDS", reviewAns);

            reviewAnswersRV.LocalReport.DataSources.Add(reviewAnswersDataSource);

            reviewAnswersRV.RefreshReport();
        }
    }
}
