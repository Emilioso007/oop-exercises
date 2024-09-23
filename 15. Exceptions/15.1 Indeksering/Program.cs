using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.Clear();

		int iterationer = 10;
		int[] array = { 1, 2, 3, 4, 5};

		// increment
		for (int i = 0; i < iterationer; i++)
		{
			try {
				array[i]++;
			} catch {

			}
		}

		// print
		for (int i = 0; i < array.Length; i++) {
			Console.WriteLine(array[i]);
		}

		Console.ReadKey();
	}
}

/*
 * 2. Hvilken exception bliver kastet?
 * 	System.IndexOutOfRangeException
 *
 * 3. Hvad foresager at denne exception bliver kastet?
 *	Programmet prøver at tilgå et element i arrayet som ikke eksisterer.
 *
 * 5. Er dette den korrekte løsning på problemet, og hvorfor?
 *	Løsningen virker, men da der er tale om en semantisk fejl,
 er det ikke det "rigtige" måde at løse problemet.
 */