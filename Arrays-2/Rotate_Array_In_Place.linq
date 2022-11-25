<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 1, 2, 3, 4, 5 };
	int k = 2;
	int arrayLength = a.Length;
	// Complete swap
	SwapArray(a, 0, arrayLength - 1);
	a.PrintArray();
	SplitSwap(a, k - 1);
	a.PrintArray();

	//in short
	//SwapArray(a, 0, a.Length - 1);
	//SwapArray(a, 0, k - 1);
	//SwapArray(a, k, a.Length - 1);
}

public void SwapArray(int[] a, int startIndex, int endIndex)
{
	if (a.Length > 1)
	{
		while (startIndex < endIndex)
		{
			int x = a[startIndex];
			a[startIndex] = a[endIndex];
			a[endIndex] = x;
			startIndex++;
			endIndex--;
		}
	}
}

public void SplitSwap(int[] arr, int k)
{
	SwapArray(arr, 0, k);
	SwapArray(arr, k + 1, arr.Length - 1);
}