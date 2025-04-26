namespace Assignment5
{
    partial class ContactForm
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
            grpBoxName = new GroupBox();
            txtBoxLastName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtBoxFirstName = new TextBox();
            grpBoxemail = new GroupBox();
            txtBoxEmailPrivate = new TextBox();
            txtBoxEmailBusiness = new TextBox();
            txtBoxCellPhone = new TextBox();
            txtBoxHomePhone = new TextBox();
            lblEmailPrivate = new Label();
            lblEmailBusiness = new Label();
            lblCellPhone = new Label();
            lblHomePhone = new Label();
            grpBoxAddress = new GroupBox();
            TxtBoxZipCode = new TextBox();
            txtBoxCity = new TextBox();
            txtBoxStreet = new TextBox();
            lblCountries = new Label();
            cmbBoxCountries = new ComboBox();
            lblZipCode = new Label();
            lblCity = new Label();
            lblStreet = new Label();
            btnContactOK = new Button();
            button1 = new Button();
            label1 = new Label();
            panelHeader = new Panel();
            lblFormHeader = new Label();
            grpBoxName.SuspendLayout();
            grpBoxemail.SuspendLayout();
            grpBoxAddress.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(0, 99, 177);
            panelHeader.Controls.Add(lblFormHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(716, 58);
            panelHeader.TabIndex = 6;
            
            // 
            // lblFormHeader
            // 
            lblFormHeader.AutoSize = true;
            lblFormHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormHeader.ForeColor = Color.White;
            lblFormHeader.Location = new Point(22, 14);
            lblFormHeader.Name = "lblFormHeader";
            lblFormHeader.Size = new Size(202, 28);
            lblFormHeader.TabIndex = 0;
            lblFormHeader.Text = "Contact Details";
            
            // 
            // grpBoxName
            // 
            grpBoxName.BackColor = Color.White;
            grpBoxName.Controls.Add(txtBoxLastName);
            grpBoxName.Controls.Add(lblLastName);
            grpBoxName.Controls.Add(lblFirstName);
            grpBoxName.Controls.Add(txtBoxFirstName);
            grpBoxName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoxName.ForeColor = Color.FromArgb(0, 99, 177);
            grpBoxName.Location = new Point(64, 80);
            grpBoxName.Name = "grpBoxName";
            grpBoxName.Size = new Size(586, 155);
            grpBoxName.TabIndex = 0;
            grpBoxName.TabStop = false;
            grpBoxName.Text = "Name";
            
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = Color.FromArgb(240, 248, 255);
            txtBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLastName.Location = new Point(161, 101);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(402, 30);
            txtBoxLastName.TabIndex = 3;
            
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = Color.FromArgb(50, 50, 80);
            lblLastName.Location = new Point(29, 103);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(107, 23);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last name*";
            
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.FromArgb(50, 50, 80);
            lblFirstName.Location = new Point(28, 44);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 23);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First name*";
            
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.FromArgb(240, 248, 255);
            txtBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFirstName.Location = new Point(161, 42);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(402, 30);
            txtBoxFirstName.TabIndex = 0;
            
            // 
            // grpBoxemail
            // 
            grpBoxemail.BackColor = Color.White;
            grpBoxemail.Controls.Add(txtBoxEmailPrivate);
            grpBoxemail.Controls.Add(txtBoxEmailBusiness);
            grpBoxemail.Controls.Add(txtBoxCellPhone);
            grpBoxemail.Controls.Add(txtBoxHomePhone);
            grpBoxemail.Controls.Add(lblEmailPrivate);
            grpBoxemail.Controls.Add(lblEmailBusiness);
            grpBoxemail.Controls.Add(lblCellPhone);
            grpBoxemail.Controls.Add(lblHomePhone);
            grpBoxemail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoxemail.ForeColor = Color.FromArgb(0, 99, 177);
            grpBoxemail.Location = new Point(64, 254);
            grpBoxemail.Name = "grpBoxemail";
            grpBoxemail.Size = new Size(586, 237);
            grpBoxemail.TabIndex = 1;
            grpBoxemail.TabStop = false;
            grpBoxemail.Text = "Contact Information";
            
            // 
            // txtBoxEmailPrivate
            // 
            txtBoxEmailPrivate.BackColor = Color.FromArgb(240, 248, 255);
            txtBoxEmailPrivate.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEmailPrivate.Location = new Point(161, 185);
            txtBoxEmailPrivate.Name = "txtBoxEmailPrivate";
            txtBoxEmailPrivate.Size = new Size(402, 30);
            txtBoxEmailPrivate.TabIndex = 7;
            
            // 
            // txtBoxEmailBusiness
            // 
            txtBoxEmailBusiness.BackColor = Color.FromArgb(240, 248, 255);
            txtBoxEmailBusiness.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEmailBusiness.Location = new Point(161, 135);
            txtBoxEmailBusiness.Name = "txtBoxEmailBusiness";
            txtBoxEmailBusiness.Size = new Size(402, 30);
            txtBoxEmailBusiness.TabIndex = 6;
            
            // 
            // txtBoxCellPhone
            // 
            txtBoxCellPhone.BackColor = Color.FromArgb(240, 248, 255);
            txtBoxCellPhone.BorderStyle = BorderStyle.FixedSingle;
            txtBoxCellPhone.Location = new Point(161, 88);
            txtBoxCellPhone.Name = "txtBoxCellPhone";
            txtBoxCellPhone.Size = new Size(402, 30);
            txtBoxCellPhone.TabIndex = 5;
            
            // 
            // txtBoxHomePhone
            // 
            txtBoxHomePhone.BackColor = Color.FromArgb(240, 248, 255);
            txtBoxHomePhone.BorderStyle = BorderStyle.FixedSingle;
            txtBoxHomePhone.Location = new Point(161, 42);
            txtBoxHomePhone.Name = "txtBoxHomePhone";
            txtBoxHomePhone.Size = new Size(402, 30);
            txtBoxHomePhone.TabIndex = 4;
            
            // 
            // lblEmailPrivate
            // 
            lblEmailPrivate.AutoSize = true;
            lblEmailPrivate.ForeColor = Color.FromArgb(50, 50, 80);
            lblEmailPrivate.Location = new Point(28, 188);
            lblEmailPrivate.Name = "lblEmailPrivate";
            lblEmailPrivate.Size = new Size(121, 23);
            lblEmailPrivate.TabIndex = 3;
            lblEmailPrivate.Text = "Email, private";
            
            // 
            // lblEmailBusiness
            // 
            lblEmailBusiness.AutoSize = true;
            lblEmailBusiness.ForeColor = Color.FromArgb(50, 50, 80);
            lblEmailBusiness.Location = new Point(28, 138);
            lblEmailBusiness.Name = "lblEmailBusiness";
            lblEmailBusiness.Size = new Size(132, 23);
            lblEmailBusiness.TabIndex = 2;
            lblEmailBusiness.Text = "Email, business";
            
            // 
            // lblCellPhone
            // 
            lblCellPhone.AutoSize = true;
            lblCellPhone.ForeColor = Color.FromArgb(50, 50, 80);
            lblCellPhone.Location = new Point(29, 91);
            lblCellPhone.Name = "lblCellPhone";
            lblCellPhone.Size = new Size(102, 23);
            lblCellPhone.TabIndex = 1;
            lblCellPhone.Text = "Cell phone";
            
            // 
            // lblHomePhone
            // 
            lblHomePhone.AutoSize = true;
            lblHomePhone.ForeColor = Color.FromArgb(50, 50, 80);
            lblHomePhone.Location = new Point(29, 45);
            lblHomePhone.Name = "lblHomePhone";
            lblHomePhone.Size = new Size(119, 23);
            lblHomePhone.TabIndex = 0;
            lblHomePhone.Text = "Home phone";
            
            // 
            // grpBoxAddress
            // 
            grpBoxAddress.BackColor = Color.White;
            grpBoxAddress.Controls.Add(TxtBoxZipCode);
            grpBoxAddress.Controls.Add(txtBoxCity);
            grpBoxAddress.Controls.Add(txtBoxStreet);
            grpBoxAddress.Controls.Add(lblCountries);
            grpBoxAddress.Controls.Add(cmbBoxCountries);
            grpBoxAddress.Controls.Add(lblZipCode);
            grpBoxAddress.Controls.Add(lblCity);
            grpBoxAddress.Controls.Add(lblStreet);
            grpBoxAddress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoxAddress.ForeColor = Color.FromArgb(0, 99, 177);
            grpBoxAddress.Location = new Point(64, 510);
            grpBoxAddress.Name = "grpBoxAddress";
            grpBoxAddress.Size = new Size(586, 208);
            grpBoxAddress.TabIndex = 2;
            grpBoxAddress.TabStop = false;
            grpBoxAddress.Text = "Address";
            
            // 
            // TxtBoxZipCode
            // 
            TxtBoxZipCode.BackColor = Color.FromArgb(240, 248, 255);
            TxtBoxZipCode.BorderStyle = BorderStyle.FixedSingle;
            TxtBoxZipCode.Location = new Point(161, 119);
            TxtBoxZipCode.Name = "TxtBoxZipCode";
            TxtBoxZipCode.Size = new Size(402, 30);
            TxtBoxZipCode.TabIndex = 7;
            
            // 
            // txtBoxCity
            // 
            txtBoxCity.BackColor = Color.FromArgb(240, 248, 255);
            txtBoxCity.BorderStyle = BorderStyle.FixedSingle;
            txtBoxCity.Location = new Point(161, 81);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(402, 30);
            txtBoxCity.TabIndex = 6;
            
            // 
            // txtBoxStreet
            // 
            txtBoxStreet.BackColor = Color.FromArgb(240, 248, 255);
            txtBoxStreet.BorderStyle = BorderStyle.FixedSingle;
            txtBoxStreet.Location = new Point(161, 40);
            txtBoxStreet.Name = "txtBoxStreet";
            txtBoxStreet.Size = new Size(402, 30);
            txtBoxStreet.TabIndex = 5;
            
            // 
            // lblCountries
            // 
            lblCountries.AutoSize = true;
            lblCountries.ForeColor = Color.FromArgb(50, 50, 80);
            lblCountries.Location = new Point(29, 162);
            lblCountries.Name = "lblCountries";
            lblCountries.Size = new Size(98, 23);
            lblCountries.TabIndex = 4;
            lblCountries.Text = "Country*";
            
            // 
            // cmbBoxCountries
            // 
            cmbBoxCountries.BackColor = Color.FromArgb(240, 248, 255);
            cmbBoxCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCountries.FlatStyle = FlatStyle.Flat;
            cmbBoxCountries.FormattingEnabled = true;
            cmbBoxCountries.Location = new Point(161, 159);
            cmbBoxCountries.Name = "cmbBoxCountries";
            cmbBoxCountries.Size = new Size(402, 31);
            cmbBoxCountries.TabIndex = 3;
            
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.ForeColor = Color.FromArgb(50, 50, 80);
            lblZipCode.Location = new Point(28, 122);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(77, 23);
            lblZipCode.TabIndex = 2;
            lblZipCode.Text = "Zip code";
            
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.ForeColor = Color.FromArgb(50, 50, 80);
            lblCity.Location = new Point(29, 84);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(62, 23);
            lblCity.TabIndex = 1;
            lblCity.Text = "City*";
            
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.ForeColor = Color.FromArgb(50, 50, 80);
            lblStreet.Location = new Point(29, 43);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(67, 23);
            lblStreet.TabIndex = 0;
            lblStreet.Text = "Street";
            
            // 
            // btnContactOK
            // 
            btnContactOK.BackColor = Color.FromArgb(46, 139, 87);
            btnContactOK.FlatAppearance.BorderSize = 0;
            btnContactOK.FlatStyle = FlatStyle.Flat;
            btnContactOK.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnContactOK.ForeColor = Color.White;
            btnContactOK.Location = new Point(176, 746);
            btnContactOK.Name = "btnContactOK";
            btnContactOK.Size = new Size(157, 40);
            btnContactOK.TabIndex = 3;
            btnContactOK.Text = "OK";
            btnContactOK.UseVisualStyleBackColor = false;
            
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(169, 169, 169);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(457, 746);
            button1.Name = "button1";
            button1.Size = new Size(157, 40);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(169, 68, 66);
            label1.Location = new Point(64, 725);
            label1.Name = "label1";
            label1.Size = new Size(328, 20);
            label1.TabIndex = 5;
            label1.Text = "Fields labeled with an asterisk (*) are mandatory.";
            
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(716, 806);
            Controls.Add(panelHeader);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnContactOK);
            Controls.Add(grpBoxAddress);
            Controls.Add(grpBoxemail);
            Controls.Add(grpBoxName);
            Name = "ContactForm";
            Text = "Contact Details";
            grpBoxName.ResumeLayout(false);
            grpBoxName.PerformLayout();
            grpBoxemail.ResumeLayout(false);
            grpBoxemail.PerformLayout();
            grpBoxAddress.ResumeLayout(false);
            grpBoxAddress.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBoxName;
        private GroupBox grpBoxemail;
        private GroupBox grpBoxAddress;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtBoxFirstName;
        private Label lblEmailPrivate;
        private Label lblEmailBusiness;
        private Label lblCellPhone;
        private Label lblHomePhone;
        private TextBox txtBoxLastName;
        private TextBox txtBoxEmailPrivate;
        private TextBox txtBoxEmailBusiness;
        private TextBox txtBoxCellPhone;
        private TextBox txtBoxHomePhone;
        private TextBox TxtBoxZipCode;
        private TextBox txtBoxCity;
        private TextBox txtBoxStreet;
        private Label lblCountries;
        private ComboBox cmbBoxCountries;
        private Label lblZipCode;
        private Label lblCity;
        private Label lblStreet;
        private Button btnContactOK;
        private Button button1;
        private Label label1;
        private Panel panelHeader;
        private Label lblFormHeader;
    }
}