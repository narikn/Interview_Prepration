<Query Kind="Program" />

void Main()
{
	int[] a= new int[]{1,2,3};
	GetPerms(a.ToList(),0, new List<List<int>>());
}


private void GetPerms(List<int> nums, int idx, List<List<int>> ans)
{
	if (idx == nums.Count)
	{
		ans.Add(new List<int>(nums)); // Add a copy of nums to ans
		return;
	}

	for (int i = idx; i < nums.Count; i++) // Iterate over the remaining positions starting from idx
	{
		Swap(nums, idx, i); // Swap elements for ith choice
		GetPerms(nums, idx + 1, ans); // Recursively generate permutations for the next index
		Swap(nums, idx, i); // Backtracking: restore the original order after recursion
	}
}

private void Swap(List<int> nums, int i, int j)
{
	int temp = nums[i];
	nums[i] = nums[j];
	nums[j] = temp;
}

public List<List<int>> Permute(List<int> nums)
{
	var ans = new List<List<int>>();
	GetPerms(nums, 0, ans); // Start the recursion with idx = 0
	return ans;
}

//
//
//For nums = [1, 2, 3], let's look at a single recursive call stack:
//
//Start: idx = 0, swap and recurse to idx = 1
//At idx = 1: swap and recurse to idx = 2
//   At idx = 2: swap and recurse to idx = 3
//     At idx = 3: Add[1, 2, 3] to ans(base case reached)
//   Backtrack: idx = 2(after swap back)
//Backtrack: idx = 1(after swap back)
//Continue: Move to the next element in the loop, i = 2, swap and recurse again, continuing the process.
//When backtracking, idx will revert to the previous value before the swap and recursion at that level, thus restoring the previous state.