using BLL.Entities;
using BLL.EntityList;
using BLL.EntityManagers;
using System.ComponentModel;

namespace UI.InstructorForms
{
    public partial class AssignExamForm : Form
    {
        int examId;
        int courseId;
        int instructorId;
        BindingList<Track> tracks;
        TrackList selectedTracks;
        bool selectedTracksBefore;
        public AssignExamForm(int _examId, int _courseId, int _instructorId)
        {
            examId = _examId;
            courseId = _courseId;
            instructorId = _instructorId;
            selectedTracksBefore = false;
            selectedTracks = new TrackList();

            InitializeComponent();
            this.AcceptButton = saveExamTracksBtn;
        }

        private void AssignExamForm_Load(object sender, EventArgs e)
        {
            //if(tracks.Count ==0 ) handle if ins doesnot have tracks??
            tracks = new BindingList<Track>(TrackManager.getInstructorTracksInCrs(instructorId, courseId));

            tracksCheckedListB.DataSource = tracks;
            tracksCheckedListB.DisplayMember = "name";
            tracksCheckedListB.ValueMember = "id";

            startDatetimeP.Format = DateTimePickerFormat.Custom;
            enddateTimeP.Format = DateTimePickerFormat.Custom;

            startDatetimeP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            enddateTimeP.CustomFormat = "MM/dd/yyyy hh:mm tt";

        }



        private void saveExamTracksBtn_Click(object sender, EventArgs e)
        {
            if (!validateDate(startDatetimeP.Value, enddateTimeP.Value))
                return;
            if (!getSelectedTracks())
                return;

            int exId = ExamManager.assignExamToTracks(examId, startDatetimeP.Value, enddateTimeP.Value, selectedTracks);
            if (exId == -1)
            {
                MessageBox.Show("Error in assigning exam to tracks");
                return;
            }

            selectedTracksBefore = true;

            MessageBox.Show("exam was assigned to selected tracks");

            foreach (var track in selectedTracks)
            {
                tracks.Remove(track);
            }

            selectedTracks.Clear();

        }

        bool validateDate(DateTime startDate, DateTime endDate)
        {
            if (startDate < DateTime.Today || endDate < DateTime.Today)
            {
                MessageBox.Show("can't enter past date");
                return false;

            }
            else if (DateTime.Compare(startDate, endDate) > 0)
            { //problem in that not enter in this condition despite date and time is equal
                MessageBox.Show("start date must be before end date");
                return false;
            }
            return true;
        }
        bool getSelectedTracks()
        {
            foreach (var track in tracksCheckedListB.CheckedItems)
                selectedTracks.Add(((Track)track));
            if (selectedTracks.Count == 0)
            {
                MessageBox.Show("Must Select Track");
                return false;
            }
            return true;
        }
    }
}
