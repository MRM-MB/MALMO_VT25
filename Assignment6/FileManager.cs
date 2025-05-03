using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment6
{
    public static class FileManager
    {
        // Define the file path as relative to the application's directory
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reminders.txt");

        // Save tasks to file
        public static void SaveTasksToFile(List<Task> tasks)
        {
            try
            {
                MessageBox.Show("Attempting to save data to file: " + FilePath); // Debugging
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (var task in tasks)
                    {
                        // Save each task as a line in the format "Date|Priority|Description"
                        writer.WriteLine($"{task.TaskDate}|{task.Priority}|{task.Description}");
                    }
                }
                Console.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to save tasks to file: " + ex.Message);
            }
        }


        // Load tasks from file
        public static List<Task> LoadTasksFromFile()
        {
            List<Task> tasks = new List<Task>();

            if (!File.Exists(FilePath))
                throw new FileNotFoundException("Data file not found.");

            try
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Expect each line in the format "Date|Priority|Description"
                        string[] parts = line.Split('|');
                        if (parts.Length == 3 &&
                            DateTime.TryParse(parts[0], out DateTime date) &&
                            Enum.TryParse(parts[1], out PriorityType priority))
                        {
                            tasks.Add(new Task(date, parts[2], priority));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new IOException("Failed to load tasks from file.", ex);
            }

            return tasks;
        }
    }
}

