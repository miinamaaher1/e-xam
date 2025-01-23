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
    public partial class trackReport : Form
    {

        public trackReport(int trackId)
        {
            InitializeComponent();
            List<Student> students = StudentManager.getStudentsByTrack(trackId);

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
            trackSelectionReport newTrack = new trackSelectionReport();
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
