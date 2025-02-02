using BLL.Entities;
using BLL.EntityManagers;
using e_xam.InstructorForms;
using e_xam.SharedForms;
using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace e_xam
{
    public partial class InstructorHome : Form
    {
        Instructor user;
        public InstructorHome(int _userId)
        {
            InitializeComponent();
            user = InstructorManager.getInstructor(_userId);
            nameLbl.Text = user.firstName + " " + user.lastName;
            trackLbl.Text = user.dept.name;
        }

        private void addQuestionItm_Click(object sender, EventArgs e)
        {
            AddQCourseSelectionForm addQCourseSelectionForm = new AddQCourseSelectionForm(user.id);

            addQCourseSelectionForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            addQCourseSelectionForm.Show();
        }

        private void generateExamItm_Click(object sender, EventArgs e)
        {
            // insert the generate exam form here

            GenerateExamForm genExamForm = new GenerateExamForm(user.id);

            // Subscribe to the FormClosed event
            genExamForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            genExamForm.Show();
        }

        private void exitItm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editProfileItm_Click(object sender, EventArgs e)
        {
            // insert the edit profile form here
            EditProfileForm editProfileForm = new EditProfileForm(user.id);
            editProfileForm.FormClosed += (s, args) =>
            {
                user = InstructorManager.getInstructor(user.id);
                nameLbl.Text = user.firstName + " " + user.lastName;
                this.Show();
            };
            this.Hide();
            editProfileForm.Show();
        }

        private void answerSheetItm_Click(object sender, EventArgs e)
        {
            // insert the answer sheet (review student answers) form here
            SelectStudentClassForm answersheet = new SelectStudentClassForm(user);

            answersheet.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            answersheet.Show();
        }

        private void courseDetailsItm_Click(object sender, EventArgs e)
        {
            // insert the course details (topics) form here

            ViewCourseTopicsForm courseTopicsForm = new ViewCourseTopicsForm(user.id);

            // Subscribe to the FormClosed event
            courseTopicsForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            courseTopicsForm.Show();
        }

        private void instructorClassesItm_Click(object sender, EventArgs e)
        {
            // insert the instructor classes (class and student count) form here

            InstructorClassesReport instClasses = new InstructorClassesReport(user);

            instClasses.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };

            this.Hide();
            instClasses.Show();
        }

        private void trackStatsItm_Click(object sender, EventArgs e)
        {
            //// insert the track stats (student name and gpa) form here
            TrackSelectionStatsForm trackSelectionStatsForm = new TrackSelectionStatsForm(user.id);

            // Subscribe to the FormClosed event
            trackSelectionStatsForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            trackSelectionStatsForm.Show();
        }

        private void studentStatsItm_Click(object sender, EventArgs e)
        {
            // insert the student stats (course name and total grade) form here

            StudentStatsForm studentStats = new StudentStatsForm();

            // Subscribe to the FormClosed event
            studentStats.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            studentStats.Show();
        }

        private void aboutItm_Click(object sender, EventArgs e)
        {
            // insert the about form here
            AboutForm aboutForm = new AboutForm();
            aboutForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            aboutForm.Show();
        }
    }
}
