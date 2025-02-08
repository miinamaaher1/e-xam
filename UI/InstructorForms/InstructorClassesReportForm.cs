using BLL.Entities;
using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace UI
{
    public partial class InstructorClassesReportForm : Form
    {
        Instructor user;
        public InstructorClassesReportForm(Instructor _user)
        {
            user = _user;
            InitializeComponent();
        }

        private void InstructorClassesForm_Load(object sender, EventArgs e)
        {
            List<CourseInstructorTrack> crsInsTrk = InstructorManager.getInstructorClasses(user.id);

            List<InstructorClass> insClassList = crsInsTrk
           .Select(obj => new InstructorClass
           {
               course_name = obj.course.name,
               track_name = obj.track.name,
               student_numbers = obj.studentCount
           })
           .ToList();

            instructorClassesRV.LocalReport.ReportPath = @"Reports\InstructorClassesReport.rdlc";

            ReportParameter instructorIdParam = new ReportParameter("id", user.id.ToString());
            ReportParameter instructorNameParam = new ReportParameter("instructorName", user.firstName + " " + user.lastName);


            instructorClassesRV.LocalReport.SetParameters(instructorIdParam);
            instructorClassesRV.LocalReport.SetParameters(instructorNameParam);

            ReportDataSource instructorClassDataSource = new ReportDataSource("InstructorClassesDS", insClassList);

            instructorClassesRV.LocalReport.DataSources.Add(instructorClassDataSource);

            instructorClassesRV.RefreshReport();
        }
    }
}
