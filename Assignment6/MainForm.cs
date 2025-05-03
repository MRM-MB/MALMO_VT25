using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;
        private Dictionary<PriorityType, string> priorityDisplayNames;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "ToDo Reminder by Manish Raj Moriche";

            taskManager = new TaskManager();

            priorityDisplayNames = new Dictionary<PriorityType, string>
            {
                { PriorityType.Very_important, "Very Important" },
                { PriorityType.Important, "Important" },
                { PriorityType.Normal, "Normal" },
                { PriorityType.Less_important, "Less Important" },
                { PriorityType.Not_important, "Not Important" }
            };

            cmbPriority.Items.Clear();
            foreach (var displayName in priorityDisplayNames.Values)
            {
                cmbPriority.Items.Add(displayName);
            }
            cmbPriority.SelectedIndex = (int)PriorityType.Normal;

            lstTasks.Items.Clear();
            lblClock.Text = DateTime.Now.ToLongTimeString();
            clockTimer.Start();
            txtBoxToDo.Text = string.Empty;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";

            btnChange.Enabled = false;
            btnDelete.Enabled = false;

            UpdateTaskList();
        }

        private PriorityType GetSelectedPriorityType()
        {
            string selectedDisplayName = cmbPriority.SelectedItem.ToString();
            foreach (var kvp in priorityDisplayNames)
            {
                if (kvp.Value == selectedDisplayName)
                {
                    return kvp.Key;
                }
            }
            return PriorityType.Normal;
        }

        private Task ReadInput()
        {
            return new Task(
                dateTimePicker1.Value,
                txtBoxToDo.Text,
                GetSelectedPriorityType()
            );
        }

        private void UpdateTaskList()
        {
            lstTasks.Items.Clear();
            lstTasks.Items.AddRange(taskManager.GetInfoStringsList().ToArray()); // Use the formatted ToString output

            // Enable or disable the Change and Delete buttons based on whether there are items
            bool hasItems = lstTasks.Items.Count > 0;
            btnChange.Enabled = hasItems;
            btnDelete.Enabled = hasItems;
        }


        private void ClearInputFields()
        {
            txtBoxToDo.Clear();
            dateTimePicker1.Value = DateTime.Now;
            cmbPriority.SelectedIndex = (int)PriorityType.Normal;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = ReadInput();
            taskManager.AddNewTask(task);
            UpdateTaskList();
            ClearInputFields();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstTasks.SelectedIndex;

            if (selectedIndex >= 0)
            {
                Task updatedTask = ReadInput();
                if (taskManager.UpdateTask(selectedIndex, updatedTask))
                {
                    UpdateTaskList();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Unable to update the selected task.");
                }
            }
            else
            {
                MessageBox.Show("Please select a task to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstTasks.SelectedIndex;

            if (selectedIndex >= 0 && taskManager.DeleteTask(selectedIndex))
            {
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Please select a valid task to delete.");
            }
        }

        // Menu item: New - Resets the form
        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        // Menu item: Open Data File - Loads tasks from file
        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var loadedTasks = FileManager.LoadTasksFromFile();
                taskManager.SetTasks(loadedTasks);
                UpdateTaskList();
                MessageBox.Show("Data loaded successfully!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No data file found. Please save data first before opening.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data.\n" + ex.Message);
            }
        }

        // Menu item: Save Data File - Saves tasks to file
        private void saveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileManager.SaveTasksToFile(taskManager.GetTasks());
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save data.\n" + ex.Message);
            }
        }

        private void exotAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.OKCancel
            );

            if (dlgResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}

