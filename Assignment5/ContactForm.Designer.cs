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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            grpBoxName.SuspendLayout();
            grpBoxemail.SuspendLayout();
            grpBoxAddress.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxName
            // 
            grpBoxName.Controls.Add(txtBoxLastName);
            grpBoxName.Controls.Add(lblLastName);
            grpBoxName.Controls.Add(lblFirstName);
            grpBoxName.Controls.Add(txtBoxFirstName);
            grpBoxName.Location = new Point(64, 36);
            grpBoxName.Name = "grpBoxName";
            grpBoxName.Size = new Size(586, 155);
            grpBoxName.TabIndex = 0;
            grpBoxName.TabStop = false;
            grpBoxName.Text = "Name";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLastName.Location = new Point(161, 101);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(402, 27);
            txtBoxLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(29, 103);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(82, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last name*";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(28, 44);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(83, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First name*";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFirstName.Location = new Point(161, 42);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(402, 27);
            txtBoxFirstName.TabIndex = 0;
            // 
            // grpBoxemail
            // 
            grpBoxemail.Controls.Add(txtBoxEmailPrivate);
            grpBoxemail.Controls.Add(txtBoxEmailBusiness);
            grpBoxemail.Controls.Add(txtBoxCellPhone);
            grpBoxemail.Controls.Add(txtBoxHomePhone);
            grpBoxemail.Controls.Add(lblEmailPrivate);
            grpBoxemail.Controls.Add(lblEmailBusiness);
            grpBoxemail.Controls.Add(lblCellPhone);
            grpBoxemail.Controls.Add(lblHomePhone);
            grpBoxemail.Location = new Point(64, 214);
            grpBoxemail.Name = "grpBoxemail";
            grpBoxemail.Size = new Size(586, 237);
            grpBoxemail.TabIndex = 1;
            grpBoxemail.TabStop = false;
            grpBoxemail.Text = "E-mail and phone";
            // 
            // txtBoxEmailPrivate
            // 
            txtBoxEmailPrivate.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEmailPrivate.Location = new Point(161, 185);
            txtBoxEmailPrivate.Name = "txtBoxEmailPrivate";
            txtBoxEmailPrivate.Size = new Size(402, 27);
            txtBoxEmailPrivate.TabIndex = 7;
            // 
            // txtBoxEmailBusiness
            // 
            txtBoxEmailBusiness.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEmailBusiness.Location = new Point(161, 135);
            txtBoxEmailBusiness.Name = "txtBoxEmailBusiness";
            txtBoxEmailBusiness.Size = new Size(402, 27);
            txtBoxEmailBusiness.TabIndex = 6;
            // 
            // txtBoxCellPhone
            // 
            txtBoxCellPhone.BorderStyle = BorderStyle.FixedSingle;
            txtBoxCellPhone.Location = new Point(161, 88);
            txtBoxCellPhone.Name = "txtBoxCellPhone";
            txtBoxCellPhone.Size = new Size(402, 27);
            txtBoxCellPhone.TabIndex = 5;
            // 
            // txtBoxHomePhone
            // 
            txtBoxHomePhone.BorderStyle = BorderStyle.FixedSingle;
            txtBoxHomePhone.Location = new Point(161, 42);
            txtBoxHomePhone.Name = "txtBoxHomePhone";
            txtBoxHomePhone.Size = new Size(402, 27);
            txtBoxHomePhone.TabIndex = 4;
            // 
            // lblEmailPrivate
            // 
            lblEmailPrivate.AutoSize = true;
            lblEmailPrivate.Location = new Point(28, 188);
            lblEmailPrivate.Name = "lblEmailPrivate";
            lblEmailPrivate.Size = new Size(105, 20);
            lblEmailPrivate.TabIndex = 3;
            lblEmailPrivate.Text = "E-mail, private";
            // 
            // lblEmailBusiness
            // 
            lblEmailBusiness.AutoSize = true;
            lblEmailBusiness.Location = new Point(28, 138);
            lblEmailBusiness.Name = "lblEmailBusiness";
            lblEmailBusiness.Size = new Size(114, 20);
            lblEmailBusiness.TabIndex = 2;
            lblEmailBusiness.Text = "E-mail, business";
            // 
            // lblCellPhone
            // 
            lblCellPhone.AutoSize = true;
            lblCellPhone.Location = new Point(29, 91);
            lblCellPhone.Name = "lblCellPhone";
            lblCellPhone.Size = new Size(80, 20);
            lblCellPhone.TabIndex = 1;
            lblCellPhone.Text = "Cell phone";
            // 
            // lblHomePhone
            // 
            lblHomePhone.AutoSize = true;
            lblHomePhone.Location = new Point(29, 45);
            lblHomePhone.Name = "lblHomePhone";
            lblHomePhone.Size = new Size(96, 20);
            lblHomePhone.TabIndex = 0;
            lblHomePhone.Text = "Home phone";
            // 
            // grpBoxAddress
            // 
            grpBoxAddress.Controls.Add(TxtBoxZipCode);
            grpBoxAddress.Controls.Add(txtBoxCity);
            grpBoxAddress.Controls.Add(txtBoxStreet);
            grpBoxAddress.Controls.Add(lblCountries);
            grpBoxAddress.Controls.Add(cmbBoxCountries);
            grpBoxAddress.Controls.Add(lblZipCode);
            grpBoxAddress.Controls.Add(lblCity);
            grpBoxAddress.Controls.Add(lblStreet);
            grpBoxAddress.Location = new Point(64, 480);
            grpBoxAddress.Name = "grpBoxAddress";
            grpBoxAddress.Size = new Size(586, 208);
            grpBoxAddress.TabIndex = 2;
            grpBoxAddress.TabStop = false;
            grpBoxAddress.Text = "Address";
            // 
            // TxtBoxZipCode
            // 
            TxtBoxZipCode.BorderStyle = BorderStyle.FixedSingle;
            TxtBoxZipCode.Location = new Point(161, 119);
            TxtBoxZipCode.Name = "TxtBoxZipCode";
            TxtBoxZipCode.Size = new Size(402, 27);
            TxtBoxZipCode.TabIndex = 7;
            // 
            // txtBoxCity
            // 
            txtBoxCity.BorderStyle = BorderStyle.FixedSingle;
            txtBoxCity.Location = new Point(161, 81);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(402, 27);
            txtBoxCity.TabIndex = 6;
            // 
            // txtBoxStreet
            // 
            txtBoxStreet.BorderStyle = BorderStyle.FixedSingle;
            txtBoxStreet.Location = new Point(161, 40);
            txtBoxStreet.Name = "txtBoxStreet";
            txtBoxStreet.Size = new Size(402, 27);
            txtBoxStreet.TabIndex = 5;
            // 
            // lblCountries
            // 
            lblCountries.AutoSize = true;
            lblCountries.Location = new Point(29, 162);
            lblCountries.Name = "lblCountries";
            lblCountries.Size = new Size(66, 20);
            lblCountries.TabIndex = 4;
            lblCountries.Text = "Country*";
            // 
            // cmbBoxCountries
            // 
            cmbBoxCountries.FormattingEnabled = true;
            cmbBoxCountries.Location = new Point(161, 159);
            cmbBoxCountries.Name = "cmbBoxCountries";
            cmbBoxCountries.Size = new Size(402, 28);
            cmbBoxCountries.TabIndex = 3;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(28, 122);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(68, 20);
            lblZipCode.TabIndex = 2;
            lblZipCode.Text = "Zip code";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(29, 84);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(40, 20);
            lblCity.TabIndex = 1;
            lblCity.Text = "City*";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(29, 43);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(48, 20);
            lblStreet.TabIndex = 0;
            lblStreet.Text = "Street";
            // 
            // btnContactOK
            // 
            btnContactOK.BackColor = SystemColors.ControlDark;
            btnContactOK.FlatStyle = FlatStyle.Popup;
            btnContactOK.Location = new Point(176, 725);
            btnContactOK.Name = "btnContactOK";
            btnContactOK.Size = new Size(157, 29);
            btnContactOK.TabIndex = 3;
            btnContactOK.Text = "OK";
            btnContactOK.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(457, 725);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 691);
            label1.Name = "label1";
            label1.Size = new Size(267, 20);
            label1.TabIndex = 5;
            label1.Text = "Fields labeled with an * are mandatory.";
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 766);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnContactOK);
            Controls.Add(grpBoxAddress);
            Controls.Add(grpBoxemail);
            Controls.Add(grpBoxName);
            Name = "ContactForm";
            Text = "ContactForm";
            grpBoxName.ResumeLayout(false);
            grpBoxName.PerformLayout();
            grpBoxemail.ResumeLayout(false);
            grpBoxemail.PerformLayout();
            grpBoxAddress.ResumeLayout(false);
            grpBoxAddress.PerformLayout();
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
    }
}