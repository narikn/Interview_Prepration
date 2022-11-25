<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>


void Main()
{
	int[,] a = new int[3, 3] {
	{ 1, 2, 3},
	{ 4, 5, 6},
	{ 7, 8, 9} };


	
}

public void LowerTriangle(int[,] a)
{
	int rl = a.GetLength(0);
	int cl = a.GetLength(1);

	for (int r = 0; r < rl; r++) // for every column
	{
		int c = 0;
		while (c <= r)
		{
			//a[r, c].Dump();
			c++;
		}
	}

}

public void UpperTriangle(int[,] a)
{
	int rl = a.GetLength(0);
	int cl = a.GetLength(1);

	for (int r = 0; r < rl; r++)
	{
		int c = r;
		while (c < cl)
		{
			a[r, c].Dump();
			c++; ;
		}
	}
}