<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = new int[]{1,2,3,4,3,4};
	PrintDuplicates_SortedArray(a);
}


 void PrintDuplicates_SortedArray(int[] arr)
{
	int n = arr.Length;

	if (n <= 1)
	{
		return; // No duplicates possible in an array of size 0 or 1
	}

	int? lastDuplicate = null; // Nullable int to keep track of the last duplicate identified

	for (int i = 0; i < n - 1; i++)
	{
		if (arr[i] == arr[i + 1] && (lastDuplicate == null || lastDuplicate != arr[i]))
		{
			Console.WriteLine("Duplicate found: " + arr[i]);
			lastDuplicate = arr[i];
		}
	}
}

 void PrintDuplicates_UnSortedArray(int[] arr)
{
	int n = arr.Length;

	for (int i = 0; i < n; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (arr[i] == arr[j])
			{
				Console.WriteLine("Duplicate found: " + arr[i]);
				break;
			}
		}
	}
}

 void PrintDuplicates_WithCount_SortedArray(int[] arr)
{
	int n = arr.Length;

	if (n <= 1)
	{
		return; // No duplicates possible in an array of size 0 or 1
	}

	int lastDuplicate = arr[0];
	int count = 1;

	for (int i = 1; i < n; i++)
	{
		if (arr[i] == lastDuplicate)
		{
			count++;
		}
		else
		{
			if (count > 1)
			{
				Console.WriteLine($"Number: {lastDuplicate}, Count: {count}");
			}
			count = 1; // reset count for the new number
			lastDuplicate = arr[i];
		}
	}

	// Check for the last number in the array
	if (count > 1)
	{
		Console.WriteLine($"Number: {lastDuplicate}, Count: {count}");
	}
}

 void PrintDuplicates_WithCount_UnSortedArray(int[] arr)
{
	int n = arr.Length;
	bool[] marker = new bool[n]; // auxiliary array to keep track of counted numbers

	for (int i = 0; i < n; i++)
	{
		if (marker[i]) continue; // Skip the number if it's already counted

		int count = 1; // initialize count for every number
		for (int j = i + 1; j < n; j++)
		{
			if (arr[i] == arr[j])
			{
				count++;
				marker[j] = true; // mark this number as counted
			}
		}

		if (count > 1)
		{
			Console.WriteLine($"Number: {arr[i]}, Count: {count}");
		}
	}
}

 void PrintUniques_SortedArray(int[] arr)
{
	int n = arr.Length;

	if (n == 0)
	{
		return; // No unique numbers in an empty array
	}

	if (n == 1)
	{
		Console.WriteLine(arr[0]);
		return;
	}

	// Check the first number
	if (arr[0] != arr[1])
	{
		Console.WriteLine(arr[0]);
	}

	// Check the numbers in between
	for (int i = 1; i < n - 1; i++)
	{
		if (arr[i] != arr[i - 1] && arr[i] != arr[i + 1])
		{
			Console.WriteLine(arr[i]);
		}
	}

	// Check the last number
	if (arr[n - 1] != arr[n - 2])
	{
		Console.WriteLine(arr[n - 1]);
	}
}

void PrintUniqueElements(int[] a)
{
	if (a.Length == 0)
	{
		return; // Empty array, nothing to print
	}

	
	Console.WriteLine(a[0]); // Print the first element (always unique)

	// Iterate through the array starting from index 1
	for (int i = 1; i < a.Length; i++)
	{
		// If the current element is different from the previous one, print it
		if (a[i] != a[i - 1])
		{
			Console.WriteLine(a[i]);
		}
	}
}

void PrintUniqueNumbers_UnSortedArray(int[] arr)
{
	int n = arr.Length;

	for (int i = 0; i < n; i++)
	{
		bool isUnique = true;

		for (int j = 0; j < n; j++)
		{
			if (i != j && arr[i] == arr[j])
			{
				isUnique = false;
				break;
			}
		}

		if (isUnique)
		{
			Console.WriteLine(arr[i]);
		}
	}
}