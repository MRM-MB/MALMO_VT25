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
        // Set DPI awareness mode
        this.AutoScaleDimensions = new SizeF(96F, 96F);
        this.AutoScaleMode = AutoScaleMode.Dpi;

        // Enable DPI awareness for better scaling
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            SetProcessDPIAware();
        }

        // Initialize components
        grpPersonal = new GroupBox();
        grpGender = new GroupBox();
        grpUnits = new GroupBox();
        grpOther = new GroupBox();
        grpResults = new GroupBox();
        grpRetirement = new GroupBox();
        grpFutureValues = new GroupBox();
        lblName = new Label();
        lblHeight = new Label();
        lblWeight = new Label();
        lblBirthYear = new Label();
        lblHeightInches = new Label();
        lblInitialInvestment = new Label();
        lblMonthlyContribution = new Label();
        lblAnnualInterestRate = new Label();
        lblRetirementAge = new Label();
        lblCurrentSavings = new Label();
        lblMonthlySaving = new Label();
        lblAnnualInterest = new Label();
        lblYearsToRetirement = new Label();
        lblTotalFutureAmount = new Label();
        lblTotalInvestment = new Label();
        lblTotalInterest = new Label();
        lblGrowthPercentage = new Label();
        txtName = new TextBox();
        txtHeight = new TextBox();
        txtHeightInches = new TextBox();
        txtWeight = new TextBox();
        txtBirthYear = new TextBox();
        txtInitialInvestment = new TextBox();
        txtMonthlyContribution = new TextBox();
        txtAnnualInterestRate = new TextBox();
        txtCurrentSavings = new TextBox();
        txtMonthlySaving = new TextBox();
        txtAnnualInterest = new TextBox();
        rdoFemale = new RadioButton();
        rdoMale = new RadioButton();
        rdoMetric = new RadioButton();
        rdoImperial = new RadioButton();
        cboActivityLevel = new ComboBox();
        cboRetirementAge = new ComboBox();
        lblActivityLevel = new Label();
        btnCalculate = new Button();
        btnCalculateRetirement = new Button();
        txtResults = new RichTextBox();
        txtRetirementResults = new RichTextBox();
        lblYearsToRetirementValue = new Label();
        lblTotalFutureAmountValue = new Label();
        lblTotalInvestmentValue = new Label();
        lblTotalInterestValue = new Label();
        lblGrowthPercentageValue = new Label();
        grpWaterIntakeCalculator = new GroupBox();
        grpRetirementSavingsCalculator = new GroupBox();

        // Form settings
        this.Text = "Super Mega Calculator by Manish";
        this.Size = new Size(820, 900);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Water Intake Calculator group box
        grpWaterIntakeCalculator.Text = "Water Intake Calculator";
        grpWaterIntakeCalculator.Size = new Size(760, 500);
        grpWaterIntakeCalculator.Location = new Point(20, 20);

        // Personal info group
        grpPersonal.Text = "Personal Information";
        grpPersonal.Size = new Size(350, 150);
        grpPersonal.Location = new Point(10, 20);

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
        grpGender.Location = new Point(10, 180);

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
        grpUnits.Location = new Point(10, 260);

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
        grpOther.Location = new Point(10, 340);

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
        btnCalculate.Text = "Calculate Water Intake";
        btnCalculate.Location = new Point(10, 450);
        btnCalculate.Size = new Size(350, 40);

        // Results group
        grpResults.Text = "Water Intake Results";
        grpResults.Size = new Size(350, 470);
        grpResults.Location = new Point(380, 20);

        txtResults.Size = new Size(330, 430);
        txtResults.Location = new Point(10, 20);
        txtResults.ReadOnly = true;
        txtResults.Font = new Font("Arial", 12);

        // Retirement group box
        grpRetirement.Text = "Retirement Data";
        grpRetirement.Size = new Size(350, 250);
        grpRetirement.Location = new Point(10, 20);

        lblCurrentSavings.Text = "Current Savings";
        lblCurrentSavings.Location = new Point(20, 30);
        txtCurrentSavings.Location = new Point(180, 27);
        txtCurrentSavings.Size = new Size(150, 20);

        lblMonthlySaving.Text = "Monthly Saving";
        lblMonthlySaving.Location = new Point(20, 60);
        txtMonthlySaving.Location = new Point(180, 57);
        txtMonthlySaving.Size = new Size(150, 20);

        // Widen the Annual Interest label and adjust its layout
        lblAnnualInterest.Text = "Annual Interest (%)";
        lblAnnualInterest.Location = new Point(20, 90);
        lblAnnualInterest.Size = new Size(150, 20);
        lblAnnualInterest.AutoSize = true;
        txtAnnualInterest.Location = new Point(180, 87);
        txtAnnualInterest.Size = new Size(150, 20);

        lblRetirementAge.Text = "Retirement Age";
        lblRetirementAge.Location = new Point(20, 120);
        cboRetirementAge.Location = new Point(180, 117);
        cboRetirementAge.Size = new Size(150, 20);
        cboRetirementAge.DropDownStyle = ComboBoxStyle.DropDownList;

        btnCalculateRetirement.Text = "Calculate Retirement Savings";
        btnCalculateRetirement.Location = new Point(20, 180);
        btnCalculateRetirement.Size = new Size(310, 40);

        // Future values group box
        grpFutureValues.Text = "Future Values";
        grpFutureValues.Size = new Size(350, 250);
        grpFutureValues.Location = new Point(380, 20);

        // Adjust label widths and positions
        int labelLeftX = 20;
        int valueRightX = 170;
        int labelWidth = 150;    // Width for labels
        int valueWidth = 160;    // Width for value labels

        lblYearsToRetirement.Text = "Years to Retirement";
        lblYearsToRetirement.Location = new Point(labelLeftX, 30);
        lblYearsToRetirement.Size = new Size(labelWidth, 20);
        lblYearsToRetirement.AutoSize = true;
        lblYearsToRetirementValue.Location = new Point(valueRightX, 30);
        lblYearsToRetirementValue.Size = new Size(valueWidth, 20);

        lblTotalFutureAmount.Text = "Total Future Amount";
        lblTotalFutureAmount.Location = new Point(labelLeftX, 60);
        lblTotalFutureAmount.Size = new Size(labelWidth, 20);
        lblTotalFutureAmount.AutoSize = true;
        lblTotalFutureAmountValue.Location = new Point(valueRightX, 60);
        lblTotalFutureAmountValue.Size = new Size(valueWidth, 20);

        lblTotalInvestment.Text = "Total Investment";
        lblTotalInvestment.Location = new Point(labelLeftX, 90);
        lblTotalInvestment.Size = new Size(labelWidth, 20);
        lblTotalInvestment.AutoSize = true;
        lblTotalInvestmentValue.Location = new Point(valueRightX, 90);
        lblTotalInvestmentValue.Size = new Size(valueWidth, 20);

        lblTotalInterest.Text = "Total Interest";
        lblTotalInterest.Location = new Point(labelLeftX, 120);
        lblTotalInterest.Size = new Size(labelWidth, 20);
        lblTotalInterest.AutoSize = true;
        lblTotalInterestValue.Location = new Point(valueRightX, 120);
        lblTotalInterestValue.Size = new Size(valueWidth, 20);

        lblGrowthPercentage.Text = "Growth (%)";
        lblGrowthPercentage.Location = new Point(labelLeftX, 150);
        lblGrowthPercentage.Size = new Size(labelWidth, 20);
        lblGrowthPercentage.AutoSize = true;
        lblGrowthPercentageValue.Location = new Point(valueRightX, 150);
        lblGrowthPercentageValue.Size = new Size(valueWidth, 20);

        txtRetirementResults.Size = new Size(330, 430);
        txtRetirementResults.Location = new Point(10, 200);
        txtRetirementResults.ReadOnly = true;
        txtRetirementResults.Font = new Font("Arial", 12);

        // Retirement Savings Calculator group box
        grpRetirementSavingsCalculator.Text = "Retirement Savings Calculator";
        grpRetirementSavingsCalculator.Size = new Size(760, 287);
        grpRetirementSavingsCalculator.Location = new Point(20, 540);

        // Adjust locations of existing group boxes to fit inside the new group box
        grpRetirement.Location = new Point(10, 20);
        grpFutureValues.Location = new Point(380, 20);

        // Add existing group boxes to the new group box
        grpRetirementSavingsCalculator.Controls.AddRange(new Control[] { grpRetirement, grpFutureValues });

        // Add controls to form
        grpPersonal.Controls.AddRange(new Control[] { lblName, txtName, lblHeight, txtHeight, txtHeightInches, lblWeight, txtWeight });
        grpGender.Controls.AddRange(new Control[] { rdoFemale, rdoMale });
        grpUnits.Controls.AddRange(new Control[] { rdoMetric, rdoImperial });
        grpOther.Controls.AddRange(new Control[] { lblActivityLevel, cboActivityLevel, lblBirthYear, txtBirthYear });
        grpResults.Controls.Add(txtResults);
        grpRetirement.Controls.AddRange(new Control[] { lblCurrentSavings, txtCurrentSavings, lblMonthlySaving, txtMonthlySaving, lblAnnualInterest, txtAnnualInterest, lblRetirementAge, cboRetirementAge, btnCalculateRetirement });
        grpFutureValues.Controls.AddRange(new Control[] { lblYearsToRetirement, lblYearsToRetirementValue, lblTotalFutureAmount, lblTotalFutureAmountValue, lblTotalInvestment, lblTotalInvestmentValue, lblTotalInterest, lblTotalInterestValue, lblGrowthPercentage, lblGrowthPercentageValue });
        grpWaterIntakeCalculator.Controls.AddRange(new Control[] { grpPersonal, grpGender, grpUnits, grpOther, grpResults, btnCalculate });
        this.Controls.AddRange(new Control[] { grpWaterIntakeCalculator, grpRetirementSavingsCalculator });

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
    }

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool SetProcessDPIAware();

    // Declare UI components
    private GroupBox grpPersonal;
    private GroupBox grpGender;
    private GroupBox grpUnits;
    private GroupBox grpOther;
    private GroupBox grpResults;
    private GroupBox grpRetirement;
    private GroupBox grpFutureValues;
    private GroupBox grpWaterIntakeCalculator;
    private GroupBox grpRetirementSavingsCalculator;
    private Label lblName;
    private Label lblHeight;
    private Label lblWeight;
    private Label lblBirthYear;
    private Label lblHeightInches;
    private Label lblActivityLevel;
    private Label lblInitialInvestment;
    private Label lblMonthlyContribution;
    private Label lblAnnualInterestRate;
    private Label lblRetirementAge;
    private Label lblCurrentSavings;
    private Label lblMonthlySaving;
    private Label lblAnnualInterest;
    private Label lblYearsToRetirement;
    private Label lblTotalFutureAmount;
    private Label lblTotalInvestment;
    private Label lblTotalInterest;
    private Label lblGrowthPercentage;
    private TextBox txtName;
    private TextBox txtHeight;
    private TextBox txtHeightInches;
    private TextBox txtWeight;
    private TextBox txtBirthYear;
    private TextBox txtInitialInvestment;
    private TextBox txtMonthlyContribution;
    private TextBox txtAnnualInterestRate;
    private TextBox txtCurrentSavings;
    private TextBox txtMonthlySaving;
    private TextBox txtAnnualInterest;
    private RadioButton rdoFemale;
    private RadioButton rdoMale;
    private RadioButton rdoMetric;
    private RadioButton rdoImperial;
    private ComboBox cboActivityLevel;
    private ComboBox cboRetirementAge;
    private Button btnCalculate;
    private Button btnCalculateRetirement;
    private RichTextBox txtResults;
    private RichTextBox txtRetirementResults;
    private Label lblYearsToRetirementValue;
    private Label lblTotalFutureAmountValue;
    private Label lblTotalInvestmentValue;
    private Label lblTotalInterestValue;
    private Label lblGrowthPercentageValue;
}