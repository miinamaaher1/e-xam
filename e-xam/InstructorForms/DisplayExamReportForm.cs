using BLL.Entities;
using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;
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
    public partial class DisplayExamReportForm : Form
    {
        int examId;
        int courseId;
        int instrcutorId;
        public DisplayExamReportForm(int _examId,int _courseId,int _instrcutorId)
        {
            InitializeComponent();
            examId = _examId;
            courseId = _courseId;
            instrcutorId = _instrcutorId;
        }
        private void DisplayExamReportForm_Load(object sender, EventArgs e)
        {
            string courseName, examTitle;
            int duration;
            ExamManager.getExamCourseTitle(examId, out courseName, out examTitle , out duration);
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
            DataTable mcqQuestions = QuestionsManager.getExamMcqQuestions(examId);

            DataTable TfQuestions = QuestionsManager.getExamTfQuestions(examId);

            displayExamRV.LocalReport.DataSources.Clear();

            ReportDataSource mcqQuestionsDataSource = new ReportDataSource("getExamMcqQuestionsDS1", mcqQuestions);
            displayExamRV.LocalReport.DataSources.Add(mcqQuestionsDataSource);

            ReportDataSource tfQuestionsDataSource = new ReportDataSource("getExamTfQuestionsDS1", TfQuestions);
            displayExamRV.LocalReport.DataSources.Add(tfQuestionsDataSource);
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
