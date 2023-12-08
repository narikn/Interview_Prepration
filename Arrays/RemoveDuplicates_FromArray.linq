<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 1, 2, 3, 3, 3, 4, 5 };
	RemoveDuplicatesFromSortedArray(a);

}


public void RemoveDuplicatesFromSortedArray(int[] a)
{
	if (a.Length <= 1)
	{

		return;
	}


	int j = 0;

	// Loop through the original sorted array to find and store unique elements
	for (int i = 1; i < a.Length; i++)
	{
		// If the current element is not equal to the previous unique element
		if (a[i] != a[j])
		{
			j++; // Move to the next position in the temporary array
			a[j] = a[i]; // Store the current unique element at the next position
		}
	}

	a.PrintArrayTillIndex(j + 1);
}
