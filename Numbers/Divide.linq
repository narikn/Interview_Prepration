<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Divide(20, 3).Dump();
}


public int Divide(int dividend, int divisor)
{
	// Handle special cases
	if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
	if (dividend == int.MinValue && divisor == 1) return int.MinValue;

	// Use long to avoid integer overflow issues
	long dd = Math.Abs((long)dividend);
	long dv = Math.Abs((long)divisor);

	int ans = 0;

	// Main loop to perform the division
	while (dd >= dv)
	{
		long currentMultiple = dv;
		int multipileCount = 1;
		long nextMultiple = currentMultiple << 1; // Equivalent to currentMultiple + currentMultiple
		while (nextMultiple <= dd)
		{
			currentMultiple = nextMultiple;
			//			multipileCount = multipileCount << 1; // Equivalent to multipleCount + multipleCount
			//    		nextMultiple = currentMultiple << 1; // Equivalent to  currentMultiple + currentMultiple;

			multipileCount = multipileCount + multipileCount;
			nextMultiple = currentMultiple + currentMultiple;
		}
		ans = ans + multipileCount;
		dd = dd - currentMultiple;
	}

	// Determine if the answer should be negative
	if ((dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0)) return -ans;
	return ans;
}


