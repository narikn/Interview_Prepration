<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

int[] F = new int[10];
void Main()
{
	//Fib_Iterative();
	//rFib(10).Dump();


	for (int i = 0; i < F.Length; i++)
	{
		F[i] = -1;
	}
	mFib(10).Dump();
}

public void Fib_Iterative()
{
	int n = 10;
	int t0 = 0, t1 = 1;
	int s = 0;

	for (int i = 2; i <= n; i++)
	{
		s = t0 + t1;
		t0 = t1;
		t1 = s;
		s.Dump();
	}
}

public int rFib(int n)
{
	if (n <= 1)
	{
		return n;
	}

	else
	{
		return rFib(n - 1) + rFib(n - 2);
	}
}

public int mFib(int n)
{  // memoziation
   // F is array 
	if (n <= 1)
	{
		F[n] = n;
		return n;
	}
	else
	{
		if (F[n - 2] == -1)
		{
			F[n - 2] = mFib(n - 2);
		}

		if (F[n - 1] == -1)
		{
			F[n - 1] = mFib(n - 1);
		}
		return F[n - 1] + F[n - 2];
	}
}