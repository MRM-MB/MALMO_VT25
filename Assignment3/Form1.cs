namespace Assignment3;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        InitializeActivityLevels();
        SetupEventHandlers();
    }

    private void InitializeActivityLevels()
    {
        cboActivityLevel.Items.AddRange(new string[] { "Low", "Medium", "High" });
        cboActivityLevel.SelectedIndex = 0;
    }

    private void SetupEventHandlers()
    {
        btnCalculate.Click += BtnCalculate_Click;
        rdoMetric.CheckedChanged += UnitSystem_CheckedChanged;
        rdoImperial.CheckedChanged += UnitSystem_CheckedChanged;
    }

    private void UnitSystem_CheckedChanged(object? sender, EventArgs e)
    {
        lblHeight.Text = rdoMetric.Checked ? "Height (cm)" : "Height (ft and in)";
        
        if (rdoMetric.Checked)
        {
            txtHeightInches.Visible = false;
            // Removed the size change to maintain consistent width
        }
        else
        {
            txtHeightInches.Visible = true;
            // Removed the size change to maintain consistent width
        }
    }

    private void BtnCalculate_Click(object? sender, EventArgs e)
    {
        if (!ValidateInputs()) return;

        var person = new Person
        {
            Name = txtName.Text,
            Height = decimal.Parse(txtHeight.Text),
            HeightInches = rdoMetric.Checked ? 0m : decimal.Parse(txtHeightInches.Text),
            Weight = decimal.Parse(txtWeight.Text),
            BirthYear = int.Parse(txtBirthYear.Text),
            Gender = rdoFemale.Checked ? Gender.Female : Gender.Male,
            ActivityLevel = (ActivityLevel)cboActivityLevel.SelectedIndex,
            UnitSystem = rdoMetric.Checked ? UnitSystem.Metric : UnitSystem.Imperial
        };

        var calculator = new WaterIntakeCalculator(person);
        var (amount, glasses) = calculator.Calculate();

        DisplayResults(person.Name, amount, glasses, person.UnitSystem == UnitSystem.Metric);
    }

    private void DisplayResults(string name, decimal amount, int glasses, bool isMetric)
    {
        string unitText = isMetric ? "milliliters (ml)" : "ounces (oz)";
        string perGlassText = isMetric ? "240 ml" : "8.1 oz";
        
        txtResults.Clear();
        
        // Single line header
        txtResults.SelectionBackColor = Color.White;
        txtResults.SelectionColor = Color.RoyalBlue;
        txtResults.SelectionFont = new Font("Arial", 16, FontStyle.Bold);
        txtResults.AppendText($"\n Water Report for {name} \n");
        txtResults.AppendText("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n\n");

        // Box for main result - enhanced visibility
        txtResults.SelectionFont = new Font("Arial", 15, FontStyle.Bold);
        txtResults.SelectionColor = Color.Black;  // Changed to black
        txtResults.AppendText($" 📊 Daily Recommended Intake \n\n");
        txtResults.SelectionBackColor = Color.MintCream;
        txtResults.SelectionFont = new Font("Arial", 13, FontStyle.Bold);  // Slightly bigger
        txtResults.SelectionColor = Color.ForestGreen;  // Keep green for the amount
        txtResults.AppendText($" {amount:F1} {unitText} \n\n");

        // Glasses count first, then visualization
        txtResults.SelectionBackColor = Color.AliceBlue;
        txtResults.SelectionFont = new Font("Arial", 13, FontStyle.Bold);
        txtResults.SelectionColor = Color.DarkBlue;
        txtResults.AppendText($" {glasses} glasses of water ({perGlassText} each) \n\n");
        
        // Show glass emojis after the count
        txtResults.SelectionColor = Color.RoyalBlue;
        string glassEmoji = "";
        for (int i = 0; i < glasses; i++)
            glassEmoji += "🥤";
        txtResults.AppendText($" {glassEmoji}\n\n\n");

        // Quick tip with subtle background
        txtResults.SelectionBackColor = Color.Ivory;
        txtResults.SelectionFont = new Font("Arial", 10, FontStyle.Italic);
        txtResults.SelectionColor = Color.DarkSlateGray;
        txtResults.AppendText(" 💡 Tip: Space out your water intake evenly throughout the day ");

        // Reset formatting
        txtResults.SelectionBackColor = Color.White;
        txtResults.SelectionColor = Color.Black;
    }

    private bool ValidateInputs()
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Please enter your name.", "Validation Error");
            return false;
        }

        if (!int.TryParse(txtBirthYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year)
        {
            MessageBox.Show("Please enter a valid birth year.", "Validation Error");
            return false;
        }

        if (!double.TryParse(txtWeight.Text, out _))
        {
            MessageBox.Show("Please enter a valid weight.", "Validation Error");
            return false;
        }

        if (!double.TryParse(txtHeight.Text, out _))
        {
            MessageBox.Show("Please enter a valid height.", "Validation Error");
            return false;
        }

        if (!rdoMetric.Checked && !double.TryParse(txtHeightInches.Text, out _))
        {
            MessageBox.Show("Please enter a valid height in inches.", "Validation Error");
            return false;
        }

        return true;
    }
}
