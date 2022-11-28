<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	foo(4, 2).Dump();
}

public int naturalSum(int n)
{

	if (n != 0)
	{
		return (n) + naturalSum(n - 1);
	}
	else
	{
		return n;
	}
}

public int Power(int m, int n)
{
	if (n == 0) return 1;

	if (n % 2 == 0)
	{
		return Power(m * m, n / 2);
	}
	else
	{
		return m * Power(m * m, (n - 1) / 2);
	}
}



public int NCR_NonRecursive(int n, int r)
{

	int a = Fact(n);
	int b = Fact(r);
	int c = Fact(n - r);

	return (a / (b * c));

}

public int Fact(int n)
{
	if (n == 0) return 1;

	return n * Fact(n - 1);

}

public int NCR_Recursive(int n, int r)
{
	if (n == r) return 1;
	if (r == 1) return n;

	return NCR_Recursive(n - 1, r - 1) + NCR_Recursive(n - 1, r);
}

