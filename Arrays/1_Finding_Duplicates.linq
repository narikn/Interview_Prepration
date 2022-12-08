<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

	FindDuplicates_UnSorted();
}

public void FindDuplicates_UnSorted()
{

	int[] a = { 2, 5, 1, 3, 3, 7, 9, 2, 6, 6, 9, 9, 1, 9 };
	for (int i = 0; i < a.Length - 1; i++) // why n-1?  because we dont need to find duplicate of the last element
	{
		int count = 1;
		for (int j = i + 1; j < a.Length; j++)  //  let 1st duplicate be 1 and then If we find 2nd duplicate then set it with -1 ,
		{
			if (a[i] != -1 && a[i] == a[j])
			{
				count++;
				a[j] = -1;

			}
		}
		if (count > 1)
		{
			$"{a[i]}  is  -- {count} times".Dump();
		}
	}
}

public void FindDuplicates_Sorted()
{

	// Time Complxity is order of n even though we have while loop ( which is for small set)
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

public void CountDuplicates_Sorted()
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