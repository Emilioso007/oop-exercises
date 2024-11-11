using System.Text.Json;

namespace _28._3_Skrivning_til_Fil;

public class Program
{

	public static void Main(string[] args)
	{

		Dictionary<int, string> months = new Dictionary<int, string>
		{
			{ 1, "January" },
			{ 2, "February" },
			{ 3, "Marts" },
			{ 4, "April" },
			{ 5, "May" },
			{ 6, "June" },
			{ 7, "July" },
			{ 8, "August" },
			{ 9, "September" },
			{ 10, "October" },
			{ 11, "November" },
			{ 12, "December" }
		};

		try
		{
			string json = JsonSerializer.Serialize(months);
			File.WriteAllText("Months.json", json);
			Console.WriteLine("Data saved to file: Months.json");
		}
		catch (Exception e)
		{
			Console.WriteLine("Failed to write! " + e.Message);
		}

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey(true);

	}

}