<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

	int[] a = { 1, 5, -1, 6, 3, 2 };

	int k = 3; //  size k sub array
	int s = 0;
	int subSum = 0;
	int max = 0;

	int i;
	for (i = 0; i < a.Length; i++)
	{
		subSum = subSum + a[i];
		if (i >= k - 1)
		{
			if (subSum>max)
			{
				max=subSum;
			}
			subSum = subSum - a[s];
			s++;
		}
	}

max.Dump();
}

// Define other methods and classes here
