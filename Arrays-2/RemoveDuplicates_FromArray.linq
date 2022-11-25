<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 1, 2, 2, 2, 3, 3, 4 };

	int i = 0;
	int j = 1;

	while (j < a.Length)
	{
		if (a[i] == a[j])
		{
			j++;
		}
		else
		{
			ShiftLeft(a, i + 1, j);
			i++;
			j++;

		}
	}
	a.PrintArray();
}

public void ShiftLeft(int[] a, int i, int j)
{

	int x = a[i];
	int y = a[j];

	a[i] = a[j];
}

public void RemoveDups()
{ //  very good logic

	int[] a = { 1, 1, 1, 2, 2, 3, 3, 4 };

	int idx = 1;

	for (int i = 1; i < a.Length; i++)
	{
		if (a[i] == a[idx - 1])
		{

		}
		else
		{
			a[idx] = a[i];
			idx++;
		}

	}
	a.Dump();
}
public void RemoveDuplicates_2()
{
	int[] a = { 1, 1, 1, 2, 2, 4, 5 };

	int i = 0;

	for (int j = 1; j < a.Length; j++)
	{
		if (a[i] == a[j])
		{
		}
		else
		{
			a[i + 1] = a[j];
			i++;
		}
	}
	//i.Dump();
	a.Dump();
}