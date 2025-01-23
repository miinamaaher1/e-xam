using BLL.Entities;
using BLL.EntityLists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using DAL;
using BLL.EntityManagers;
namespace e_xam
{
    public partial class StudentHome : Form
    {
        Student user;
        public StudentHome(Student _user)
        {
            InitializeComponent();
            user = _user;
            nameLbl.Text = user.firstName + " " + user.lastName;
            gpaLbl.Text = user.gpa.ToString();
            trackLbl.Text = user.track.dept.name + ", " + user.track.name;
        }

        private void exitItm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editProfileItm_Click(object sender, EventArgs e)
        {
            // insert the edit profile form here
            MessageBox.Show("Coming Soon");
        }

        private void showCoursesItm_Click(object sender, EventArgs e)
        {
            // insert the show courses (course name and view button) form here

            CourseList c = CourseManger.getStudentcourse(user.id);

            if (c == null || c.Count == 0) 
            {
                MessageBox.Show("There are no courses for this student.", "No Courses");

                return;
            }



            else 
            {
                Studentcourse studentcourse = new Studentcourse(c);
                studentcourse.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Close();

                };
                this.Hide();
                studentcourse.Show();

            }
            

            // Subscribe to the FormClosed event
            
        }

        private void aboutItm_Click(object sender, EventArgs e)
        {
            // insert the about form here
            MessageBox.Show("Coming Soon");
        }
    }
}
