using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class ContactForm : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Customer? CustomerData { get; private set; }

        public ContactForm()
        {
            InitializeComponent();
            btnContactOK.DialogResult = DialogResult.OK;
            button1.DialogResult = DialogResult.Cancel;

            // Add prompt text as first item
            cmbBoxCountries.Items.Add("(Click to select your country)");

            // Populate countries ComboBox using the Countries enum
            foreach (Countries country in Enum.GetValues(typeof(Countries)))
            {
                cmbBoxCountries.Items.Add(country.ToString().Replace("_", " "));
            }

            // Select the prompt text by default
            cmbBoxCountries.SelectedIndex = 0;

            // DropDownList to prevent typing
            cmbBoxCountries.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public ContactForm(Customer customer) : this()
        {
            CustomerData = customer ?? throw new ArgumentNullException(nameof(customer));

            // Populate the form fields with existing customer data
            txtBoxFirstName.Text = customer.ContactDetails.FirstName;
            txtBoxLastName.Text = customer.ContactDetails.LastName;
            txtBoxHomePhone.Text = customer.ContactDetails.Phone.HomePhone;
            txtBoxCellPhone.Text = customer.ContactDetails.Phone.CellPhone;
            txtBoxEmailBusiness.Text = customer.ContactDetails.Email.Work;
            txtBoxEmailPrivate.Text = customer.ContactDetails.Email.Personal;
            txtBoxStreet.Text = customer.ContactDetails.Address.Street;
            txtBoxCity.Text = customer.ContactDetails.Address.City;
            TxtBoxZipCode.Text = customer.ContactDetails.Address.ZipCode;
            cmbBoxCountries.SelectedItem = customer.ContactDetails.Address.Country;
        }

        public Customer GetCustomerData()
        {
            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCity.Text) ||
                cmbBoxCountries.Text == "(Click to select your country)" ||
                cmbBoxCountries.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill out all required fields (First Name, Last Name, City, Country).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None; // Prevent form from closing
                return null!;
            }

            // Update existing CustomerData or create a new instance
            if (CustomerData == null)
            {
                CustomerData = new Customer
                {
                    ID = Guid.NewGuid().ToString(),
                    ContactDetails = new Contact()
                };
            }

            // Populate CustomerData with updated information from form fields
            CustomerData.ContactDetails.FirstName = txtBoxFirstName.Text;
            CustomerData.ContactDetails.LastName = txtBoxLastName.Text;
            CustomerData.ContactDetails.Phone.HomePhone = txtBoxHomePhone.Text;
            CustomerData.ContactDetails.Phone.CellPhone = txtBoxCellPhone.Text;
            
            // Update to use the Email class from Email.cs using correct property names
            if (CustomerData.ContactDetails.Email == null)
                CustomerData.ContactDetails.Email = new Email();
                
            CustomerData.ContactDetails.Email.Work = txtBoxEmailBusiness.Text;
            CustomerData.ContactDetails.Email.Personal = txtBoxEmailPrivate.Text;
            
            CustomerData.ContactDetails.Address.Street = txtBoxStreet.Text;
            CustomerData.ContactDetails.Address.City = txtBoxCity.Text;
            CustomerData.ContactDetails.Address.ZipCode = TxtBoxZipCode.Text;
            CustomerData.ContactDetails.Address.Country = cmbBoxCountries.Text;

            return CustomerData;
        }
    }
}

