<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 1, 3, 5, 7 };
	int[] b = { 2, 4, 6, 8 };
	int[] c = new int[a.Length + b.Length];

	int i = 0;
	int j = 0;
	int k = 0;

	while (i < a.Length && j < b.Length)
	{
		if (a[i] < b[j])
		{
			c[k] = a[i];
			i++;
			k++;
		}
		else
		{
			c[k] = b[j];
			j++;
			k++;
		}
	}
	while (i < a.Length)
	{
		c[k] = a[i];
		k++;
		i++;
	}
	while (j < b.Length)
	{
		c[k] = b[j];
		k++;
		j++;
	}
	c.Dump();
}





