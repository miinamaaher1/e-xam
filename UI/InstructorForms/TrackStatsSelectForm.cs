using BLL.EntityManagers;

namespace UI
{
    public partial class TrackStatsSelectForm : Form
    {
        private Dictionary<string, int> trackDictionary;
        private int instId;

        public TrackStatsSelectForm(int _instId)
        {
            InitializeComponent();
            this.AcceptButton = viewTrackBtn;
            trackDictionary = TrackManager.getTrackNamesAndIds(_instId);  // I returned the Ids too, since they are our primary keys
            tracksComboBox.Items.Clear();
            instId = _instId;
            if (trackDictionary.Count == 0)
            {
                tracksComboBox.Items.Add("No Tracks Available");
                tracksComboBox.SelectedIndex = 0;
            }
            else
            {
                foreach (var track in trackDictionary)
                {
                    tracksComboBox.Items.Add(track.Key);
                }
                tracksComboBox.SelectedIndex = 0;
            }
        }

        private void viewTrackBtn_Click(object sender, EventArgs e)
        {
            string selectedTrackName = tracksComboBox.GetItemText(tracksComboBox.SelectedItem);
            if (selectedTrackName == "No Tracks Available")
            {
                MessageBox.Show("No Tracks Available");
                return;
            }
            int selectedTrackId = trackDictionary[selectedTrackName];

            TrackStatsReportForm trackReport = new TrackStatsReportForm(selectedTrackId, instId);

            // Subscribe to the FormClosed event
            trackReport.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            trackReport.Show();
        }
    }
}

