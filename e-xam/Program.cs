using e_xam.InstructorForms;
using e_xam.StudentForms;

namespace e_xam
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();

            Application.Run(new LoginForm());
            //Application.Run(new GenerateExamForm(10004));
            //Application.Run(new generateExamReportForm(16,1000,10004));
            //Application.Run(new CourseTopicsReportForm(1000));
         //   Application.Run(new TakeExamForm(3, 10003));
        }
    }
}