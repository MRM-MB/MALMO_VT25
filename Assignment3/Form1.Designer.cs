namespace Assignment3;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        // Initialize components
        grpMain = new GroupBox();
        grpPersonal = new GroupBox();
        grpGender = new GroupBox();
        grpUnits = new GroupBox();
        grpOther = new GroupBox();
        grpResults = new GroupBox();
        lblName = new Label();
        lblHeight = new Label();
        lblWeight = new Label();
        lblBirthYear = new Label();
        lblHeightInches = new Label();
        txtName = new TextBox();
        txtHeight = new TextBox();
        txtHeightInches = new TextBox();
        txtWeight = new TextBox();
        txtBirthYear = new TextBox();
        rdoFemale = new RadioButton();
        rdoMale = new RadioButton();
        rdoMetric = new RadioButton();
        rdoImperial = new RadioButton();
        cboActivityLevel = new ComboBox();
        lblActivityLevel = new Label();
        btnCalculate = new Button();
        txtResults = new RichTextBox();

        // Form settings
        this.Text = "Super Mega Calculator by Manish";
        this.Size = new Size(800, 600);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Main group box
        grpMain.Text = "Daily Water Intake";
        grpMain.Size = new Size(760, 540);
        grpMain.Location = new Point(10, 10);

        // Personal info group
        grpPersonal.Text = "Personal Information";
        grpPersonal.Size = new Size(350, 150);
        grpPersonal.Location = new Point(20, 30);

        // Labels and textboxes
        lblName.Text = "Name";
        lblName.Location = new Point(20, 30);
        txtName.Location = new Point(120, 27);
        txtName.Size = new Size(195, 20);

        lblHeight.Text = "Height (cm)";
        lblHeight.Location = new Point(20, 60);
        lblHeight.AutoSize = true;
        txtHeight.Location = new Point(120, 57);
        txtHeight.Size = new Size(95, 20);

        txtHeightInches.Location = new Point(220, 57);
        txtHeightInches.Size = new Size(95, 20);
        txtHeightInches.Visible = false;

        lblWeight.Text = "Weight (kg)";
        lblWeight.Location = new Point(20, 90);
        txtWeight.Location = new Point(120, 87);
        txtWeight.Size = new Size(95, 20);

        // Gender group
        grpGender.Text = "Gender";
        grpGender.Size = new Size(350, 70);
        grpGender.Location = new Point(20, 190);

        rdoFemale.Text = "Female";
        rdoFemale.Location = new Point(30, 30);
        rdoFemale.Width = 80;
        rdoFemale.Checked = true;

        rdoMale.Text = "Male";
        rdoMale.Location = new Point(150, 30);
        rdoMale.Width = 80;

        // Units group
        grpUnits.Text = "Units";
        grpUnits.Size = new Size(350, 70);
        grpUnits.Location = new Point(20, 270);

        rdoMetric.Text = "Metric (kg, cm)";
        rdoMetric.Location = new Point(30, 30);
        rdoMetric.Width = 110;
        rdoMetric.Checked = true;

        rdoImperial.Text = "Imperial (ft, lbs)";
        rdoImperial.Location = new Point(150, 30);
        rdoImperial.Width = 150;

        // Other data group
        grpOther.Text = "Other Data";
        grpOther.Size = new Size(350, 100);
        grpOther.Location = new Point(20, 350);

        lblActivityLevel.Text = "Activity Level";
        lblActivityLevel.Location = new Point(20, 30);
        cboActivityLevel.Location = new Point(120, 27);
        cboActivityLevel.Size = new Size(200, 20);
        cboActivityLevel.DropDownStyle = ComboBoxStyle.DropDownList;

        lblBirthYear.Text = "Birth Year";
        lblBirthYear.Location = new Point(20, 60);
        txtBirthYear.Location = new Point(120, 57);
        txtBirthYear.Size = new Size(80, 20);

        // Calculate button
        btnCalculate.Text = "Calculate";
        btnCalculate.Location = new Point(20, 460);
        btnCalculate.Size = new Size(350, 40);

        // Results group
        grpResults.Text = "Water Intake Calculator";
        grpResults.Size = new Size(350, 470);
        grpResults.Location = new Point(390, 30);

        txtResults.Size = new Size(330, 430);
        txtResults.Location = new Point(10, 20);
        txtResults.ReadOnly = true;
        txtResults.Font = new Font("Arial", 12);

        // Add controls to form
        grpPersonal.Controls.AddRange(new Control[] { lblName, txtName, lblHeight, txtHeight, txtHeightInches, lblWeight, txtWeight });
        grpGender.Controls.AddRange(new Control[] { rdoFemale, rdoMale });
        grpUnits.Controls.AddRange(new Control[] { rdoMetric, rdoImperial });
        grpOther.Controls.AddRange(new Control[] { lblActivityLevel, cboActivityLevel, lblBirthYear, txtBirthYear });
        grpResults.Controls.Add(txtResults);
        grpMain.Controls.AddRange(new Control[] { grpPersonal, grpGender, grpUnits, grpOther, btnCalculate, grpResults });
        this.Controls.Add(grpMain);

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    }

    // Declare UI components
    private GroupBox grpMain;
    private GroupBox grpPersonal;
    private GroupBox grpGender;
    private GroupBox grpUnits;
    private GroupBox grpOther;
    private GroupBox grpResults;
    private Label lblName;
    private Label lblHeight;
    private Label lblWeight;
    private Label lblBirthYear;
    private Label lblHeightInches;
    private Label lblActivityLevel;
    private TextBox txtName;
    private TextBox txtHeight;
    private TextBox txtHeightInches;
    private TextBox txtWeight;
    private TextBox txtBirthYear;
    private RadioButton rdoFemale;
    private RadioButton rdoMale;
    private RadioButton rdoMetric;
    private RadioButton rdoImperial;
    private ComboBox cboActivityLevel;
    private Button btnCalculate;
    private RichTextBox txtResults;
}