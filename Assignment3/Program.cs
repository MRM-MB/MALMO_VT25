namespace Assignment3;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Set DPI awareness before anything else
        if (Environment.OSVersion.Version.Major >= 6)
        {
            SetProcessDPIAware();
        }

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            }
            catch
            {
                // Fallback for older .NET versions
            }
        }
        
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool SetProcessDPIAware();
}