<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	TwoSum_Sorted();
}


public void TwoSum_Unsorted()
{

	int[] a = { 4, 2, 5, 3, 1, 8 };
	Dictionary<int, int> d = new Dictionary<int, int>();

	int k = 9;
	for (int i = 0; i < a.Length; i++)
	{
		int f = a[i];
		int s = k - f;

		if (d.ContainsKey(s) == true)
		{
			$"{a[i]} + {s} = {k}".Dump();
		}
		else
		{

			d[f] = i; // dont Do d.Add(), if we have same element in dictionary we will get exception
		}
	}
}


public void TwoSum_Sorted()
{
	int[] a = { 1, 2, 3, 4, 5, 8, 9, 14, 20 };

	int s = 0;
	int e = a.Length - 1;
	int k = 17;
	while (s < e)
	{
		int t = a[s] + a[e];
		if (t == k)
		{
			$"{a[s]} +{a[e]} ={k} ".Dump();
			s++; e--;
		}
		if (t < k) s++;
		if (t > k) e--;

	}
}

public void TwoSum()
{
	int[] a = { 4, 2, 5, 3, 1, 8 };
	Dictionary<int, int> d = new Dictionary<int, int>();

	int k = 9;
	for (int i = 0; i < a.Length; i++)
	{
		int f = a[i];
		int s = k - f;

		if (d.ContainsKey(s) == true)
		{
			$"{a[i]} + {s} = {k}".Dump();
		}
		else
		{

			d[f] = i; // dont Do d.Add(), if we have same element in dictionary we will get exception
		}
	}


}


