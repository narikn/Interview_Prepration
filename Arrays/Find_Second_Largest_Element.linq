<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 1, 6, 3, 1, 7, 9, 1, 4 };

	int f = int.MinValue;
	int s = int.MinValue;
	int i = 0;
	while (i < a.Length)
	{
		int c = a[i];
		if (c > f)
		{
			s = f;
			f = c;
		}
		else
		{
			s = c;
		}
		
		i++;
	}

f.Dump();
s.Dump();
}

// Define other methods and classes here
