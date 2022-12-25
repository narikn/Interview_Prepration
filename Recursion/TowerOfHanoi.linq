<Query Kind="Program" />

void Main()
{
	// This will print steps to move disks from 1st to 3rd
	TOH(4, 1, 2, 3);
}

void TOH(int n, int A, int B, int C)
{
	if (n > 0)
	{
		TOH(n - 1, A, C, B);
		$"{A} {C}".Dump();
		TOH(n - 1, B, A, C);
	}
}