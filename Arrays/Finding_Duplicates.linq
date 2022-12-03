<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	FindDuplicates();

}

public void FindDuplicates()
{
	int[] a = { 1, 1, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, 5, 5 };

	int lastDuplicate = 0;
	for (int i = 0; i < a.Length - 1; i++)
	{
		if (a[i] == a[i + 1])
		{
			if (lastDuplicate != a[i]) // if last element is same dont print it
			{
				a[i].Dump();
				lastDuplicate = a[i];
			}
		}
	}
}

public void CountDuplicates()
{
	int[] a = { 1, 2, 4, 4 };

	int j = 0;

	for (int i = 0; i < a.Length - 1; i++)
	{
		if (a[i] == a[i + 1])
		{
			j = i + 1;
			while (a[i] == a[j] && j < a.Length) // j may cross the length of array so it should be taken care.
			{
				j++;
			}
			 ("count--" + a[i].ToString() + "---" + (j - i)).Dump();  // j-i gives the count of dupilicates which are starting for i and ending at j

			i = j - 1; // i should move before to j, bcoz j will pointing the last item in set of duplicates
		}
	}
}