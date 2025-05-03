namespace Assignment6
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new System.Windows.Forms.ToolTip(components);  // Initialize ToolTip
            btnChange = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            clockTimer = new System.Windows.Forms.Timer(components);
            cmbPriority = new ComboBox();
            lblPriority = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbldateAndTime = new Label();
            lstTasks = new ListBox();
            lblDate = new Label();
            lblHour = new Label();
            lblPriority2 = new Label();
            lblDescription = new Label();
            txtBoxToDo = new TextBox();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newCtrlNToolStripMenuItem = new ToolStripMenuItem();
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            exotAltF4ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            lblClock = new Label();
            grpBox1 = new GroupBox();
            menuStrip2.SuspendLayout();
            SuspendLayout();

            // 
            // btnChange
            // 
            btnChange.BackColor = SystemColors.ControlDark;
            btnChange.FlatStyle = FlatStyle.Popup;
            btnChange.Size = new Size(250, 60);
            btnChange.Location = new Point(500, 900);
            btnChange.Name = "btnChange";
            btnChange.TabIndex = 0;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            toolTip1.SetToolTip(btnChange, "Select a task to change it.");

            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Size = new Size(250, 60);
            btnDelete.Location = new Point(850, 900);
            btnDelete.Name = "btnDelete";
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            toolTip1.SetToolTip(btnDelete, "Select a task to delete it.");

            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlDark;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Size = new Size(150, 50);
            btnAdd.Location = new Point(725, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            toolTip1.SetToolTip(btnAdd, "Add a new task with the specified details.");

            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;

            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Size = new Size(300, 35);
            cmbPriority.Font = new Font("Segoe UI", 12F);
            cmbPriority.Location = new Point(900, 77);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.TabIndex = 3;
            toolTip1.SetToolTip(cmbPriority, "Select the priority level.");

            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 12F);
            lblPriority.Location = new Point(800, 80);
            lblPriority.Name = "lblPriority";
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority";

            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Size = new Size(500, 35);
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(250, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.TabIndex = 5;
            toolTip1.SetToolTip(dateTimePicker1, "Click to open calendar for date, write in time here.");

            // 
            // lbldateAndTime
            // 
            lbldateAndTime.AutoSize = true;
            lbldateAndTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbldateAndTime.Location = new Point(100, 80);
            lbldateAndTime.Name = "lbldateAndTime";
            lbldateAndTime.TabIndex = 6;
            lbldateAndTime.Text = "Date and time";

            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Size = new Size(1360, 430);
            lstTasks.Font = new Font("Segoe UI", 12F);
            lstTasks.Location = new Point(120, 420);
            lstTasks.Name = "lstTasks";
            lstTasks.TabIndex = 8;
            lstTasks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            toolTip1.SetToolTip(lstTasks, "List of tasks. Select to edit or delete.");

            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDate.Location = new Point(120, 390);
            lblDate.Name = "lblDate";
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";

            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHour.Location = new Point(400, 390);
            lblHour.Name = "lblHour";
            lblHour.TabIndex = 11;
            lblHour.Text = "Hour";

            // 
            // lblPriority2
            // 
            lblPriority2.AutoSize = true;
            lblPriority2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPriority2.Location = new Point(700, 390);
            lblPriority2.Name = "lblPriority2";
            lblPriority2.TabIndex = 12;
            lblPriority2.Text = "Priority";

            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDescription.Location = new Point(1000, 390);
            lblDescription.Name = "lblDescription";
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description";

            // 
            // txtBoxToDo
            // 
            txtBoxToDo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxToDo.Size = new Size(1200, 35);
            txtBoxToDo.Font = new Font("Segoe UI", 12F);
            txtBoxToDo.Location = new Point(250, 157);
            txtBoxToDo.Name = "txtBoxToDo";
            txtBoxToDo.TabIndex = 14;
            toolTip1.SetToolTip(txtBoxToDo, "Enter the description of your task here");

            // Add a description label instead of the redundant ToDo label
            Label lblTaskDescription = new Label();
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTaskDescription.Location = new Point(100, 160);
            lblTaskDescription.Text = "Task:";
            Controls.Add(lblTaskDescription);

            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1600, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Font = new Font("Segoe UI", 12F);

            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1600, 28);
            menuStrip2.TabIndex = 16;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.Font = new Font("Segoe UI", 12F);

            foreach (ToolStripMenuItem item in menuStrip2.Items)
            {
                item.Font = new Font("Segoe UI", 12F);
                foreach (ToolStripItem subItem in item.DropDownItems)
                {
                    subItem.Font = new Font("Segoe UI", 11F);
                }
            }

            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCtrlNToolStripMenuItem, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, exotAltF4ToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";

            // 
            // newCtrlNToolStripMenuItem
            // 
            newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            newCtrlNToolStripMenuItem.Size = new Size(249, 26);
            newCtrlNToolStripMenuItem.Text = "New               Ctrl+N";
            newCtrlNToolStripMenuItem.Click += newCtrlNToolStripMenuItem_Click;
            newCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));

            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.Size = new Size(249, 26);
            openDataFileToolStripMenuItem.Text = "Open data file";
            openDataFileToolStripMenuItem.Click += openDataFileToolStripMenuItem_Click;

            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(249, 26);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += saveDataFileToolStripMenuItem_Click;

            // 
            // exotAltF4ToolStripMenuItem
            // 
            exotAltF4ToolStripMenuItem.Name = "exotAltF4ToolStripMenuItem";
            exotAltF4ToolStripMenuItem.Size = new Size(244, 26);
            exotAltF4ToolStripMenuItem.Text = "Exit                     Alt+F4";
            exotAltF4ToolStripMenuItem.Click += exotAltF4ToolStripMenuItem_Click;

            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";

            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);


            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Font = new Font("Segoe UI", 14F);
            lblClock.Location = new Point(1300, 910);
            lblClock.Name = "lblClock";
            lblClock.TabIndex = 17;
            lblClock.Text = "label2";

            // 
            // grpBox1
            // 
            grpBox1.Location = new Point(100, 350);
            grpBox1.Size = new Size(1400, 520);
            grpBox1.Name = "grpBox1";
            grpBox1.TabIndex = 18;
            grpBox1.TabStop = false;
            grpBox1.Text = "";  // Remove the title from group box

            // Add a standalone ToDo List label that will be our single title
            Label lblTitle = new Label();
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(60, 60, 150);
            lblTitle.Location = new Point(120, 320);
            lblTitle.Text = "ToDo List";
            lblTitle.BackColor = Color.FromArgb(220, 225, 255);
            lblTitle.Padding = new Padding(10, 5, 10, 5);
            Controls.Add(lblTitle);

            // Adjust list headers to be properly spaced
            lblDate.Location = new Point(120, 390);
            lblHour.Location = new Point(400, 390);
            lblPriority2.Location = new Point(700, 390);
            lblDescription.Location = new Point(1000, 390);

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 1100);
            MinimumSize = new Size(1600, 1100);
            MaximumSize = new Size(1600, 1100);
            Controls.Add(lblClock);
            Controls.Add(txtBoxToDo);
            Controls.Add(lblDescription);
            Controls.Add(lblPriority2);
            Controls.Add(lblHour);
            Controls.Add(lblDate);
            Controls.Add(lstTasks);
            Controls.Add(lbldateAndTime);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblPriority);
            Controls.Add(cmbPriority);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(grpBox1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChange;
        private Button btnDelete;
        private Button btnAdd;
        private System.Windows.Forms.Timer clockTimer;
        private ComboBox cmbPriority;
        private Label lblPriority;
        private DateTimePicker dateTimePicker1;
        private Label lbldateAndTime;
        private ListBox lstTasks;
        private Label lblDate;
        private Label lblHour;
        private Label lblPriority2;
        private Label lblDescription;
        private TextBox txtBoxToDo;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newCtrlNToolStripMenuItem;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exotAltF4ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolTip toolTip1;
        private Label lblClock;
        private GroupBox grpBox1;
    }
}
