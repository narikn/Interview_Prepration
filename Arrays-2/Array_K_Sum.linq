<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 4, 2, 5, 3, 1, 8 };

	findSubArray(a, 9);
}

public void findSubArray(int[] arr, int sum)
{
	if (arr.Length == 0)
	{
		("Array is empty").Dump();
		return;
	}

	int end, totalSumTillNow;
	end = 0;
	totalSumTillNow = 0;

	Dictionary<int, int> map = new Dictionary<int, int>();

	while (end < arr.Length)
	{
		totalSumTillNow = totalSumTillNow + arr[end];

		if (totalSumTillNow == sum)
		{
			("Start Index: " + 0 + ", End Index: " + end).Dump();
			return;
		}

		int windowSum = totalSumTillNow - sum;

		if (map.ContainsKey(windowSum))
		{
			int start = map[windowSum];
			("Start Index: " + (start + 1) + ", End Index: " + end).Dump();
			return;
		}

		map.Add(totalSumTillNow, end++);
	}
}


