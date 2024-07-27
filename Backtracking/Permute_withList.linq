<Query Kind="Program" />

void Main(string[] args)
{
	int[] nums = { 1, 2, 3 };
	IList<IList<int>> result = Permute(nums);

	Console.WriteLine("Permutations of [1, 2, 3]:");
	foreach (var perm in result)
	{
		Console.WriteLine(string.Join(", ", perm));
	}
}

public IList<IList<int>> Permute(int[] nums)
{
	IList<IList<int>> resultList = new List<IList<int>>();
	TryAddingOtherNumber(resultList, new List<int>(), nums);
	return resultList;
}

void TryAddingOtherNumber(IList<IList<int>> resultList, List<int> tempList, int[] nums)
{
	// If we match the length, it is a permutation
	if (tempList.Count == nums.Length)
	{
		resultList.Add(new List<int>(tempList));
		Console.WriteLine("Added permutation: " + string.Join(", ", tempList));
		return;
	}

	for (int i = 0; i < nums.Length; i++)
	{
		// Skip if we get same element
		if (tempList.Contains(nums[i]))
			continue;

		// Add the new element
		tempList.Add(nums[i]);
		Console.WriteLine("Added: " + nums[i] + ", Temp list: " + string.Join(", ", tempList));

		// Go back to try other element
		TryAddingOtherNumber(resultList, tempList, nums);

		// Remove the element
		Console.WriteLine("Removed: " + tempList[tempList.Count - 1] + ", Temp list before remove: " + string.Join(", ", tempList));
		int x = tempList.ElementAt(tempList.Count - 1);
		tempList.RemoveAt(tempList.Count - 1);
		if (tempList.Count == 0)
		{
			Console.WriteLine($"----------------------------------------------------------------- Templist become empty-----------It was before {string.Join(", ", tempList)}-------");
			Console.WriteLine("Temp list is now empty.");
		}
		else
		{
			Console.WriteLine($"**************Temp list after removal of {x}:  is -- {string.Join(", ", tempList)}");
		}
	}
}
