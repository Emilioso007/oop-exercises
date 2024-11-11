namespace _28._5_Highscore;

public class Program
{
	
	public static void Main(string[] args)
	{
		
		Highscore highscore = new Highscore("highscore.json");
		
		highscore.Load();
		/*
		highscore.NewScore("John", 100);
		highscore.NewScore("Jane", 200);
		highscore.NewScore("Doe", 300);
		*/
		highscore.Save();
		
		highscore.PrintHighscores();
		
	}
	
}

