using ExaminationSys.Controllers;
using ExaminationSys.Views;

namespace ExaminationSys
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
            //  Application.Run(new EntryForm());
            //Application.Run(new TakeExamForm());
            // RegisterController controller = new RegisterController();
            // Application.Run(new RegisterForm(controller));
            // Application.Run(new RegisterForm());
            //Application.Run(new SubjectManagementForm());
            Application.Run(new ChooseSubject());
        }
    }
}