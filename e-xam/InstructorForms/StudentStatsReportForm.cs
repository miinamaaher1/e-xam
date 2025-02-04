using BLL.Entities;
using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace e_xam
{
    public partial class StudentStatsReportForm : Form
    {
        private List<StudentStatsRecord> studentReports;
        private int studentId;
        public StudentStatsReportForm(int _studentId)
        {
            InitializeComponent();
            studentId = _studentId;
            studentReports = StudentManager.getStudentStats(Convert.ToInt32(_studentId));

        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            studentStatsRV.LocalReport.ReportPath = @"Reports\StudentReport.rdlc";

            ReportParameter studentIdParam = new ReportParameter("id", studentId.ToString());

            studentStatsRV.LocalReport.SetParameters(studentIdParam);

            ReportDataSource studentReportDataSource = new ReportDataSource("StudentStatsDS", studentReports);

            studentStatsRV.LocalReport.DataSources.Add(studentReportDataSource);

            studentStatsRV.RefreshReport();
        }
    }
}