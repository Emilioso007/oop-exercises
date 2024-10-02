namespace KundeProgram1;

class Program
{
	static void Main(string[] args)
	{
		Customer aCustomer = new Customer("Peter", 100);

		aCustomer.Deposit(1000000);
		aCustomer.Withdraw(10);

		Console.WriteLine(aCustomer.GetBalance());

	}
}