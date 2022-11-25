<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 4, 1, 5, 2, 4, 1 };

	int start = 0;
	int len = int.MaxValue;
	int subsum = 0;
	int t = 7;

	for (int i = 0; i < a.Length; i++)
	{
		subsum = subsum + a[i];
		while (subsum >= t)
		{
			int currentWindowSize = i - start + 1; // plus one bcoz i-start is on array index ,  we need length so adding 1

			if (currentWindowSize < len)
			{
				len = currentWindowSize;
			}
			subsum = subsum - a[start];
			start++;
		}
	}
len.Dump();
}

// Define other methods and classes here
