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
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Microsoft.VisualBasic.ApplicationServices;
using BLL.EntityManagers;
using e_xam.StudentForms;

namespace e_xam
{
    public partial class Studentcourse : Form
    {
        CourseList courselist;
        int studentid;
        string coursename;
        int trakid;
        int x, y, z, v;
        public Studentcourse(int _id,int _trakid)
        {
            studentid= _id;
            trakid= _trakid;
            x = y = z = v = 0;
            coursename = default;
            courselist = CourseManager.getStudentCourses(studentid);
            InitializeComponent();
            loadcourses();
        }
        
        private void loadcourses()
        {
            courses.Controls.Clear();
            courses.Size = new Size(800, 350);

            foreach (Course course in courselist)
            {
   
                Panel coursePanel = new Panel
                {
                    Size = new Size(600, 70), 
                    BorderStyle = BorderStyle.None 
                };

                Label courseName = new Label
                {
                    Text = course.name,
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(20 + x, 10 + y),
                    
                };


                Button btnCourse = new Button
                {
                    Text = "view",
                    Size = new Size(80, 30),
                    Location = new Point(510 + z, 5 + v),
                    Tag = new Course {id=course.id,name=course.name }
                    


                };
                
                btnCourse.Click += viewCourse_Click;
                coursePanel.Controls.Add(courseName);
                coursePanel.Controls.Add(btnCourse);

                courses.Controls.Add(coursePanel);

            }
            x += 10;
            y += 10;
            z += 500;
            v += 5;
        }

        private void viewCourse_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
           
            if (clickedButton == null || clickedButton.Tag == null) return;
            else
            {
                Course course = (Course)clickedButton.Tag;
               
                StudentExams studentExam = new StudentExams(studentid ,course.id,trakid, course.name);
                studentExam.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                this.Hide();
                studentExam.Show();
            }
        }
    }
     
}

       
    

