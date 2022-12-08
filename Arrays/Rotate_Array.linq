<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] arr = { 1, 2, 3, 4, 5 };
	int i = 3;

	//while (i > 0)
	//{
	//	//Rotateby_1(arr);
	//	i--;
	//}

	//Rotateby_K(arr, 2);
	Right_Rotate_By_11(arr);
	arr.PrintArray();

}

public void Left_Rotate_Array_1(int[] a)
{

	int f = a[0];

	for (int i = 1; i <= a.Length - 1; i++)
	{
		a[i - 1] = a[i];
	}
	a[a.Length - 1] = f;

}

public void Right_Rotate_By_11(int[] a)
{
	int l = a[a.Length - 1];
	int lastElement = -1;
	for (int i = 1; i <= a.Length - 2; i++)
	{
		lastElement=a[i+1];
	 	a[i + 1] = a[i];
		a[i]=lastElement;
	}
	a[0] = l;

}


public void Rotate_Array_Right_by_1_Step(int[] arr)
{

	int lastElement = arr[arr.Length - 1];

	for (int i = arr.Length - 2; i >= 0; i--)
	{
		int x = arr[i + 1];
		int y = arr[i];

		arr[i + 1] = arr[i];
	}
	arr[0] = lastElement;
}

public void Rotateby_K(int[] arr, int k)
{
	int[] aux = new int[5];
	for (int i = 0; i < arr.Length; i++)
	{
		int p = i + k;
		if (p < arr.Length)
		{
			aux[p] = arr[i];
		}
		else
		{
			int pp = p % arr.Length;
			aux[pp] = arr[i];
		}
	}
	aux.Dump();
}

