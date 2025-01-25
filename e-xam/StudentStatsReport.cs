using BLL.Entities;
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

namespace e_xam
{
    public partial class StudentStatsReport : Form
    {
        public Student student;
        public StudentStatsReport(Student _student)
        {
            InitializeComponent();
            student = _student;
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            List<CourseReport> courseReportList = student.courseGrades
            .Select(course => new CourseReport
            {
                course_name = course.Key.name,
                total_grade = course.Value
            })
            .ToList();

            studentStatsRV.LocalReport.ReportPath = @"Reports\StudentReport.rdlc";

            ReportParameter studentIdParam = new ReportParameter("id", student.id.ToString());

            studentStatsRV.LocalReport.SetParameters(studentIdParam);

            ReportDataSource studentReportDataSource = new ReportDataSource("StudentStatsDS", courseReportList);

            studentStatsRV.LocalReport.DataSources.Add(studentReportDataSource);

            studentStatsRV.RefreshReport();
        }
    }
}