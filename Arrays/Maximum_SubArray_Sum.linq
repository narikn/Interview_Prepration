<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };

	int msf = a[0];
	int cs = 0;

	for (int i = 0; i < a.Length; i++)
	{
		cs = cs + a[i];

		if (cs > msf)
		{
			msf = cs;
		}
		if (cs < 0)
		{
			cs = 0;
		}
	}
	msf.Dump();

}



public int MaxSubArray(int[] nums)
{
	// easy to understand and better way to remember the logic
	int maxSum = nums[0];
	int currSum = nums[0];

	for (int i = 1; i < nums.Length; i++)
	{
		if (currSum < 0)
		{
			currSum = 0;
			// start =i ; to print subarray index
		}
		currSum += nums[i];
		if (currSum > maxSum)
		{
			maxSum = currSum;
				// end =i ; to print subarray index
		}

	}

	return maxSum;

}

public static int maxSubArraySum(int[] a)
{

	int maxSoFar = int.MinValue;
	int currentSum = 0;

	for (int i = 0; i < a.Length; i++)
	{
		// Reset
		if (currentSum < 0)
			currentSum = 0;
			
		currentSum = currentSum + a[i];

		if (currentSum > maxSoFar)
			maxSoFar = currentSum;

	}

	return maxSoFar;
}




 // Maximum sum subarray of size range [L, R]
 // https://www.geeksforgeeks.org/maximum-sum-subarray-of-size-range-l-r/
public int[] CalculatePrefixSum(int[] a)
{
	int n = a.Length;
	int[] prefixSum = new int[n];

	prefixSum[0] = a[0];
	for (int i = 1; i < n; i++)
	{
		prefixSum[i] = a[i]+ prefixSum[i - 1]; //current element+ previous element
	}

	return prefixSum;
}



public int CalculateRangeSum(int[] prefixSum, int L, int R)
{
	if (R >= prefixSum.Length || L < 0 || L > R)
	{
		throw new ArgumentException("Invalid range parameters");
	}

	if (L == 0)
	{
		return prefixSum[R];
	}
	else
	{
		return prefixSum[R] - prefixSum[L - 1];
	}
}
