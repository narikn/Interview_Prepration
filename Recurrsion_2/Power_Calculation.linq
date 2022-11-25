<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	// refer abdul bari recurssion for explnation.
Power(2,5).Dump();
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

