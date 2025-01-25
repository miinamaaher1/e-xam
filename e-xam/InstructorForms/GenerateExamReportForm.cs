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
    public partial class generateExamReportForm : Form
    {
        int examId;
        int courseId;
        int instrcutorId;
        public generateExamReportForm(int _examId, int _courseId , int _instrcutorId)
        {
            examId = _examId;
            courseId = _courseId;
            instrcutorId = _instrcutorId;
            InitializeComponent();
        }

        private void generateExamReportForm_Load(object sender, EventArgs e)
        {
            DataTable mcqQuestions = QuestionsManager.getExamMcqQuestions(examId);



            DataTable TfQuestions = QuestionsManager.getExamTfQuestions(examId);

            generateExamRV.LocalReport.ReportPath = @"D:\repo\e-xam\e-xam\Reports\GenerateExamReport.rdlc";

            ReportParameter reportParameter = new ReportParameter("examId", examId.ToString());
            generateExamRV.LocalReport.SetParameters(reportParameter);
            generateExamRV.LocalReport.DataSources.Clear();

            ReportDataSource mcqQuestionsDataSource = new ReportDataSource("getExamMcqQuestionsDS1", mcqQuestions);
            generateExamRV.LocalReport.DataSources.Add(mcqQuestionsDataSource);

            ReportDataSource tfQuestionsDataSource = new ReportDataSource("getExamTfQuestionsDS1", TfQuestions);
            generateExamRV.LocalReport.DataSources.Add(tfQuestionsDataSource);
            generateExamRV.RefreshReport();

        }

        private void assignExamBtn_Click(object sender, EventArgs e)
        {
            AssignExamForm assignExamForm  = new AssignExamForm(examId,courseId,instrcutorId);

            // Subscribe to the FormClosed event
            assignExamForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            assignExamForm.Show();
        }
    }
}
