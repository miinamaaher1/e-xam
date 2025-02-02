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
        int tfCount;
        int mcqCount;
        int courseId;
        int instrcutorId;

        public generateExamReportForm(int _examId,int _tfCount, int _mcqCount, int _courseId, int _instrcutorId )
        {
            examId = _examId;
            tfCount = _tfCount;
            mcqCount = _mcqCount;
            courseId = _courseId;
            instrcutorId = _instrcutorId;
            InitializeComponent();
        }

        private void generateExamReportForm_Load(object sender, EventArgs e)
        {


            generateExamRV.LocalReport.ReportPath = @"Reports\GenerateExamReport.rdlc";

            ReportParameter reportParameter = new ReportParameter("examId", examId.ToString());
            generateExamRV.LocalReport.SetParameters(reportParameter);
            RefreshReport();


        }
        private void RefreshReport()
        {
            DataTable mcqQuestions = QuestionsManager.getExamMcqQuestions(examId);

            DataTable TfQuestions = QuestionsManager.getExamTfQuestions(examId);

            generateExamRV.LocalReport.DataSources.Clear();

            ReportDataSource mcqQuestionsDataSource = new ReportDataSource("getExamMcqQuestionsDS1", mcqQuestions);
            generateExamRV.LocalReport.DataSources.Add(mcqQuestionsDataSource);

            ReportDataSource tfQuestionsDataSource = new ReportDataSource("getExamTfQuestionsDS1", TfQuestions);
            generateExamRV.LocalReport.DataSources.Add(tfQuestionsDataSource);
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
           int exId= ExamManager.generateAnotherExamQ(exam);
            if(exId==-1)
            {
                MessageBox.Show("Error in generating another Questions");
                return;
            }
            RefreshReport();
        }
    }
}
