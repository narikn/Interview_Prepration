<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	naturalSum(3).Dump();
	Fact(4).Dump();
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

public int Fact(int n)
{
	if (n == 0)
	{
		return 1;
	}
	else
	{
		return n * Fact(n - 1);
	}

}

public int Power(int x, int n)
{
	if (n == 0)
	{
		return 1;
	}

	if (n % 2 == 0)
	{
		return Power(x * x, n / 2);
	}
	else
	{
		return x * Power(x * x, (n - 1) / 2);
	}
}
