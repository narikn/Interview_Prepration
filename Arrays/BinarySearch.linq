<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] A = { 1, 2, 3, 4, 5, 6 };
	//BS(5, A);
	Reverse(A);
}


public void Reverse(int[] A)
{
	int startIndex = 0;
	int endIndex = A.Length - 1;
	while (startIndex <= endIndex)
	{
		int temp = A[startIndex];
		A[startIndex] = A[endIndex];
		A[endIndex] = temp;

		startIndex++;
		endIndex--;
	}
	A.PrintArray();
}
public void BS(int key, int[] A)
{
	int startIndex = 0;
	int endIndex = A.Length - 1;

	while (startIndex <= endIndex)
	{
		int midIndex = (((startIndex + endIndex) / 2));
		if (A[midIndex] == key)
		{
			("Found Key at Index  " + midIndex.ToString() + "-" + A[midIndex].ToString()).Dump();
			return;
		}
		else if (key < A[midIndex])
		{
			endIndex = midIndex - 1;
		}
		else if (key > A[midIndex])
		{
			startIndex = midIndex + 1;
		}
	}
}