using BLL.Entities;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace e_xam
{
    public partial class StudentStatsReport : Form
    {
        public Student student;
        public StudentStatsReport(Student _student)
        {
            student = _student;
            InitializeComponent();
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            List<StudentReport> studentReports = student.courseGrades
            .Select(course => new StudentReport
            {
                course_name = course.Key.name,
                total_grade = course.Value
            })
            .ToList();

            studentReports[0].first_name = student.firstName;
            studentReports[0].last_name = student.lastName;
            studentReports[0].gpa = (decimal)student.gpa;

            studentStatsRV.LocalReport.ReportPath = @"Reports\StudentReport.rdlc";

            ReportParameter studentIdParam = new ReportParameter("id", student.id.ToString());

            studentStatsRV.LocalReport.SetParameters(studentIdParam);

            ReportDataSource studentReportDataSource = new ReportDataSource("StudentStatsDS", studentReports);

            studentStatsRV.LocalReport.DataSources.Add(studentReportDataSource);

            studentStatsRV.RefreshReport();
        }
    }
}