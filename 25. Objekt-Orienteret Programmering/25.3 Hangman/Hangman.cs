using System.Text;

namespace _25._3_Hangman;

public class Hangman
{
	public string SecretWord { get; }

	public bool IsDead
	{
		get
		{
			return livesLeft <= 0;
		}
	}

	public bool IsGuessed
	{
		get
		{
			bool won = true;
			foreach (char c in guessString.ToString())
			{
				if (c == '_')
				{
					won = false;
				}
			}
			return won;
		}
	}

	private string validCharacters = "abcdefghijklmnopqrstuvwxyz";
	private string guessedCharacters = "";
	private StringBuilder guessString;
	private int livesLeft;

	public Hangman(string secretWord, int amountOfLives)
	{
		SecretWord = secretWord;
		guessString = new StringBuilder(new string('_', SecretWord.Length));
		livesLeft = amountOfLives;
	}

	public void MakeGuess(char guess)
	{
		if (!validCharacters.Contains(guess) || guessedCharacters.Contains(guess))
		{
			return;
		}

		validCharacters = validCharacters.Replace(guess, '*');
		guessedCharacters += guess;
		
		bool correct = false;
		for (int i = 0; i < SecretWord.Length; i++)
		{
			if (guess == SecretWord[i])
			{
				guessString[i] = guess;
				correct = true;
			}
		}
		if (!correct)
		{
			livesLeft--;
		}
	}

	public override string ToString ()
	{
		StringBuilder result = new StringBuilder();
		result.Append($"Lives left: {livesLeft}\n");
		result.Append($"Used characters: {guessedCharacters}\n");
		result.Append(guessString+"\n");
		return result.ToString();
	}
}