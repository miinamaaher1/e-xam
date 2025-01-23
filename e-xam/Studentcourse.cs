using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;
using Microsoft.VisualBasic.ApplicationServices;

namespace e_xam
{
    public partial class Studentcourse : Form
    {
        CourseList courselist;
        int x, y, z, v;
        public Studentcourse(int _id)
        {
            x = y = z = v = 0;
            courselist = CourseManger.getStudentcourse(_id);
            InitializeComponent();
            loadcourses();
        }
        
        private void loadcourses()
        {
            courses.Controls.Clear();
            courses.Size = new Size(1000, 5000);

            foreach (Course course in courselist)
            {
   
                Panel coursePanel = new Panel
                {
                    Size = new Size(1000, 50), 
                    BorderStyle = BorderStyle.None 
                };

                Label courseName = new Label
                {
                    Text = course.name,
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10 + x, 10 + y)
                };

                Button btnCourse = new Button
                {
                    Text = "view",
                    Size = new Size(80, 30),
                    Location = new Point(500+z, 5+v),
                    Tag = course.id
                };

                coursePanel.Controls.Add(courseName);
                coursePanel.Controls.Add(btnCourse);

                courses.Controls.Add(coursePanel);

            }
            x += 10;
            y += 10;
            z += 500;
            v += 5;
        }
    }
     
}

       
    

