<Query Kind="Program" />

void Main()
{
	//GenerateSubsetsString("abc", "", 0);

	GenerateSubsets(new int[] {1,2,3}, new List<int>(), 0);
}


void GenerateSubsetsString(string str, string current, int index)
{
	// Base case: All characters are processed
	if (index == str.Length)
	{
		Console.WriteLine(current); // Process current subset
		return;
	}

	// Include the current character
	string includeCurrent = current + str[index]; // Add the character
	GenerateSubsetsString(str, includeCurrent, index + 1);

	string excludeCurrent = current; // Keep the current string unchanged
	GenerateSubsetsString(str, excludeCurrent, index + 1);
}

void GenerateSubsets(int[] nums, List<int> current, int index)
{
	// Base case: All elements are processed
	if (index == nums.Length)
	{
		Console.WriteLine(string.Join(" ", current)); // Process current subset
		return;
	}

	// Include the current element
	current.Add(nums[index]);
	GenerateSubsets(nums, current, index + 1);

	// Backtrack: Exclude the current element
	current.RemoveAt(current.Count - 1);
	GenerateSubsets(nums, current, index + 1);
}


void GenerateCombinations<T>(T[] items, List<T> current, int index, Action<List<T>> processSubset)
{
	// Base case: All elements are processed
	if (index == items.Length)
	{
		processSubset(current); // Process current subset (you can customize the action)
		return;
	}

	// Include the current element
	current.Add(items[index]);
	GenerateCombinations(items, current, index + 1, processSubset);

	// Backtrack: Exclude the current element
	current.RemoveAt(current.Count - 1);
	GenerateCombinations(items, current, index + 1, processSubset);
}
