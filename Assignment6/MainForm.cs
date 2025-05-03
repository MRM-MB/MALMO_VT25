using System;
using System.Collections.Generic;
using System.Drawing;
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
            // Set form properties
            this.Text = "ToDo Reminder by Alexandra";
            this.BackColor = Color.FromArgb(245, 245, 250);  // Light blue-gray background
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Style the group box without title
            grpBox1.BackColor = Color.FromArgb(240, 240, 255);  // Light blue background
            grpBox1.Text = "";  // No title in the group box itself

            // Style the list box
            lstTasks.BackColor = Color.White;
            lstTasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lstTasks.BorderStyle = BorderStyle.FixedSingle;
            lstTasks.ForeColor = Color.FromArgb(40, 40, 40);
            
            // Style the buttons with modern look
            StyleButton(btnAdd, Color.FromArgb(92, 184, 92));  // Green for add
            StyleButton(btnChange, Color.FromArgb(240, 173, 78));  // Orange for change
            StyleButton(btnDelete, Color.FromArgb(217, 83, 79));  // Red for delete
            
            // Style the input controls
            StyleTextBox(txtBoxToDo);
            StyleComboBox(cmbPriority);
            StyleDateTimePicker(dateTimePicker1);
            
            // Style labels with consistent font
            StyleLabels();
            
            // Clock styling
            lblClock.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblClock.ForeColor = Color.FromArgb(60, 60, 150);

            // Initialize other components
            InitializeComponents();
        }

        private void StyleButton(Button button, Color baseColor)
        {
            button.BackColor = baseColor;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(5);
            
            // Add hover effect
            button.MouseEnter += (s, e) => {
                button.BackColor = ControlPaint.Light(baseColor, 0.1f);
                button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            };
            button.MouseLeave += (s, e) => {
                button.BackColor = baseColor;
                button.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            };
        }

        private void StyleTextBox(TextBox textBox)
        {
            textBox.Font = new Font("Segoe UI", 12F);
            textBox.BackColor = Color.White;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Padding = new Padding(5);
        }

        private void StyleComboBox(ComboBox comboBox)
        {
            comboBox.Font = new Font("Segoe UI", 12F);
            comboBox.BackColor = Color.White;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void StyleDateTimePicker(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Font = new Font("Segoe UI", 12F);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
        }

        private void StyleLabels()
        {
            // Style the date/time and priority labels
            lbldateAndTime.Font = new Font("Segoe UI", 14F);
            lbldateAndTime.ForeColor = Color.FromArgb(60, 60, 60);
            
            lblPriority.Font = new Font("Segoe UI", 12F);
            lblPriority.ForeColor = Color.FromArgb(60, 60, 60);
        }

        private void InitializeComponents()
        {
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
            var tasks = taskManager.GetTasks();
            
            foreach (var task in tasks)
            {
                // Create the item with all its subitems
                var item = new ListViewItem(new string[] {
                    task.TaskDate.ToString("yyyy-MM-dd"),
                    task.GetTimeString(),
                    task.GetPriorityString(),
                    task.Description
                });
                lstTasks.Items.Add(item);
            }

            // Configure column widths and alignment
            for (int i = 0; i < lstTasks.Columns.Count; i++)
            {
                int minWidth = i switch
                {
                    0 => 180,  // Date
                    1 => 120,  // Hour
                    2 => 180,  // Priority
                    _ => 860   // Description
                };
                lstTasks.Columns[i].Width = Math.Max(minWidth, lstTasks.Columns[i].Width);
                
                // Center align headers for Date, Hour, and Priority columns
                if (i < 3) 
                {
                    lstTasks.Columns[i].TextAlign = HorizontalAlignment.Center;
                }
            }

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
            if (lstTasks.SelectedItems.Count > 0)
            {
                int selectedIndex = lstTasks.SelectedIndices[0];
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
            if (lstTasks.SelectedItems.Count > 0)
            {
                int selectedIndex = lstTasks.SelectedIndices[0];
                if (taskManager.DeleteTask(selectedIndex))
                {
                    UpdateTaskList();
                }
                else
                {
                    MessageBox.Show("Unable to delete the selected task.");
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count > 0)
            {
                var selectedItem = lstTasks.SelectedItems[0];
                // Combine date and time into one DateTime value
                var date = DateTime.Parse(selectedItem.Text);
                var time = DateTime.Parse(selectedItem.SubItems[1].Text);
                dateTimePicker1.Value = new DateTime(
                    date.Year, date.Month, date.Day,
                    time.Hour, time.Minute, 0
                );
                
                // Find and set the matching priority in combo box
                string priority = selectedItem.SubItems[2].Text;
                foreach (var kvp in priorityDisplayNames)
                {
                    if (kvp.Value.Equals(priority, StringComparison.OrdinalIgnoreCase))
                    {
                        cmbPriority.SelectedIndex = (int)kvp.Key;
                        break;
                    }
                }
                
                txtBoxToDo.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void lstTasks_DoubleClick(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItems.Count > 0)
            {
                btnChange_Click(sender, e);
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

