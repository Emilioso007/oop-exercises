namespace KundeProgram2;

class Program
{
	static void Main(string[] args)
	{
		CustomerDatabase cdb = new CustomerDatabase();

		Customer a = new Customer("Alice", 1, 100);
		cdb.AddCustomer(a);

		Customer b = new Customer("Bob", 2, 100);
		cdb.AddCustomer(b);

		Customer c = new Customer("Charlie", 3, 100);
		cdb.AddCustomer(c);

		Customer d = new Customer("Dorthea", 4, 100);
		cdb.AddCustomer(d);

		Customer e = new Customer("Eric", 5, 100);
		cdb.AddCustomer(e);

		Customer f = new Customer("Frank", 6, 100);
		cdb.AddCustomer(f);

		Customer g = new Customer("Gurli", 7, 100);
		cdb.AddCustomer(g);

		Customer h = new Customer("Hans", 8, 100);
		cdb.AddCustomer(h);

		Customer i = new Customer("Ingrid", 9, 100);
		cdb.AddCustomer(i);

		Customer j = new Customer("Jens", 10, 100);
		cdb.AddCustomer(j);

		Customer k = new Customer("Kalle", 11, 100);
		cdb.AddCustomer(k);


		cdb.DisplayCustomerNames();

		Console.WriteLine();


		cdb.RemoveAtId(6); //Removes Frank from the database


		cdb.DisplayCustomerNames();

	}
}