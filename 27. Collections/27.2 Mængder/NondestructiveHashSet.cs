namespace _27._2_Mængder;

public class NondestructiveHashSet<T> : HashSet<T>, INondestructiveSet<T>
{

	public INondestructiveSet<T> Intersection(INondestructiveSet<T> nondestructiveSet)
	{
		NondestructiveHashSet<T> other = nondestructiveSet as NondestructiveHashSet<T>;
		NondestructiveHashSet<T> result = new NondestructiveHashSet<T>();
		foreach (T value in this)
		{
			if (other.Contains(value))
			{
				result.Add(value);
			}
		}

		return result;
	}

	public INondestructiveSet<T> Union(INondestructiveSet<T> nondestructiveSet)
	{
		NondestructiveHashSet<T> other = nondestructiveSet as NondestructiveHashSet<T>;
		NondestructiveHashSet<T> result = new NondestructiveHashSet<T>();
		foreach (T value in this)
		{
			result.Add(value);
		}
		foreach (T value in other)
		{
			result.Add(value);
		}

		return result;
	}

	public INondestructiveSet<T> Difference(INondestructiveSet<T> nondestructiveSet)
	{
		NondestructiveHashSet<T> other = nondestructiveSet as NondestructiveHashSet<T>;
		NondestructiveHashSet<T> result = new NondestructiveHashSet<T>();
		foreach (T value in this)
		{
			if (!other.Contains(value))
			{
				result.Add(value);
			}
		}

		return result;
	}

	public bool IsDisjoint(INondestructiveSet<T> nondestructiveSet)
	{
		bool isDisjoint = true;
		
		NondestructiveHashSet<T> other = nondestructiveSet as NondestructiveHashSet<T>;

		foreach (T value in this)
		{
			if (other.Contains(value))
			{
				isDisjoint = false;
			}
		}

		return isDisjoint;

	}

	public bool IsSubset(INondestructiveSet<T> nondestructiveSet)
	{
		bool isSubset = true;
		
		NondestructiveHashSet<T> other = nondestructiveSet as NondestructiveHashSet<T>;

		foreach (T value in other)
		{
			if (!this.Contains(value))
			{
				isSubset = false;
			}
		}

		return isSubset;
	}

	public override string ToString ()
	{
		return string.Join(", ", this);
	}
}