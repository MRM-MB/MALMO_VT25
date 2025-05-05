namespace Assignment6
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
            
            // Set the application icon
            try
            {
                string iconPath = Path.Combine(Application.StartupPath, "Assets", "icon.png");
                if (File.Exists(iconPath))
                {
                    using (var bitmap = new Bitmap(iconPath))
                    {
                        IntPtr iconHandle = bitmap.GetHicon();
                        using (Icon icon = Icon.FromHandle(iconHandle))
                        {
                            Application.Run(new MainForm { Icon = icon });
                            return;
                        }
                    }
                }
            }
            catch
            {
                // Fallback to running without icon if there's an error
            }
            
            // Run without icon if file doesn't exist or there was an error
            Application.Run(new MainForm());
        }
    }
}