namespace DynamiskArray;

public class DynArray<T> : IDynArray<T>
{

	private T[] array;
	private int capacity;
	private int fill;
	
	public DynArray()
	{
		array = new T[2]; 
		capacity = 2;
		fill = 0;
	}
	
	public void Append(T element)
	{
		if (fill == capacity)
		{
			T[] newArray = new T[capacity * 2];
			for (int i = 0 ; i < capacity ; i++)
			{
				newArray[i] = array[i];
			}
			array = newArray;
			capacity *= 2;
		}
		array[fill] = element;
		fill++;
	}

	public void Insert(int i, T element)
	{
		if (i < 0 || i >= fill)
		{
			throw new IndexOutOfRangeException();
		}
		if (fill == capacity)
		{
			T[] newArray = new T[capacity * 2];
			for (int j = 0 ; j < capacity ; j++)
			{
				newArray[j] = array[j];
			}
			array = newArray;
			capacity *= 2;
		}
		for (int j = fill ; j > i ; j--)
		{
			array[j] = array[j - 1];
		}
		array[i] = element;
		fill++;
	}

	public void Remove(int i)
	{
		if (i < 0 || i >= fill)
		{
			throw new IndexOutOfRangeException();
		}
		for (int j = i ; j < fill - 1 ; j++)
		{
			array[j] = array[j + 1];
		}
		fill--;
		
		if (fill < capacity / 2)
		{
			T[] newArray = new T[capacity / 2];
			for (int j = 0 ; j < fill ; j++)
			{
				newArray[j] = array[j];
			}
			array = newArray;
			capacity /= 2;
		}
	}

	public void Set(int i, T element)
	{
		if(i < 0 || i >= array.Length)
		{
			throw new IndexOutOfRangeException();
		}
		array[i] = element;
	}

	public T Get(int i)
	{
		if(i < 0 || i >= array.Length)
		{
			throw new IndexOutOfRangeException();
		}
		return array[i];
	}

	public int GetFill ()
	{
		return fill;
	}s
	
	public override string ToString ()	
	{
		string result = "[";

		for (int i = 0 ; i < capacity ; i++)
		{
			result += array[i]?.ToString();
			if (i != capacity - 1)
			{
				result += ", ";
			}
		}
		
		result += "]";
		return result;
	}
}
