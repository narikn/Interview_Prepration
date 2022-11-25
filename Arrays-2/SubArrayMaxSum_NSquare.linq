<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] nums = { -2, -1 };


	MaxSubArray(nums).Dump();
}


public int? MaxSubArray(int[] nums)
{
	int? currentSum = null;
	int? maXSum = null;
	if (nums.Length == 1)
	{
		return nums[0];
	}
	for (int i = 0; i < nums.Length; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			currentSum = SumForIndexedElements(j, i, nums);
			if (currentSum != null && maXSum == null)
			{
				maXSum = currentSum;
			}
			else if (currentSum != null && maXSum != null)
			{
				if (currentSum.Value > maXSum.Value)
				{
					maXSum = currentSum;
				}
			}
		}
	}

	return maXSum;
}

public int SumForIndexedElements(int fromIndex, int toIndex, int[] arr)
{
	int sum = 0;
	for (int i = fromIndex; i <= toIndex; i++)
	{
		sum = sum + arr[i];

	}
	return sum;
}