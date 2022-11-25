<Query Kind="Program" />

void Main()
{
	// Write code to test your extensions here. Press F5 to compile and run.
}

public static class MyExtensions
{
	// Write custom extension methods here. They will be available to all queries.

}

public static class ArrayExtensions
{
	public static void PrintArray(this int[] _array)
	{
		if (_array != null)
		{
			string str = string.Empty;
			for (int i = 0; i < _array.Length; i++)
			{
				str = str + "  " + _array[i].ToString();
			}
			str.Dump();
		}
	}

	public static void PrintArrayWithIteration(this int[] _array, int iteration)
	{
		if (_array != null)
		{ 
		
			string str = string.Empty;
			for (int i = 0; i < _array.Length; i++)
			{
				str = str + "  " + _array[i].ToString();
			}
			var st = $"{iteration}--> {str}";
			st.Dump();
		}
	}

	public static void PrintArrayAtIndex(this int[] _array, int? indexAt = null, int? loopIndex = null)
	{
		if (indexAt != null && loopIndex != null)
		{
			if (indexAt == loopIndex)
			{
				if (_array != null)
				{
					string str = string.Empty;
					for (int i = 0; i < _array.Length; i++)
					{
						str = str + "  " + _array[i].ToString();
					}
					str.Dump();
				}
			}
		}

	}

	public static void PrintUptoN(this int[] _array, int _n)
	{
		if (_array != null)
		{
			string str = string.Empty;
			for (int i = 0; i < _array.Length && i <= _n - 1; i++)
			{
				str = str + "  " + _array[i].ToString();
			}
			str.Dump();
		}
	}

	public static void PrintListOfList(this List<List<int>> ls)
	{
		if (ls != null)
		{
			foreach (var element in ls)
			{
				if (element != null)
				{
					PrintArray(element.ToArray());
				}
			}
		}
	}

	public static void PrintStr(string[] toPrint)
	{
		Console.WriteLine(string.Join("", toPrint));
	}

	public static void PrintListOfList(this IList<IList<int>> ls)
	{
		if (ls != null)
		{
			foreach (var element in ls)
			{
				if (element != null)
				{
					PrintArray(element.ToArray());
				}
			}
		}
	}
	public static void Swap(this int[] a, int i, int j, bool displaySwap=false)
	{
		string s1 = $"Swaped elements {a[i]},{a[j]}";
		int t = a[i];
		a[i] = a[j];
		a[j] = t;
		string s2 = $" to {a[i]},{a[j]}";
		if (displaySwap==true)
		{
				(s1+s2).Dump();
		}
	}
}