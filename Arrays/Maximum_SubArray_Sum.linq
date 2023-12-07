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


public static int maxSubArraySum(int[] a)
{

	int maxSoFar = int.MinValue;
	int currentSum = 0;

	for (int i = 0; i < a.Length; i++)
	{
		currentSum = currentSum + a[i];

		if (currentSum > maxSoFar)
			maxSoFar = currentSum;
// Reset
		if (currentSum < 0)
			currentSum = 0;
	}

	return maxSoFar;
}