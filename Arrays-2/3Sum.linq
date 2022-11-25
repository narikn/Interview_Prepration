<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

	var a = new int[] { -1, 0, 1, 2, -1, -4 };
	Array.Sort(a);
	var l = ThreeSum(a);
	l.Dump();
}

public IList<IList<int>> ThreeSum(int[] nums)
{
	Array.Sort(nums);

	var result = new List<IList<int>>();

	var n = nums.Length;
	for (int i = 0; i < n; i++)
	{
		if (i > 0 && nums[i - 1] == nums[i]) continue;

		var l = i + 1;
		var r = n - 1;

		while (l < r)
		{
			var sum = nums[i] + nums[l] + nums[r];
			if (sum == 0)
			{
				result.Add(new List<int>() { nums[i], nums[l], nums[r] });

				while (l < r && nums[l] == nums[l + 1])
				{
					l++;
				}
				while (l < r && nums[r] == nums[r - 1])
				{
					r--;
				}
				
				l++;
				r--;
			}
			else if (sum < 0)
			{
				l++;
			}
			else
			{
				r--;
			}
		}
	}

	return result;
}
