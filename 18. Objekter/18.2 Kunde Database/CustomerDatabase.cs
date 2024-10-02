namespace KundeProgram2;

public class CustomerDatabase
{
	public Customer?[] Customers;

	public CustomerDatabase ()
	{
		Customers = new Customer?[10];
		for (int i = 0 ; i < Customers.Length ; i++)
		{
			Customers[i] = null;
		}
	}

	public bool AddCustomer(Customer customer)
	{
		for (int i = 0 ; i < Customers.Length ; i++)
		{
			if (Customers[i] == null)
			{
				Customers[i] = customer;
				return true;
			}
		}
		Console.WriteLine($"Database full! {customer.Name} not added!");
		return false;
	}

	public int RemoveAtId(int id)
	{
		int count = 0;
		for (int i = 0; i < Customers.Length; i++)
		{
			if (Customers[i]?.Id == id)
			{
				Customers[i] = null;
				count++;
			}
		}
		return count;
	}

	public Customer?[] GetCustomers()
	{
		return Customers;
	}

	public void DisplayCustomerNames()
	{
		foreach (Customer? customer in Customers)
		{
			if (customer != null)
			{
				Console.WriteLine(customer.Name);
			}
		}
	}

}
