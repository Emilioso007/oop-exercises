using System.Text.Json;

namespace _28._4_Læsning_fra_Fil;

public class Program
{

	public static void Main(string[] args)
	{
		Dictionary<int, string> months;
		
		string json = File.ReadAllText("Months.json");
		months = JsonSerializer.Deserialize(json, typeof(Dictionary<int, string>)) as Dictionary<int, string>;
		
		foreach (var month in months)
		{
			Console.WriteLine($"Key: {month.Key}, Value: {month.Value}");
		}
		
		Console.WriteLine("Press any key to exit...");
		Console.ReadKey(true);
	}
	
}
