using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace UI.InstructorForms
{
    public partial class CourseDetailsReportForm : Form
    {
        int courseId;
        string courseName;
        public CourseDetailsReportForm(int _courseId, string _courseName)
        {
            InitializeComponent();
            courseId = _courseId;
            courseName = _courseName;
        }

        private void CourseTopicsReportForm_Load(object sender, EventArgs e)
        {
            //List<string> topics = CourseManager.getCourseTopics(courseId);
            DataTable topics = CourseManager.getCourseTopics(courseId);
            CourseTopicsRV.LocalReport.ReportPath = @"Reports\CourseDetailsReport.rdlc";
            ReportParameter reportParameter = new ReportParameter("courseName", courseName);
            CourseTopicsRV.LocalReport.SetParameters(reportParameter);
            ReportDataSource reportDataSource = new ReportDataSource("CourseTopicsDS", topics);
            CourseTopicsRV.LocalReport.DataSources.Add(reportDataSource);
            CourseTopicsRV.RefreshReport();
        }
    }
}
