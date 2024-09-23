using System;

public class Program
{

	public static int[] accounts = { 903, 716, 67};

	public static void Main(string[] args)
	{
		Console.Clear();

		while (true) {
			int accountId = GetAccountNumber();
			try {
				PrintAccountState(accountId);
			} catch {

			}
		}

		Console.ReadKey();
	}

	public static int GetAccountNumber() {
		Console.WriteLine("Enter an account number: ");
		try {
			return Convert.ToInt32(Console.ReadLine());
		} catch {
			return -1;
		}
	}

	public static void PrintAccountState(int accountId) {
		Console.WriteLine($"Account {accountId} contains {accounts[accountId]}");
	}
}