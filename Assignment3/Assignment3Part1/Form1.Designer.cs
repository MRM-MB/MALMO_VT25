namespace Assignment3Part1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private GroupBox personalInfoGroupBox;
        private GroupBox otherDataGroupBox;
        private RadioButton rbtnFemale;
        private RadioButton rbtnMale;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblName;
        private TextBox txtName;
        private Label label1;
        private GroupBox groupBoxUnits;
        private RadioButton rbtnImperial;
        private RadioButton rbtnMetric;

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
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.otherDataGroupBox = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBoxUnits = new System.Windows.Forms.GroupBox();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.personalInfoGroupBox.SuspendLayout();
            this.otherDataGroupBox.SuspendLayout();
            this.groupBoxUnits.SuspendLayout();
            this.SuspendLayout();
            //
            // lblWeight
            //
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 97);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(66, 15);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight (kg):";
            //
            // txtWeight
            //
            this.txtWeight.Location = new System.Drawing.Point(87, 94);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 23);
            this.txtWeight.TabIndex = 2;
            //
            // lblHeight
            //
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(6, 68);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(64, 15);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height (cm):";
            //
            // txtHeight
            //
            this.txtHeight.Location = new System.Drawing.Point(87, 65);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 23);
            this.txtHeight.TabIndex = 4;
            //
            // lblBirthYear
            //
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(6, 26);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(60, 15);
            this.lblBirthYear.TabIndex = 5;
            this.lblBirthYear.Text = "Birth Year:";
            //
            // txtBirthYear
            //
            this.txtBirthYear.Location = new System.Drawing.Point(87, 23);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(100, 23);
            this.txtBirthYear.TabIndex = 6;
            //
            // lblGender
            //
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 57);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            //
            // cmbGender
            //
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(87, 54);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 23);
            this.cmbGender.TabIndex = 8;
            //
            // lblActivity
            //
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(6, 91);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(79, 15);
            this.lblActivity.TabIndex = 9;
            this.lblActivity.Text = "Activity Level:";
            //
            // cmbActivity
            //
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbActivity.Location = new System.Drawing.Point(87, 88);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(121, 23);
            this.cmbActivity.TabIndex = 10;
            //
            // btnCalculate
            //
            this.btnCalculate.Location = new System.Drawing.Point(127, 408);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 40);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            //
            // lblResult
            //
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 462);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 12;
            //
            // personalInfoGroupBox
            //
            this.personalInfoGroupBox.Controls.Add(this.label1);
            this.personalInfoGroupBox.Controls.Add(this.lblName);
            this.personalInfoGroupBox.Controls.Add(this.txtName);
            this.personalInfoGroupBox.Controls.Add(this.lblWeight);
            this.personalInfoGroupBox.Controls.Add(this.txtWeight);
            this.personalInfoGroupBox.Controls.Add(this.lblHeight);
            this.personalInfoGroupBox.Controls.Add(this.txtHeight);
            this.personalInfoGroupBox.Location = new System.Drawing.Point(12, 71);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Size = new System.Drawing.Size(214, 135);
            this.personalInfoGroupBox.TabIndex = 13;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Personal Info";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gender:";
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(87, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 5;
            //
            // otherDataGroupBox
            //
            this.otherDataGroupBox.Controls.Add(this.rbtnFemale);
            this.otherDataGroupBox.Controls.Add(this.rbtnMale);
            this.otherDataGroupBox.Controls.Add(this.lblBirthYear);
            this.otherDataGroupBox.Controls.Add(this.cmbActivity);
            this.otherDataGroupBox.Controls.Add(this.lblActivity);
            this.otherDataGroupBox.Controls.Add(this.txtBirthYear);
            this.otherDataGroupBox.Controls.Add(this.lblGender);
            this.otherDataGroupBox.Controls.Add(this.cmbGender);
            this.otherDataGroupBox.Location = new System.Drawing.Point(232, 71);
            this.otherDataGroupBox.Name = "otherDataGroupBox";
            this.otherDataGroupBox.Size = new System.Drawing.Size(214, 135);
            this.otherDataGroupBox.TabIndex = 14;
            this.otherDataGroupBox.TabStop = false;
            this.otherDataGroupBox.Text = "Other Data";
            //
            // rbtnFemale
            //
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(144, 55);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(63, 19);
            this.rbtnFemale.TabIndex = 12;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            //
            // rbtnMale
            //
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(87, 55);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(51, 19);
            this.rbtnMale.TabIndex = 11;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            //
            // lblUsername
            //
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(18, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 15);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username:";
            //
            // txtUsername
            //
            this.txtUsername.Location = new System.Drawing.Point(87, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 23);
            this.txtUsername.TabIndex = 16;
            //
            // groupBoxUnits
            //
            this.groupBoxUnits.Controls.Add(this.rbtnImperial);
            this.groupBoxUnits.Controls.Add(this.rbtnMetric);
            this.groupBoxUnits.Location = new System.Drawing.Point(12, 225);
            this.groupBoxUnits.Name = "groupBoxUnits";
            this.groupBoxUnits.Size = new System.Drawing.Size(214, 80);
            this.groupBoxUnits.TabIndex = 17;
            this.groupBoxUnits.TabStop = false;
            this.groupBoxUnits.Text = "Units";
            //
            // rbtnImperial
            //
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Location = new System.Drawing.Point(111, 39);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(66, 19);
            this.rbtnImperial.TabIndex = 1;
            this.rbtnImperial.Text = "Imperial";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            this.rbtnImperial.CheckedChanged += new System.EventHandler(this.rbtnImperial_CheckedChanged);
            //
            // rbtnMetric
            //
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(6, 39);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(58, 19);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.Text = "Metric";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 506);
            this.Controls.Add(this.groupBoxUnits);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.otherDataGroupBox);
            this.Controls.Add(this.personalInfoGroupBox);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Water Intake Calculator";
            this.personalInfoGroupBox.ResumeLayout(false);
            this.personalInfoGroupBox.PerformLayout();
            this.otherDataGroupBox.ResumeLayout(false);
            this.otherDataGroupBox.PerformLayout();
            this.groupBoxUnits.ResumeLayout(false);
            this.groupBoxUnits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}