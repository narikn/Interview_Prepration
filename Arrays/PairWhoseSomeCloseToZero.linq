<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { -79, -9, 0, 69, -79, 84 };
	//int[] a = { -1, 2, 3, 4, 5, 1 };

	//int[] a = { 2, 5, 3, -1, 5 };
	//Array.Sort(a);
	a.PrintArray();

	int currSum = 0;
	int closeSum = int.MaxValue;
	int l = 0;
	int r = a.Length - 1;
	int minLi = 0;
	int minRi = a.Length - 1;

	while (l < r)
	{
		currSum = a[l] + a[r];
		if (Math.Abs(currSum) < Math.Abs(closeSum)) // we dont care if it is negative or positive it should be close to zero (distance matters)
		{
			closeSum = currSum;
			minLi = l;
			minRi = r;
		}
		if (currSum < 0)
		{
			l++;
		}
		else
		{
			r--;
		}
	}

	minLi.Dump();
	minRi.Dump();

}