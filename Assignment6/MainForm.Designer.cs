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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            label1 = new Label();
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
            btnChange.Location = new Point(215, 715);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(94, 29);
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
            btnDelete.Location = new Point(491, 715);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
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
            btnAdd.Location = new Point(392, 224);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
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
            cmbPriority.Location = new Point(878, 98);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(196, 28);
            cmbPriority.TabIndex = 3;
            toolTip1.SetToolTip(cmbPriority, "Select the priority level.");

            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(777, 101);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(56, 20);
            lblPriority.TabIndex = 4;
            lblPriority.Text = "Priority";

            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(215, 98);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(522, 27);
            dateTimePicker1.TabIndex = 5;
            toolTip1.SetToolTip(dateTimePicker1, "Click to open calendar for date, write in time here.");

            // 
            // lbldateAndTime
            // 
            lbldateAndTime.AutoSize = true;
            lbldateAndTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldateAndTime.Location = new Point(77, 101);
            lbldateAndTime.Name = "lbldateAndTime";
            lbldateAndTime.Size = new Size(108, 20);
            lbldateAndTime.TabIndex = 6;
            lbldateAndTime.Text = "Date and time";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 177);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "To Do";

            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.Location = new Point(86, 306);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(988, 364);
            lstTasks.TabIndex = 8;
            toolTip1.SetToolTip(lstTasks, "List of tasks. Select to edit or delete.");

            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDate.Location = new Point(86, 283);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(42, 20);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";

            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHour.Location = new Point(262, 282);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(44, 20);
            lblHour.TabIndex = 11;
            lblHour.Text = "Hour";

            // 
            // lblPriority2
            // 
            lblPriority2.AutoSize = true;
            lblPriority2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPriority2.Location = new Point(491, 282);
            lblPriority2.Name = "lblPriority2";
            lblPriority2.Size = new Size(61, 20);
            lblPriority2.TabIndex = 12;
            lblPriority2.Text = "Priority";

            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.Location = new Point(744, 282);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 20);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Description";

            // 
            // txtBoxToDo
            // 
            txtBoxToDo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxToDo.Location = new Point(219, 178);
            txtBoxToDo.Name = "txtBoxToDo";
            txtBoxToDo.Size = new Size(855, 27);
            txtBoxToDo.TabIndex = 14;
            toolTip1.SetToolTip(txtBoxToDo, "Enter task description here.");

            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1217, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";

            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1217, 28);
            menuStrip2.TabIndex = 16;
            menuStrip2.Text = "menuStrip2";

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
            lblClock.Location = new Point(1024, 724);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(50, 20);
            lblClock.TabIndex = 17;
            lblClock.Text = "label2";

            // 
            // grpBox1
            // 
            grpBox1.Location = new Point(63, 259);
            grpBox1.Name = "grpBox1";
            grpBox1.Size = new Size(1022, 422);
            grpBox1.TabIndex = 18;
            grpBox1.TabStop = false;
            grpBox1.Text = "ToDo";

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 792);
            Controls.Add(lblClock);
            Controls.Add(txtBoxToDo);
            Controls.Add(lblDescription);
            Controls.Add(lblPriority2);
            Controls.Add(lblHour);
            Controls.Add(lblDate);
            Controls.Add(lstTasks);
            Controls.Add(label1);
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
        private Label label1;
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
