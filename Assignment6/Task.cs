using System;

namespace Assignment6
{
    public class Task
    {
        // Fields
        private DateTime date;             // Date and time for a task
        private string description;        // Task's notes
        private PriorityType priority;     // Priority selected from the enum

        // Default Constructor
        public Task()
        {
            // Set default values
            date = DateTime.Now;
            description = string.Empty;
            priority = PriorityType.Normal;
        }

        // Constructor with one parameter (taskDate) that calls another constructor
        public Task(DateTime taskDate) : this(taskDate, string.Empty, PriorityType.Normal)
        {
            // No additional code needed here, as the chain-calling handles initialization
        }

        // Constructor with three parameters to fully initialize the Task object
        public Task(DateTime taskDate, string description, PriorityType priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }

        // Properties
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime TaskDate
        {
            get { return date; }
            set { date = value; }
        }

        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        // Methods for formatting
        public string GetPriorityString()
        {
            // Return priority with proper padding for column alignment
            return priority.ToString().Replace("_", " ");
        }

        public string GetTimeString()
        {
            // Return time in consistent format for proper column alignment
            return date.ToString("HH:mm");
        }

        // Overridden ToString method for formatted output
        public override string ToString()
        {
            // Format with fixed column widths to prevent overlap
            return String.Format("{0,-15} {1,-25} {2,-35} {3,-50}",
                date.ToString("yyyy-MM-dd"),
                GetTimeString(),
                GetPriorityString(),
                description
            );
        }
    }
}
