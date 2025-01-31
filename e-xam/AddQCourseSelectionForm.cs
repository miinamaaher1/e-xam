using BLL.EntityLists;
using BLL.EntityManagers;
using e_xam.InstructorForms;
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
    public partial class AddQCourseSelectionForm : Form
    {
        private int inst_id;
        Dictionary<string, int> courses = new Dictionary<string, int>();

        public AddQCourseSelectionForm(int _inst_id)
        {
            InitializeComponent();
            inst_id = _inst_id;
            courses = CourseManager.getCoursesByInstId(inst_id);
            if (courses.Count == 0)
            {
                coursesComboBox.Items.Add("No Courses Available");
                coursesComboBox.SelectedIndex = 0;
            }
            else
            {
                foreach (var course in courses)
                {
                    coursesComboBox.Items.Add(course.Key);
                }
                coursesComboBox.SelectedIndex = 0;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm(courses[coursesComboBox.Text] , inst_id);

            // Subscribe to the FormClosed event
            addQuestionForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            addQuestionForm.Show();
        }
    }
}
