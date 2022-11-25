<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] arr = { 2, 3, 4, 5, 7 };

	int max_sum = MaxSubArraySum(arr, 0, arr.Length - 1);
	max_sum.Dump();

}


int MaxSubArraySum(int[] arr, int leftIndex, int endIndex)
{

	// Base Case: Only one element
	if (leftIndex == endIndex) return arr[leftIndex];

	int midIndex = (leftIndex + endIndex) / 2;// Find middle point

	/* Return maximum of following threepossible cases:
	a) Maximum subarray sum in left half
	b) Maximum subarray sum in right half
	c) Maximum subarray sum such that the
	subarray crosses the midpoint */

	int LSS = MaxSubArraySum(arr, leftIndex, midIndex);
	int RSS = MaxSubArraySum(arr, midIndex + 1, endIndex);
	
	int CSS = MaxCrossingSum(arr, leftIndex, midIndex, endIndex);

	return Math.Max(Math.Max(LSS, RSS), CSS);
}


// Find the maximum possible sum in arr[]
// such that arr[m] is part of it
int MaxCrossingSum(int[] arr, int leftIndex, int midIndex, int endIndex)
{
	// Include elements on left of mid.
	int sum = 0;
	int left_sum = int.MinValue;
	for (int i = midIndex; i >= leftIndex; i--)
	{
		sum = sum + arr[i];
		if (sum > left_sum)
			left_sum = sum;
	}

	// Include elements on right of mid
	sum = 0;
	int right_sum = int.MinValue;

	for (int i = midIndex + 1; i <= endIndex; i++)
	{
		sum = sum + arr[i];
		if (sum > right_sum)
			right_sum = sum;
	}

	// Return sum of elements on left
	// and right of mid
	// returning only left_sum + right_sum will fail for
	// [-2, 1]
	return Math.Max(left_sum + right_sum,
					Math.Max(left_sum, right_sum));
}

// This code is contributed by vt_m.