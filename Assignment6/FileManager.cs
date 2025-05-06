using System;
using System.Collections.Generic;
using System.IO;

// Made by Manish Raj Moriche and finished on the 6th of May 2025
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
            List<Task> tasks = new List<Task>(); // Ensure tasks is initialized

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

                        // Check length, date parsing, and null parts first
                        if (parts.Length == 3 && parts[0] != null && parts[1] != null && parts[2] != null &&
                            DateTime.TryParse(parts[0], out DateTime date))
                        {
                            // Assign parts[1] to a new variable after the null check
                            string priorityString = parts[1]!; // Added null-forgiving operator
                            
                            // Now use the non-null local variable for TryParse
                            if (Enum.TryParse(priorityString, out PriorityType parsedPriority))
                            {
                                // parts[2] is also known non-null here
                                tasks.Add(new Task(date, parts[2], parsedPriority));
                            }
                            else
                            {
                                // Handle invalid priority string
                                Console.WriteLine($"Invalid priority format: {priorityString} in line: {line}");
                            }
                        }
                        else
                        {
                            // Handle invalid line structure, null parts, or invalid date format
                            Console.WriteLine($"Invalid line format or content: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new IOException("Failed to load tasks from file.", ex);
            }

            return tasks; // Remove null-forgiving operator
        }
    }
}

