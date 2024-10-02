namespace KundeProgram1
{
	public class Customer{

		public string Name;
		public int Id;
		public double Balance;

		public Customer(string name, int id){
			Name = name;
			Id = id;
			Balance = 0;
		}

		public Customer(string name, int id, double balance){
			Name = name;
			Id = id;
			Balance = balance;
		}

		public void Deposit(double amount){
			Balance += amount;
		}

		public void Withdraw(double amount){
			Balance -= amount;
		}

		public double GetBalance(){
			return Balance;
		}

	}
}