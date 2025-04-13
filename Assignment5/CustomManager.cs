using Assignment5;

public class CustomerManager
{
    private List<Customer> customers = new List<Customer>();
    private int nextId = 1; // Start ID from 1

    public void AddCustomer(Customer customer)
    {
        customer.ID = nextId.ToString(); // Assign the next incremental ID
        nextId++; // Increment the ID for the next customer
        customers.Add(customer);
    }

    public void RemoveCustomer(Customer customer)
    {
        customers.Remove(customer);
    }

    public void UpdateCustomer(Customer customer)
    {
        // Logic for updating an existing customer 
    }



    public List<Customer> GetAllCustomers()
    {
        return new List<Customer>(customers);
    }
}

