namespace Malmoinl5
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

        private void InitializeComponent()
        {
            ID = new Label();
            lblName = new Label();
            OfficePhone = new Label();
            Officeemail = new Label();
            ContactDetails = new Label();
            listView1 = new ListView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lstboxDisplay = new ListBox();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.ForeColor = SystemColors.Highlight;
            ID.Location = new Point(61, 77);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 0;
            ID.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = SystemColors.Highlight;
            lblName.Location = new Point(201, 77);
            lblName.Name = "lblName";
            lblName.Size = new Size(192, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name (surname, first name)";
            // 
            // OfficePhone
            // 
            OfficePhone.AutoSize = true;
            OfficePhone.ForeColor = SystemColors.Highlight;
            OfficePhone.Location = new Point(499, 77);
            OfficePhone.Name = "OfficePhone";
            OfficePhone.Size = new Size(95, 20);
            OfficePhone.TabIndex = 2;
            OfficePhone.Text = "Office phone";
            // 
            // Officeemail
            // 
            Officeemail.AutoSize = true;
            Officeemail.ForeColor = SystemColors.Highlight;
            Officeemail.Location = new Point(734, 77);
            Officeemail.Name = "Officeemail";
            Officeemail.Size = new Size(100, 20);
            Officeemail.TabIndex = 3;
            Officeemail.Text = "Office e- mail";
            // 
            // ContactDetails
            // 
            ContactDetails.AutoSize = true;
            ContactDetails.ForeColor = SystemColors.Highlight;
            ContactDetails.Location = new Point(1082, 77);
            ContactDetails.Name = "ContactDetails";
            ContactDetails.Size = new Size(108, 20);
            ContactDetails.TabIndex = 5;
            ContactDetails.Text = "Contact details";
            // 
            // listView1
            // 
            listView1 = new System.Windows.Forms.ListView();
            listView1.View = View.Details;
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.Columns.Add("", 150);  // Label column with width 150
            listView1.Columns.Add("", 300);
            listView1.BackColor = SystemColors.Menu;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.ForeColor = SystemColors.Highlight;
            listView1.Location = new Point(950, 123);  // Position on the right side
            listView1.Name = "listView1";
            listView1.Size = new Size(379, 460);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlDark;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(101, 613);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ControlDark;
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatAppearance.BorderSize = 2;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(354, 613);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 50);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(600, 613);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 50);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lstboxDisplay
            // 
            lstboxDisplay.FormattingEnabled = true;
            lstboxDisplay.Location = new Point(61, 123);
            lstboxDisplay.Name = "lstboxDisplay";
            lstboxDisplay.Size = new Size(883, 444);
            lstboxDisplay.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 689);
            Controls.Add(lstboxDisplay);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(listView1);
            Controls.Add(ContactDetails);
            Controls.Add(Officeemail);
            Controls.Add(OfficePhone);
            Controls.Add(lblName);
            Controls.Add(ID);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private Label lblName; // Renamed from Name
        private Label OfficePhone;
        private Label Officeemail;
        private Label ContactDetails;
        private ListView listView1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private ListBox lstboxDisplay;
    }
}
