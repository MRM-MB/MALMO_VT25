namespace Assignment3;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        
        // Add high DPI support
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
            }
            catch
            {
                // Fallback for older .NET versions
            }
        }
        
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}