<Query Kind="Program" />

void Main()
{
MoveZerosToEnd_Optimized();
}

public void MoveZerosToEnd()
{

	var a = new int[] { 1, 3, 0, 0, 5, 9, 0, 7, 9 };

	int j = 0;

	for (int i = 0; i < a.Length; i++)
	{
		if (a[i] != 0)
		{

			a[j] = a[i];
			//a.Swap(j, i,true);// when you find non-zero element swap with j and increase j

			j++;
		}
		//a.PrintArrayAtIndex(1, i);
		//a.PrintArray();
		a.PrintArrayWithIteration(i, j, "i", "j");
	}

	while(j<a.Length)
	{
		a[j]=0;
		j++;
	}
	a.PrintArray();

}

public void MoveZerosToEnd_Optimized()
{

	var a = new int[] { 1, 3, 0, 0, 5, 9, 0, 7, 9 };

	int j = 0;

	for (int i = 0; i < a.Length; i++)
	{
		if (a[i] != 0)
		{
			a.Swap(j, i,true);// when you find non-zero element swap with j and increase j
			j++;
		}
	
		a.PrintArrayWithIteration(i, j, "i", "j");
	}
	
	a.PrintArray();
}

