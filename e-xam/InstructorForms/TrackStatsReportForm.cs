using BLL.Entities;
using BLL.EntityManagers;
using Microsoft.Reporting.WinForms;

namespace e_xam
{
    public partial class TrackStatsReportForm : Form
    {
        private int instId;
        private int trackId;
        public TrackStatsReportForm(int _trackId, int _instId)
        {
            InitializeComponent();
            instId = _instId;
            trackId = _trackId;

        }

        private void TrackStatsForm_Load(object sender, EventArgs e)
        {

            List<TrackStatsRecord> trackReport = StudentManager.getStudentsByTrack(trackId);

            TrackStatsReportViewer.LocalReport.ReportPath = @"Reports\TrackReport.rdlc";

            ReportDataSource trackReportDataSource = new ReportDataSource("TrackStatDS", trackReport);

            TrackStatsReportViewer.LocalReport.DataSources.Add(trackReportDataSource);

            TrackStatsReportViewer.RefreshReport();

        }
    }
}
