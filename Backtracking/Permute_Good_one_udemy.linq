<Query Kind="Program" />

public static void Main()
{
	int[] nums = { 1, 2, 3 };
	var result = Permute(nums);

	foreach (var perm in result)
	{
		Console.WriteLine(string.Join(", ", perm));
	}
}


public static IList<IList<int>> Permute(int[] nums)
{
	IList<IList<int>> res = new List<IList<int>>();
	int n = nums.Length;
	Helper(nums, 0, n, res);
	return res;
}

private static void Helper(int[] nums, int index, int n, IList<IList<int>> res)
{
	// Base case
	if (index == n - 1)
	{
		res.Add(new List<int>(nums));
		return;
	}

	// Recursive case
	for (int j = index; j < n; j++)
	{
		Swap(nums, index, j);
		Helper(nums, index + 1, n, res);
		Swap(nums, index, j); // backtrack
	}
}

private static void Swap(int[] nums, int i, int j)
{
	int temp = nums[i];
	nums[i] = nums[j];
	nums[j] = temp;
}


