namespace _27._2_Mængder;

public class Program
{

	public static void Main(string[] args)
	{
		NondestructiveHashSet<int> setA = new NondestructiveHashSet<int> { 1, 2, 3, 4 };
		NondestructiveHashSet<int> setB = new NondestructiveHashSet<int> { 3, 4, 5, 6 };

		INondestructiveSet<int> intersection = setA.Intersection(setB);
		INondestructiveSet<int> union		 = setA.Union(setB);
		INondestructiveSet<int> difference   = setA.Difference(setB);

		Console.WriteLine("Set A: " + string.Join(", ", setA));
		Console.WriteLine("Set B: " + string.Join(", ", setB));
		Console.WriteLine("Intersection: " + intersection);
		Console.WriteLine("Union: " + string.Join(", ", union));
		Console.WriteLine("Difference: " + string.Join(", ", difference));
		
		
		NondestructiveHashSet<int> setC = new NondestructiveHashSet<int> { 1, 2, 3, 4 };
		NondestructiveHashSet<int> setD = new NondestructiveHashSet<int> { 5, 6 };
		NondestructiveHashSet<int> setE = new NondestructiveHashSet<int> { 2, 3 };

		bool isDisjoint = setC.IsDisjoint(setD);
		bool isSubset = setC.IsSubset(setE);

		Console.WriteLine($"Is disjoint? {isDisjoint}");
		Console.WriteLine($"Is subset? {isSubset}");
		
	}
	
}

