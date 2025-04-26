using Assignment5;
using System.Windows.Forms;

// Made by Manish Raj Moriche and finished on the 24th of April 2025
namespace Assignment5
{
    public partial class MainForm : Form
    {
        private CustomerManager customerManager;

        public MainForm()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
            lstboxDisplay.SelectedIndexChanged += LstboxDisplay_SelectedIndexChanged;

            // Attach other event handlers with correct nullability
            btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            UpdateCustomerList(); // Populate the ListBox when the form loads
        }

        private void LstboxDisplay_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstboxDisplay.SelectedItem is Customer selectedCustomer)
            {
                DisplayCustomerDetails(selectedCustomer);
            }
        }

        private void DisplayCustomerDetails(Customer customer)
        {
            // Clear existing items
            listView1.Items.Clear();
            listView1.Groups.Clear();

            // Create groups for organized display
            var addressGroup = new ListViewGroup("Name and address");
            var emailGroup = new ListViewGroup("Emails");
            var phoneGroup = new ListViewGroup("Phone Numbers");

            listView1.Groups.Add(addressGroup);
            listView1.Groups.Add(emailGroup);
            listView1.Groups.Add(phoneGroup);

            // Display Address details
            listView1.Items.Add(new ListViewItem(new[] { $"{customer.ContactDetails.FirstName} {customer.ContactDetails.LastName}" }, addressGroup));
            listView1.Items.Add(new ListViewItem(new[] { customer.ContactDetails.Address.Street }, addressGroup));
            listView1.Items.Add(new ListViewItem(new[] { $"{customer.ContactDetails.Address.ZipCode} {customer.ContactDetails.Address.City}" }, addressGroup));
            listView1.Items.Add(new ListViewItem(new[] { customer.ContactDetails.Address.Country }, addressGroup));

            // Display Email details with updated property names
            listView1.Items.Add(new ListViewItem(new[] { "Private", customer.ContactDetails.Email.Personal }, emailGroup));
            listView1.Items.Add(new ListViewItem(new[] { "Office", customer.ContactDetails.Email.Work }, emailGroup));

            // Display Phone numbers
            listView1.Items.Add(new ListViewItem(new[] { "Private", customer.ContactDetails.Phone.HomePhone }, phoneGroup));
            listView1.Items.Add(new ListViewItem(new[] { "Office", customer.ContactDetails.Phone.CellPhone }, phoneGroup));
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            using (ContactForm contactForm = new ContactForm())
            {
                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    Customer newCustomer = contactForm.GetCustomerData();
                    if (newCustomer != null)
                    {
                        customerManager.AddCustomer(newCustomer);
                        UpdateCustomerList();
                    }
                }
            }
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            if (lstboxDisplay.SelectedItem is Customer selectedCustomer)
            {
                using (ContactForm contactForm = new ContactForm(selectedCustomer))
                {
                    if (contactForm.ShowDialog() == DialogResult.OK)
                    {
                        Customer updatedCustomer = contactForm.GetCustomerData();
                        if (updatedCustomer != null)
                        {
                            customerManager.UpdateCustomer(updatedCustomer); // Ensure this method updates the list
                            UpdateCustomerList();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (lstboxDisplay.SelectedItem is Customer selectedCustomer)
            {
                customerManager.RemoveCustomer(selectedCustomer);
                UpdateCustomerList();

                // Clear the ListView to remove customer details from the display
                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void UpdateCustomerList()
        {
            lstboxDisplay.DataSource = null;
            lstboxDisplay.DataSource = customerManager.GetAllCustomers(); // Bind the actual customer list
            lstboxDisplay.DisplayMember = "DisplayName"; // Display the DisplayName property of the Customer class
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

