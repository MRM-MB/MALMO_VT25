using System;
using System.Windows.Forms;

namespace Assignment3Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set default unit to Metric
            rbtnMetric.Checked = true;
            UpdateUnitVisibility();

            //Set Default combo box
            cmbGender.SelectedIndex = 0;
            cmbActivity.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate Username
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Please enter a valid username.");
                    return;
                }

                double weight = ConvertToKilograms(double.Parse(txtWeight.Text));
                double height = ConvertToCentimeters(double.Parse(txtHeight.Text));
                int birthYear = int.Parse(txtBirthYear.Text);
                string gender = cmbGender.SelectedItem.ToString();
                string activityLevel = cmbActivity.SelectedItem.ToString();

                int age = DateTime.Now.Year - birthYear;

                // Base water intake
                double baseIntake = weight * 33; // ml per kg

                // Adjust for gender
                if (gender == "Male")
                    baseIntake *= 1.1;
                else
                    baseIntake *= 0.9;

                // Adjust for age
                if (age < 30)
                    baseIntake *= 1.1;
                else if (age > 55)
                    baseIntake *= 0.9;

                // Adjust for height
                if (height > 175)
                    baseIntake *= 1.05;
                else if (height < 160)
                    baseIntake *= 0.95;

                // Adjust for activity level
                if (activityLevel == "Medium")
                    baseIntake *= 1.2;
                else if (activityLevel == "High")
                    baseIntake *= 1.5;

                double glasses = baseIntake / 240; // 1 glass = 240 ml
                double ounces = baseIntake / 29.5735; // Convert ml to oz

                lblResult.Text = $"{txtUsername.Text}, your recommended Water Intake is: {baseIntake:F2} ml ({ounces:F2} oz) or {glasses:F1} glasses";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please enter valid input values. Error details: {ex.Message}");
            }
        }

        private double ConvertToKilograms(double weight)
        {
            if (rbtnImperial.Checked)
                return weight * 0.453592; // Convert lbs to kg
            return weight; // Already in kg
        }

        private double ConvertToCentimeters(double height)
        {
            if (rbtnImperial.Checked)
                return height * 30.48; // Convert ft to cm
            return height; // Already in cm
        }

        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUnitVisibility();
        }

        private void rbtnImperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUnitVisibility();
        }

        private void UpdateUnitVisibility()
        {
            lblWeight.Text = rbtnMetric.Checked ? "Weight (kg):" : "Weight (lbs):";
            lblHeight.Text = rbtnMetric.Checked ? "Height (cm):" : "Height (ft):";
        }
    }
}