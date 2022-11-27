<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

FindMissingNumber_2();
}



public void FindMissingElementsWorking()
{
	int[] a = { 10, 11, 13, 14, 16, 18 };
	int sElement = a[0] - 0;
	for (int i = 0; i < a.Length; i++)
	{
		if (a[i] - i != sElement)
		{
			int diff_2 = a[i] - i;
			while (sElement < diff_2)
			{
				int element = sElement + i;

				sElement++;
			}
		}
	}
}

public void FindMissingNumber_2()
{
	// using auxliary array
	 
	int[] a = { 4, 5, 6, 8, 10, 15 };
	int[] h = new int[16];

	for (int i = 0; i < a.Length; i++)
	{
		int k = a[i];
		h[k] = a[i];
	}

	for (int i = 4; i < h.Length; i++)
	{
		if (h[i] == 0)
		{
			i.Dump();
		}
	}
}