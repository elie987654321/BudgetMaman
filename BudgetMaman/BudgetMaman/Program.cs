using BudgetMaman.Model;
using BudgetMaman.Presenter;

namespace BudgetMaman
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            FormPrincipal formPrincipal = new FormPrincipal(new PresenterClass());
            formPrincipal.FormBorderStyle = FormBorderStyle.FixedSingle;

            Application.Run(formPrincipal);
        }
    }
}