<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 1, 2, 3, 3, 3, 4, 5 };
	RemoveDuplicates(a);

}
public void RemoveDuplicates(int[] a)
{

	int j = 1;

	for (int i = 0; i < a.Length - 1; i++)
	{
		if (a[i] != a[i + 1])
		{
			a[j] = a[i + 1];
			j++;
		}
	}
	//	a.PrintArrayTillIndex(j);
}



public void RemoveDuplicates2(int[] a)
{

	int j = 0;

	for (int i = 0; i < a.Length - 1; i++)
	{
		if (a[i] != a[i + 1])
		{
			a[j] = a[i];
			j++;
		}
	}
	a[j++] = a[a.Length - 1];
	a.PrintArrayTillIndex(j);
}


public void RemoveDuplicates_1(int[] a)
{
	int[] ax = new int[a.Length];

	ax[0] = a[0];
	int j = 0;
	for (int i = 1; i < a.Length; i++)
	{
		if (a[i] != ax[j]) 
		{
			a[j]=a[i+1];
			j++;
			
		}
	}

}