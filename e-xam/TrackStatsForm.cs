using BLL.Entities;
using BLL.EntityManagers;
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

        public TrackStatsForm(int trackId, int _instId)
        {
            InitializeComponent();
            List<Student> students = StudentManager.getStudentsByTrack(trackId);
            instId = _instId;

            trackNameLbl.Text = students[0].track.name + " Track";
            trackReportStudItem[] studItems = new trackReportStudItem[students.Count];
            for (int i = 0; i < students.Count; i++)
            {
                studItems[i] = new trackReportStudItem();
                studItems[i].StudNum = (i + 1).ToString();
                studItems[i].StudName = students[i].firstName + " " + students[i].lastName;
                studItems[i].StudGPA = students[i].gpa.ToString();
                if (StudFLayPanel.Controls.Count < 0)
                {
                    StudFLayPanel.Controls.Clear();
                }
                else
                {
                    StudFLayPanel.Controls.Add(studItems[i]);
                }
            }

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            TrackSelectionStatsForm newTrack = new TrackSelectionStatsForm(instId);
            // Subscribe to the FormClosed event
            newTrack.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Close();
            };
            this.Hide();
            newTrack.Show();
        }
    }
}
