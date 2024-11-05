using System;

namespace _25._1_Gennemsnitlig_Alder
{
	public class Person : IDisposable
	{
		public double age;

		private static double totalAge;
		private static int numberOfPersons;
		private bool disposed = false;

		public Person(double age)
		{
			this.age = age;
			totalAge += age;
			numberOfPersons++;
		}

		public static double AverageAge()
		{
			return numberOfPersons == 0 ? 0 : totalAge / numberOfPersons;
		}

		public void Dispose()
		{
			if (!disposed)
			{
				totalAge -= age;
				numberOfPersons--;
				disposed = true;
				GC.SuppressFinalize(this);
			}
		}

		~Person()
		{
			Dispose();
		}
	}
}