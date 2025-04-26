namespace Assignment5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            panel1 = new Panel();
            lblTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ID.ForeColor = Color.FromArgb(0, 99, 177);
            ID.Location = new Point(61, 139);
            ID.Name = "ID";
            ID.Size = new Size(31, 23);
            ID.TabIndex = 0;
            ID.Text = "ID";
            
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(0, 99, 177);
            lblName.Location = new Point(201, 139);
            lblName.Name = "lblName";
            lblName.Size = new Size(218, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name (surname, first name)";
            
            // 
            // OfficePhone
            // 
            OfficePhone.AutoSize = true;
            OfficePhone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            OfficePhone.ForeColor = Color.FromArgb(0, 99, 177);
            OfficePhone.Location = new Point(499, 139);
            OfficePhone.Name = "OfficePhone";
            OfficePhone.Size = new Size(120, 23);
            OfficePhone.TabIndex = 2;
            OfficePhone.Text = "Office phone";
            
            // 
            // Officeemail
            // 
            Officeemail.AutoSize = true;
            Officeemail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Officeemail.ForeColor = Color.FromArgb(0, 99, 177);
            Officeemail.Location = new Point(734, 139);
            Officeemail.Name = "Officeemail";
            Officeemail.Size = new Size(128, 23);
            Officeemail.TabIndex = 3;
            Officeemail.Text = "Office e-mail";
            
            // 
            // ContactDetails
            // 
            ContactDetails.AutoSize = true;
            ContactDetails.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ContactDetails.ForeColor = Color.FromArgb(0, 99, 177);
            ContactDetails.Location = new Point(1082, 139);
            ContactDetails.Name = "ContactDetails";
            ContactDetails.Size = new Size(135, 23);
            ContactDetails.TabIndex = 5;
            ContactDetails.Text = "Contact details";
            
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(240, 248, 255);
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Columns.Add("", 150);
            listView1.Columns.Add("", 300);
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.ForeColor = Color.FromArgb(50, 50, 80);
            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.Location = new Point(950, 174);
            listView1.Name = "listView1";
            listView1.Size = new Size(379, 410);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 139, 87);
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(101, 613);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(70, 130, 180);
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(354, 613);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 50);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(600, 613);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 50);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            
            // 
            // lstboxDisplay
            // 
            lstboxDisplay.BackColor = Color.FromArgb(240, 248, 255);
            lstboxDisplay.BorderStyle = BorderStyle.FixedSingle;
            lstboxDisplay.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstboxDisplay.ForeColor = Color.FromArgb(50, 50, 80);
            lstboxDisplay.FormattingEnabled = true;
            lstboxDisplay.ItemHeight = 23;
            lstboxDisplay.Location = new Point(61, 174);
            lstboxDisplay.Name = "lstboxDisplay";
            lstboxDisplay.Size = new Size(883, 410);
            lstboxDisplay.TabIndex = 10;
            
            // panel1 - Header panel
            //
            panel1.BackColor = Color.FromArgb(0, 99, 177);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1362, 80);
            panel1.TabIndex = 12;
            
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(61, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(346, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer Registry";
            
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1362, 689);
            Controls.Add(panel1);
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
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            Name = "MainForm";
            Text = "Customer Registry By Manish Raj Moriche";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label lblTitle;
    }
}
