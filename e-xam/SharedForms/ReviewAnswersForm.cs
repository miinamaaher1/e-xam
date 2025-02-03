using BLL.Entities;
using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;

namespace e_xam
{
    public partial class ReviewAnswersForm : Form
    {
        StudentExam std_exam;
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
            std_exam = InstructorManager.reviewStudentAnswers(examId, studentId);
            List<ReviewAnswer> reviewAns = new List<ReviewAnswer>();

            foreach (Question question in std_exam.exam.questions)
            {
                if (question.type == 'm')
                {
                    foreach (Option option in question.options)
                    {
                        reviewAns.Add
                         (
                               new ReviewAnswer
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
                            new ReviewAnswer
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
                            new ReviewAnswer
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

            reviewAns[0].first_name = std_exam.student.firstName;
            reviewAns[0].last_name = std_exam.student.lastName;
            reviewAns[0].score = std_exam.grade;

            reviewAnswersRV.LocalReport.ReportPath = @"Reports\ReviewAnswersReport.rdlc";

            ReportParameter studentIdParam = new ReportParameter("ex_id",studentId.ToString());
            ReportParameter examIdParam = new ReportParameter("std_id", examId.ToString());

            reviewAnswersRV.LocalReport.SetParameters(studentIdParam);
            reviewAnswersRV.LocalReport.SetParameters(examIdParam);

            ReportDataSource reviewAnswersDataSource = new ReportDataSource("ReviewAnswersDS", reviewAns);

            reviewAnswersRV.LocalReport.DataSources.Add(reviewAnswersDataSource);

            reviewAnswersRV.RefreshReport();
        }
    }
}
