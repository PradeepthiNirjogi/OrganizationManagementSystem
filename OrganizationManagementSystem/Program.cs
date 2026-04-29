using OrganizationManagementSystem.Forms;
using Serilog;

namespace OrganizationManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()

           .MinimumLevel.Debug()

           .WriteTo.Console()

            .WriteTo.File("logs\\apps.log", rollingInterval: RollingInterval.Day)

            .CreateLogger();

            Log.Information("Application started");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
            Log.CloseAndFlush();
        }
    }
}