namespace _25._3_Hangman;

public class Program
{

	public static void Main(string[] args)
	{

		Hangman hangmanGame = new Hangman(secretWord: "aslak", amountOfLives: 6);

		while (!hangmanGame.IsDead && !hangmanGame.IsGuessed)
		{
			Console.WriteLine("Make guess: ");
			char guess = Console.ReadKey().KeyChar;
			Console.WriteLine();

			hangmanGame.MakeGuess(guess);
			
			Console.WriteLine(hangmanGame);

		}

		if (hangmanGame.IsGuessed)
		{
			Console.WriteLine("You won! The word was: " + hangmanGame.SecretWord);
		}
		else
		{
			Console.WriteLine("You lost! The word was: " + hangmanGame.SecretWord);
		}

	}
	
}
