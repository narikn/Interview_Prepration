<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

	FindMissingElementsWorking_1();
}



public void FindMissingElementsWorking()
{
	int[] a = { 10, 11, 15, 16, 18, 24 };
	int startElement = a[0] - 0;
	for (int i = 0; i < a.Length; i++)
	{
		int gap = a[i] - i;
		if (gap != startElement)
		{
			int diff_2 = gap;
			while (startElement < diff_2)
			{
				int element = startElement + i;
				element.Dump();
				startElement++;
			}
		}
	}
}

public void FindMissingElementsWorking_1()
{
	int[] a = { 10, 11, 15, 16, 18, 24 };
	int startElement = a[0] - 0;
	for (int i = 0; i < a.Length; i++)
	{
		int gap = a[i] - i;
		if (gap != startElement)
		{
			int xx = gap - startElement; // magnitude
			while (xx > 0)
			{
               (a[i]-xx).P();
			   xx--;
			}
			startElement=gap;
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