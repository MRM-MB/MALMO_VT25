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
        grpMain = new GroupBox();
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

        // Form settings - increase size for better spacing
        this.Text = "Super Mega Calculator by Manish";
        this.Size = new Size(900, 1000);
        this.StartPosition = FormStartPosition.CenterScreen;

        // Main group box - increase size
        grpMain.Text = "Daily Water Intake";
        grpMain.Size = new Size(860, 940);
        grpMain.Location = new Point(20, 20);

        // Personal info group - adjust spacing
        grpPersonal.Text = "Personal Information";
        grpPersonal.Size = new Size(400, 180);
        grpPersonal.Location = new Point(30, 40);

        // Labels and textboxes - increase vertical spacing
        lblName.Text = "Name";
        lblName.Location = new Point(30, 40);
        txtName.Location = new Point(160, 37);
        txtName.Size = new Size(195, 25);

        lblHeight.Text = "Height (cm)";
        lblHeight.Location = new Point(30, 80);
        lblHeight.AutoSize = true;
        txtHeight.Location = new Point(160, 77);
        txtHeight.Size = new Size(95, 25);

        txtHeightInches.Location = new Point(260, 77);
        txtHeightInches.Size = new Size(95, 25);
        txtHeightInches.Visible = false;

        lblWeight.Text = "Weight (kg)";
        lblWeight.Location = new Point(30, 120);
        txtWeight.Location = new Point(160, 117);
        txtWeight.Size = new Size(95, 25);

        // Gender group - adjust position
        grpGender.Text = "Gender";
        grpGender.Size = new Size(400, 80);
        grpGender.Location = new Point(30, 240);

        rdoFemale.Text = "Female";
        rdoFemale.Location = new Point(40, 35);
        rdoFemale.Width = 100;
        rdoFemale.Checked = true;

        rdoMale.Text = "Male";
        rdoMale.Location = new Point(200, 35);
        rdoMale.Width = 100;

        // Units group - adjust position
        grpUnits.Text = "Units";
        grpUnits.Size = new Size(400, 80);
        grpUnits.Location = new Point(30, 340);

        rdoMetric.Text = "Metric (kg, cm)";
        rdoMetric.Location = new Point(40, 35);
        rdoMetric.Width = 130;
        rdoMetric.Checked = true;

        rdoImperial.Text = "Imperial (ft, lbs)";
        rdoImperial.Location = new Point(200, 35);
        rdoImperial.Width = 150;

        // Other data group - adjust position and size
        grpOther.Text = "Other Data";
        grpOther.Size = new Size(400, 120);
        grpOther.Location = new Point(30, 440);

        lblActivityLevel.Text = "Activity Level";
        lblActivityLevel.Location = new Point(30, 40);
        cboActivityLevel.Location = new Point(160, 37);
        cboActivityLevel.Size = new Size(200, 25);
        cboActivityLevel.DropDownStyle = ComboBoxStyle.DropDownList;

        lblBirthYear.Text = "Birth Year";
        lblBirthYear.Location = new Point(30, 80);
        txtBirthYear.Location = new Point(160, 77);
        txtBirthYear.Size = new Size(100, 25);

        // Calculate button - adjust position
        btnCalculate.Text = "Calculate";
        btnCalculate.Location = new Point(30, 580);
        btnCalculate.Size = new Size(400, 40);

        // Results group - adjust position and size
        grpResults.Text = "Water Intake Calculator";
        grpResults.Size = new Size(400, 580);
        grpResults.Location = new Point(450, 40);

        txtResults.Size = new Size(380, 540);
        txtResults.Location = new Point(10, 25);
        txtResults.ReadOnly = true;
        txtResults.Font = new Font("Arial", 12);

        // Retirement group box - adjust position
        grpRetirement.Text = "Retirement Savings Calculator";
        grpRetirement.Size = new Size(400, 280);
        grpRetirement.Location = new Point(30, 640);

        // Retirement controls - adjust spacing
        lblCurrentSavings.Text = "Current Savings";
        lblCurrentSavings.Location = new Point(30, 40);
        txtCurrentSavings.Location = new Point(180, 37);
        txtCurrentSavings.Size = new Size(180, 25);

        lblMonthlySaving.Text = "Monthly Saving";
        lblMonthlySaving.Location = new Point(30, 80);
        txtMonthlySaving.Location = new Point(180, 77);
        txtMonthlySaving.Size = new Size(180, 25);

        lblAnnualInterest.Text = "Annual Interest (%)";
        lblAnnualInterest.Location = new Point(30, 120);
        txtAnnualInterest.Location = new Point(180, 117);
        txtAnnualInterest.Size = new Size(180, 25);

        lblRetirementAge.Text = "Retirement Age";
        lblRetirementAge.Location = new Point(30, 160);
        cboRetirementAge.Location = new Point(180, 157);
        cboRetirementAge.Size = new Size(180, 25);
        cboRetirementAge.DropDownStyle = ComboBoxStyle.DropDownList;

        btnCalculateRetirement.Text = "Calculate Retirement Savings";
        btnCalculateRetirement.Location = new Point(30, 200);
        btnCalculateRetirement.Size = new Size(350, 40);

        // Future values group box - adjust position and spacing
        grpFutureValues.Text = "Future Values";
        grpFutureValues.Size = new Size(400, 280);
        grpFutureValues.Location = new Point(450, 640);

        // Future values labels - adjust spacing
        int futureValueLabelX = 30;
        int futureValueValueX = 200;
        int baseY = 40;
        int spacing = 40;

        lblYearsToRetirement.Text = "Years to Retirement";
        lblYearsToRetirement.Location = new Point(futureValueLabelX, baseY);
        lblYearsToRetirementValue.Location = new Point(futureValueValueX, baseY);
        lblYearsToRetirementValue.Size = new Size(180, 25);

        lblTotalFutureAmount.Text = "Total Future Amount";
        lblTotalFutureAmount.Location = new Point(futureValueLabelX, baseY + spacing);
        lblTotalFutureAmountValue.Location = new Point(futureValueValueX, baseY + spacing);
        lblTotalFutureAmountValue.Size = new Size(180, 25);

        lblTotalInvestment.Text = "Total Investment";
        lblTotalInvestment.Location = new Point(futureValueLabelX, baseY + spacing * 2);
        lblTotalInvestmentValue.Location = new Point(futureValueValueX, baseY + spacing * 2);
        lblTotalInvestmentValue.Size = new Size(180, 25);

        lblTotalInterest.Text = "Total Interest";
        lblTotalInterest.Location = new Point(futureValueLabelX, baseY + spacing * 3);
        lblTotalInterestValue.Location = new Point(futureValueValueX, baseY + spacing * 3);
        lblTotalInterestValue.Size = new Size(180, 25);

        lblGrowthPercentage.Text = "Growth (%)";
        lblGrowthPercentage.Location = new Point(futureValueLabelX, baseY + spacing * 4);
        lblGrowthPercentageValue.Location = new Point(futureValueValueX, baseY + spacing * 4);
        lblGrowthPercentageValue.Size = new Size(180, 25);

        // Add controls to form
        grpPersonal.Controls.AddRange(new Control[] { lblName, txtName, lblHeight, txtHeight, txtHeightInches, lblWeight, txtWeight });
        grpGender.Controls.AddRange(new Control[] { rdoFemale, rdoMale });
        grpUnits.Controls.AddRange(new Control[] { rdoMetric, rdoImperial });
        grpOther.Controls.AddRange(new Control[] { lblActivityLevel, cboActivityLevel, lblBirthYear, txtBirthYear });
        grpResults.Controls.Add(txtResults);
        grpRetirement.Controls.AddRange(new Control[] { lblCurrentSavings, txtCurrentSavings, lblMonthlySaving, txtMonthlySaving, lblAnnualInterest, txtAnnualInterest, lblRetirementAge, cboRetirementAge, btnCalculateRetirement });
        grpFutureValues.Controls.AddRange(new Control[] { lblYearsToRetirement, lblYearsToRetirementValue, lblTotalFutureAmount, lblTotalFutureAmountValue, lblTotalInvestment, lblTotalInvestmentValue, lblTotalInterest, lblTotalInterestValue, lblGrowthPercentage, lblGrowthPercentageValue });
        grpMain.Controls.AddRange(new Control[] { grpPersonal, grpGender, grpUnits, grpOther, btnCalculate, grpResults, grpRetirement, grpFutureValues });
        this.Controls.Add(grpMain);

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
    }

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern bool SetProcessDPIAware();

    // Declare UI components
    private GroupBox grpMain;
    private GroupBox grpPersonal;
    private GroupBox grpGender;
    private GroupBox grpUnits;
    private GroupBox grpOther;
    private GroupBox grpResults;
    private GroupBox grpRetirement;
    private GroupBox grpFutureValues;
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