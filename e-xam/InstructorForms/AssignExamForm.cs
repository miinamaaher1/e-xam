using BLL.Entities;
using BLL.EntityList;
using BLL.EntityLists;
using BLL.EntityManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_xam.InstructorForms
{
    public partial class AssignExamForm : Form
    {
        int examId;
        int courseId;
        int instructorId;
        TrackList tracks;
        string format = "MM/dd/yyyy hh:mm tt";
        public AssignExamForm(int _examId, int _courseId, int _instructorId)
        {
            examId = _examId;
            courseId = _courseId;
            instructorId = _instructorId;
            InitializeComponent();
        }

        private void AssignExamForm_Load(object sender, EventArgs e)
        {
            SetupDataGridViewCols();
            tracks = TrackManager.getInstructorTracksInCrs(instructorId, courseId);
            foreach (var track in tracks)
                AssignExamGV.Rows.Add(track.name, false, DateTime.Now.Date, DateTime.Now.Date);


        }

        void SetupDataGridViewCols()
        {
            var trackNameCol = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Track Name",
                Name = "trackName",
                ReadOnly = true,
            };
            var selectCol = new DataGridViewCheckBoxColumn()
            {
                HeaderText = "select",
                Name = "selectTrack"
            };

            var examStartDateCols = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Exam start date",
                Name = "startDate",
               // ValueType = typeof(DateTime),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = format
                } 
            };
            var examEndDateCols = new DataGridViewTextBoxColumn()
            {
                HeaderText = "Exam end date",
                Name = "endDate",
               // ValueType = typeof(DateTime),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = format
                }
            };
            AssignExamGV.Columns.Add(trackNameCol);
            AssignExamGV.Columns.Add(selectCol);
            AssignExamGV.Columns.Add(examStartDateCols);
            AssignExamGV.Columns.Add(examEndDateCols);

        }

        private void saveExamTracksBtn_Click(object sender, EventArgs e)
        {
            TrackExamList trackExams  = new TrackExamList();
            foreach (DataGridViewRow row in AssignExamGV.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["selectTrack"].Value);
                if (isSelected)
                {
                    TrackExam trackExam = new TrackExam();
                    trackExam.examId = examId;
                    string trackName = row.Cells["trackName"].Value.ToString();
                    trackExam.trackId= tracks.First(t => t.name == trackName).id;

                    string sDateStr = row.Cells["startDate"].Value.ToString();
                    string eDateStr = row.Cells["endDate"].Value.ToString();

                    DateTime sDate , eDate;
                    if (!validateDte(sDateStr, out sDate) || !validateDte(sDateStr, out eDate))
                        return;

                    trackExam.startDate = sDate;
                    trackExam.endDate = eDate;

                    trackExams.Add(trackExam);

                }

            }
        }
        
        bool validateDte(string dateTime,out DateTime parsedDate)
        {
            bool isValid=DateTime.TryParseExact(
                         dateTime,
                         format,
                         CultureInfo.InvariantCulture,
                         DateTimeStyles.None,
                         out parsedDate);
            if (!isValid)
                MessageBox.Show("Invalid input. Please enter the date and time in the format MM/dd/yyyy hh:mm tt.");
            return isValid;
        }
    }
}
