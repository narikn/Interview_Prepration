<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] arr = { 1, 2, 3, 4, 5 };
	int i = 3;

	while (i > 0)
	{
		//Rotateby_1(arr);
		i--;
	}

	Rotateby_K(arr, 2);
	//Rotateby_1(arr);
	arr.Dump();

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
			int pp =p % arr.Length;
			aux[pp] = arr[i];
		}
	}
	aux.Dump();
}

public void Rotateby_1(int[] arr)
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