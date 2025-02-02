using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace e_xam.InstructorForms
{
    public partial class CourseTopicsReportForm : Form
    {
        int courseId;
        public CourseTopicsReportForm(int _courseId)
        {
            InitializeComponent();
            courseId = _courseId;
        }

        private void CourseTopicsReportForm_Load(object sender, EventArgs e)
        {
            //List<string> topics = CourseManager.getCourseTopics(courseId);
            DataTable topics = CourseManager.getCourseTopics(courseId);
            CourseTopicsRV.LocalReport.ReportPath = @"Reports\CourseTopicsReport.rdlc";
            ReportParameter reportParameter = new ReportParameter("crsId", courseId.ToString());
            CourseTopicsRV.LocalReport.SetParameters(reportParameter);
            ReportDataSource reportDataSource = new ReportDataSource("CourseTopicsDS1", topics);
            CourseTopicsRV.LocalReport.DataSources.Add(reportDataSource);
            CourseTopicsRV.RefreshReport();
        }
    }
}
