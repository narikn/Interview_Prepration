<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 7, 1, 5, 4 };

	int min = a[0];
	int maxDiff_So_Far = -1;

	for (int i = 1; i < a.Length; i++)
	{
		if (min < a[i])
		{
			maxDiff_So_Far = Math.Max(maxDiff_So_Far, a[i] - min);
		}
		else
		{
			min = a[i];
		}
	}
	maxDiff_So_Far.Dump();
}

public void MaxDiff(int[] a)
{
	int minmumElementSofar = a[0];
	int maxDiff_SoFar = 0;
	int currentDifference;
	for (int i = 1; i < a.Length; i++)
	{
		if (a[i] < minmumElementSofar)
		{
			minmumElementSofar = a[i];
		}
		else
		{
			currentDifference = a[i] - minmumElementSofar;

			if (currentDifference > maxDiff_SoFar)
			{
				maxDiff_SoFar = currentDifference;
			}
		}
	}

}


