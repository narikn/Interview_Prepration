<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	//Calculate.e(1, 10).Dump();
	double d = E(1, 10);
	d.Dump();
	PowerClass.Power(1, 10).P();
	//E_Recursion(1, 10).Dump();

}



class Calculate
{
	// takes n square multiplications  are required.n(n+1) multiplications

	// Recursive Function with static
	// variables p and f
	static double p = 1, f = 1;
	public static double e(int x, int n)
	{
		double r;

		// Termination condition
		if (n == 0)
			return 1;

		// Recursive call
		r = e(x, n - 1);

		// Update the power of x
		p = p * x;

		// Factorial
		f = f * n;

		return (r + p / f);
	}
}


public class PowerClass
{
	static double p = 1;
	static double f = 1;
	static double r = 1;
	public static double Power(int x, int n)
	{
		if (n == 0) return 1;
		r = Power(x, n - 1);
		p = p * x;
		f = f * n;
		return (r + p / f);
	}
}

public double E(int x, int n)
{  // using Horners rule
	double s = 1;

	while (n > 0)
	{
		s = 1 + ((double)x / n) * s;  // x/n is integer division , we need precision so convert numerator double or cast whole x/n result to double
		n--;
	}
	return s;
}

public double E_Recursion(int x, int n)
{ // using Horners rule
	double s = 1;

	s = 1 + ((double)(x / n)) * s; // x/n is integer division , we need precision so cast whole x/n result to double
	return E(x, n - 1);
}