<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] A = { 1, 3, 5, 7 };
	int[] B = { 2, 4, 6, 8 };
	int[] C = new int[A.Length + B.Length];

	int leftIndex = 0;
	int rightIndex = 0;
	int k = 0;

	while (leftIndex < A.Length && rightIndex < B.Length)
	{
		if (A[leftIndex] < B[rightIndex])
		{
			C[k] = A[leftIndex];

			leftIndex++;
			k++;
		}
		else
		{
			C[k] = B[rightIndex];
			rightIndex++;
			k++;
		}
	}
	
	//	for (; i < n1; i++)
	//	{
	//		arr3[k] = arr1[i];
	//		k++;
	//	}
	//	for (; j < n2; j++)
	//	{
	//		arr3[k] = arr2[j];
	//		k++;
	//	}

	while (leftIndex < A.Length)
	{
		C[k] = A[leftIndex];
		leftIndex++;
		k++;
	}
	while (rightIndex < B.Length)
	{
		C[k] = B[rightIndex];
		rightIndex++;
		k++;
	}

	C.Dump();
}

