<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	// refer abdul bari recurssion for explnation.
	Power(2, 5).Dump();

	// Recurrence relation: Pow(m,n-1)*m  == > why this see abdul bari video
}

public int Power_Optimized(int x, int n)
{
	if (n == 0)
	{
		return 1;
	}

	if (n % 2 == 0)
	{
		return Power_Optimized(x * x, n / 2);
	}
	else
	{
		return x * Power_Optimized(x * x, (n - 1) / 2);
	}
}


public int Power(int m, int n)
{
	if (n == 0) return 1;
	return Power(m, n - 1) * m;
}