<Query Kind="Program" />



public void Main()
{
	int[] nums = { 1, 2, 3 };
	var result = Permute(nums);

	foreach (var perm in result)
	{
		Console.WriteLine(string.Join(", ", perm));
	}
}
public  IList<IList<int>> Permute(int[] nums)
{
	IList<IList<int>> res = new List<IList<int>>();
	int n = nums.Length;
	Helper(nums, 0, n, res);
	return res;
}

private  void Helper(int[] nums, int i, int n, IList<IList<int>> res)
{
	// Base case
	if (i == n - 1)
	{
		res.Add(new List<int>(nums));
		return;
	}

	// Recursive case
	for (int j = i; j < n; j++)
	{
		Swap(nums, i, j);     // Swap elements at indices i and j
		Helper(nums, i + 1, n, res);  // Recursively generate permutations for the next index (i + 1)
		Swap(nums, i, j); // backtrack :  // Swap back to restore the original array (backtracking)
	}
}

private void Swap(int[] nums, int i, int j)
{
	int temp = nums[i];
	nums[i] = nums[j];
	nums[j] = temp;
}



