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
    public partial class TrackStatsForm : Form
    {
        private int instId;
        private int trackId;
        public TrackStatsForm(int _trackId, int _instId)
        {
            InitializeComponent();
            instId = _instId;
            trackId = _trackId;

        }

        private void TrackStatsForm_Load(object sender, EventArgs e)
        {

            List<TrackReport> trackReport = StudentManager.getStudentsByTrack(trackId);

           // List<InstructorClass> insClassList = crsInsTrk
           //.Select(obj => new InstructorClass
           //{
           //    course_name = obj.course.name,
           //    track_name = obj.track.name,
           //    student_numbers = obj.studentCount
           //})
           //.ToList();

            TrackStatsReportViewer.LocalReport.ReportPath = @"C:\Users\Ahmed_Yasser\source\repos\miinamaaher1\e-xam\e-xam\Reports\TrackReport.rdlc";

            //ReportParameter instructorIdParam = new ReportParameter("id", user.id.ToString());

            //instructorClassesRV.LocalReport.SetParameters(instructorIdParam);

            ReportDataSource trackReportDataSource = new ReportDataSource("TrackStatDS", trackReport);

            TrackStatsReportViewer.LocalReport.DataSources.Add(trackReportDataSource);

            TrackStatsReportViewer.RefreshReport();

        }
    }
}
