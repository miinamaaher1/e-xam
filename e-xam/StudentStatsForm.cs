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
    public partial class StudentStatsForm : Form
    {
        public StudentStatsForm()
        {
            InitializeComponent();
            this.AcceptButton = viewBtn;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            Student student = StudentManager.getStudentStats(Convert.ToInt32(studentIdBx.Text));

            if (student == null)
            {
                MessageBox.Show("Student Not Found!");
                return;
            }
            else
            {
               
                StudentStatsReport studentReport = new StudentStatsReport(student);

                // Subscribe to the FormClosed event
                studentReport.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Show();
                };
                this.Hide();
                studentReport.Show();
            }

        }
    }
}
