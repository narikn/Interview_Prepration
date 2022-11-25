<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 1,2,3 };

	Find_Subarray(a, 3).Dump(); ;


}
public bool Find_Subarray(int[] a, int k)
{
	int sum = 0;
	int start = 0;
	for (int i = 0; i < a.Length; i++)
	{
		if (i < a.Length)
		{
			sum = sum + a[i];
		}
		while (sum > k && start < i - 1)
		{
			sum = sum - a[start];
			start++;
		}
		if (sum == k)
		{
			
			return true;
		}
	}
	return false;
}

