using BLL.Entities;
using BLL.EntityLists;
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

namespace e_xam.InstructorForms
{
    public partial class ViewCourseTopicsForm : Form
    {
        bool isLoaded;
        int instId;
        CourseList courses;
        public ViewCourseTopicsForm(int _instId)
        {
            InitializeComponent();
            instId = _instId;
        }



        private void ViewCourseTopicsForm_Load(object sender, EventArgs e)
        {

            isLoaded = false;
            courses = CourseManager.getInstructorCourses(instId);
            courseCombo.DataSource = courses;
            courseCombo.DisplayMember = "Name";
            courseCombo.ValueMember = "id";
            courseCombo.SelectedIndex = -1;
            msgLbl.Visible = false;
            isLoaded = true;
        }

        private void viewTopicsBtn_Click(object sender, EventArgs e)
        {
            if (courseCombo.SelectedIndex!=-1) {

                CourseTopicsReportForm courseTopicsReportForm = new CourseTopicsReportForm((int)courseCombo.SelectedValue);
                // Subscribe to the FormClosed event
                courseTopicsReportForm.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Show();
                };
                this.Hide();
                courseTopicsReportForm.Show();
            }
            else 
                msgLbl.Visible = true;
        }
    }
}
