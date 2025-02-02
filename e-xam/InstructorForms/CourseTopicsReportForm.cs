using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace e_xam.InstructorForms
{
    public partial class CourseTopicsReportForm : Form
    {
        int courseId;
        string courseName;
        public CourseTopicsReportForm(int _courseId, string _courseName)
        {
            InitializeComponent();
            courseId = _courseId;
            courseName = _courseName;
        }

        private void CourseTopicsReportForm_Load(object sender, EventArgs e)
        {
            //List<string> topics = CourseManager.getCourseTopics(courseId);
            DataTable topics = CourseManager.getCourseTopics(courseId);
            CourseTopicsRV.LocalReport.ReportPath = @"Reports\CourseTopicsReport.rdlc";
            ReportParameter reportParameter = new ReportParameter("courseName", courseName);
            CourseTopicsRV.LocalReport.SetParameters(reportParameter);
            ReportDataSource reportDataSource = new ReportDataSource("CourseTopicsDS1", topics);
            CourseTopicsRV.LocalReport.DataSources.Add(reportDataSource);
            CourseTopicsRV.RefreshReport();
        }
    }
}
