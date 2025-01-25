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

namespace e_xam
{
    public partial class InstructorClassesReport : Form
    {
        Instructor user;
        public InstructorClassesReport(Instructor _user)
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

            instructorClassesRV.LocalReport.ReportPath = @"Reports\InstructorClassReport.rdlc";

            ReportParameter instructorIdParam = new ReportParameter("id", user.id.ToString());

            instructorClassesRV.LocalReport.SetParameters(instructorIdParam);

            ReportDataSource instructorClassDataSource = new ReportDataSource("InstructorClassesDS", insClassList);

            instructorClassesRV.LocalReport.DataSources.Add(instructorClassDataSource);

            instructorClassesRV.RefreshReport();
        }
    }
}
