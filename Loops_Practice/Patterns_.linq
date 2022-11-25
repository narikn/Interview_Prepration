<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

	Pattern_2();
}

public void Pattern_1()
{
	int n = 5;
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n - i; j++)
		{
			Console.Write("*");
		}
		Console.WriteLine();
	}
}

public void Pattern_2()
{

	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			Console.Write("*");
		}
		Console.WriteLine();
	}
}

public void Pattern_3()
{
	int n = 5;
	int sp = n - 1, st = 1;

	for (int i = 0; i < n; i++)
	{

		for (int j = 0; j < sp; j++)
		{
			Console.Write("\t");
		}
		sp--;
		for (int k = 0; k < st; k++)
		{
			Console.Write("*");
		}
		st++;
		Console.WriteLine();
	}
}

public void Pattern_4()
{

	int n = 5;
	int s = n;
	int sp = 0;


	for (int i = 0; i < n; i++)
	{
		for (int p = 0; p < sp; p++)
		{
			Console.Write("\t");
		}
		sp++;
		for (int k = 0; k < s; k++)
		{
			Console.Write("*");
		}
		s--;
		Console.WriteLine();
	}
}

public void Pattern_5_Diamond()
{
	int n = 5;// should be odd always;

	int sp = n / 2;
	int st = 1;

	//for (int i = 0; i < n; i++)
	//{
	//	string.Format("{0} ,{1}", sp, st).Dump();
	//	if (i < n / 2)
	//	{
	//		sp--;
	//		st = st + 2;
	//	}
	//	else
	//	{
	//		sp++;
	//		st = st - 2;
	//	}
	//}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < sp; j++)
		{
			Console.Write("\t");
		}
		for (int k = 0; k < st; k++)
		{
			Console.WriteLine("*");
		}
		if (i < n / 2)
		{
			sp--;
			st = st + 2;
		}
		else
		{
			sp++;
			st = st - 2;
		}
		Console.WriteLine();
	}

}