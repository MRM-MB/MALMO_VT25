using System.Collections.Generic;

namespace Assignment6
{
    public class TaskManager
    {
        private List<Task> taskList;

        public TaskManager()
        {
            taskList = new List<Task>();
        }

        public void AddNewTask(Task task)
        {
            if (task != null)
            {
                taskList.Add(task);
            }
        }

        public List<Task> GetTasks()
        {
            return new List<Task>(taskList);
        }

        public void SetTasks(List<Task> tasks)
        {
            if (tasks != null)
            {
                taskList = tasks;
            }
        }

        public bool DeleteTask(int index)
        {
            if (index >= 0 && index < taskList.Count)
            {
                taskList.RemoveAt(index);
                return true;
            }
            return false;
        }

        public bool UpdateTask(int index, Task updatedTask)
        {
            if (index >= 0 && index < taskList.Count && updatedTask != null)
            {
                taskList[index] = updatedTask;
                return true;
            }
            return false;
        }

        public string[] GetInfoStringsList()
        {
            string[] infoStrings = new string[taskList.Count];
            for (int i = 0; i < taskList.Count; i++)
            {
                infoStrings[i] = taskList[i].ToString();
            }
            return infoStrings;
        }
    }
}

