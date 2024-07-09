namespace Screenshot.App;

using Screenshot.App.Views;
using Screenshot.Core;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var fileInfoRepository = new FileInfoRepository();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MainWindow(fileInfoRepository));
    }
}
