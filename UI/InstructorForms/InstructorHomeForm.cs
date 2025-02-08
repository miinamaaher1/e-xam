using BLL.Entities;
using BLL.EntityManagers;
using UI.InstructorForms;
using UI.SharedForms;

namespace UI
{
    public partial class InstructorHomeForm : Form
    {
        Instructor user;
        public InstructorHomeForm(int _userId)
        {
            InitializeComponent();
            user = InstructorManager.getInstructor(_userId);
            nameLbl.Text = user.firstName + " " + user.lastName;
            trackLbl.Text = user.dept.name;
        }

        private void addQuestionItm_Click(object sender, EventArgs e)
        {
            AddQuestionSelectCourseForm addQCourseSelectionForm = new AddQuestionSelectCourseForm(user.id);

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
            ReviewAnswersSelectStudentForm answersheet = new ReviewAnswersSelectStudentForm(user);

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

            CourseDetailsSelectForm courseTopicsForm = new CourseDetailsSelectForm(user.id);

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

            InstructorClassesReportForm instClasses = new InstructorClassesReportForm(user);

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
            TrackStatsSelectForm trackSelectionStatsForm = new TrackStatsSelectForm(user.id);

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

            StudentStatsSelectForm studentStats = new StudentStatsSelectForm();

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



        private void coursesExamsItm_Click(object sender, EventArgs e)
        {
            ViewExamSelectForm selectExamForm = new ViewExamSelectForm(user.id);

            selectExamForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            selectExamForm.Show();
        }
    }
}
