<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] a = { 1, 3, 6, 5 };
	int[] b = { 2, 4, 3, 5, 7 };
	Intersection(a, b);

}



public void Intersection(int[] a, int[] b)
{
	// first sort both arrays ; for unsorted union takes order n square time complexity 

	Array.Sort(a);
	Array.Sort(b);

	int[] c = new int[a.Length + b.Length];

	int i = 0;
	int j = 0;
	int k = 0;

	while (i < a.Length && j < b.Length)
	{
		if (a[i] == b[j])
		{
			c[k] = a[i];
			k++;
			i++; j++;
		}
		else if (a[i] < b[j])
		{
			i++;
		}
		else { j++; }
	}

	c.PrintArray();
}

public void Set_Union(int[] a, int[] b)
{
	// first sort both arrays ; for unsorted union takes order n square time complexity 
	Array.Sort(a);
	Array.Sort(b);

	int[] c = new int[a.Length + b.Length];

	int i = 0;
	int j = 0;
	int k = 0;
	while (i < a.Length && j < b.Length)
	{

		if (a[i] == b[j])
		{
			c[k] = a[i];
			i++;
			j++;
			k++;
		}
		else if (a[i] < b[j])
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
		i++;
		k++;
	}

	while (j < b.Length)
	{
		c[k] = b[j];
		j++;
		k++;
	}

	c.PrintArray();

}

public void Merge(int[] a, int[] b)
{
	// first sort both arrays ; for unsorted union takes order n square time complexity 

	Array.Sort(a);
	Array.Sort(b);

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
		i++;
		k++;
	}

	while (j < b.Length)
	{
		c[k] = b[j];
		j++;
		k++;
	}

	c.PrintArray();
}

public void Difference(int[] a, int[] b)
{
	// first sort both arrays ; for unsorted union takes order n square time complexity 

	Array.Sort(a);
	Array.Sort(b);


	int[] c = new int[a.Length + b.Length];

	int i = 0, j = 0, k = 0;
	int m = a.Length - 1;
	int n = b.Length - 1;

	while (i <= m && j <= n)
	{
		if (a[i] < b[j])
		{
			c[k] = a[i];
			i++;
			k++;
		}
		else
		{
			j++;
		}
	}

	while (i <= m)
	{
		c[k] = a[i];
		i++;
	}
	c.PrintArray();
}