using System.Text.Json;

namespace _28._5_Highscore;

public class Highscore
{
	private Dictionary<string, int> highscores;
	
	private string filePath;
	
	public Highscore(string filePath)
	{
		this.filePath = filePath;

		highscores = new Dictionary<string, int>();
	}

	public void NewScore(string name, int score)
	{
		if (highscores.ContainsKey(name))
		{
			if (highscores[name] < score)
			{
				highscores[name] = score;
			}
		}
		else
		{
			highscores.Add(name, score);
		}
	}

	public void PrintHighscores ()
	{
		foreach (var highscore in highscores)
		{
			Console.WriteLine($"{highscore.Key}: {highscore.Value}");
		}
	}

	public void Load ()
	{
		try
		{
			string json = File.ReadAllText(filePath);
			highscores = JsonSerializer.Deserialize(json, typeof(Dictionary<string, int>)) as Dictionary<string, int>;
		}
		catch (FileNotFoundException e)
		{
			Console.WriteLine("File not found! " + e.Message);
		}
		catch (JsonException e)
		{
			Console.WriteLine("Json deserialization failed!" + e.Message);
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
		}
	}

	public void Save ()
	{
		try
		{
			string json = JsonSerializer.Serialize(highscores);
			File.WriteAllText(filePath, json);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
	
}