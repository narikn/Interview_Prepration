<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[,] a = new int[3, 3] {
	{ 1, 2, 3 },
	{ 4, 5, 6 },
	{ 7, 8, 9 } };

	PrintDownWard(a);
}

public void PrintDownWard(int[,] a)
{
	int re = a.GetLength(0);
	int ce = a.GetLength(1);
	for (int col = 0; col < re; col++)
	{
		int row = 0;
		int c = col;
		while (c >= 0)
		{
			a[row, c].Dump();
			row = row + 1;
			c = c - 1;
		}
	}

	for (int row = 1; row < re; row++)
	{
		int c = ce - 1;
		int r = row;
		while (r < re)
		{
			a[r,c].Dump();
          r++;
		  c--;
		}
	}
}

public void Left_To_Top(int[,] a)
{
	int rowEnd = a.GetLength(0);
	int columnEnd = a.GetLength(1);

	for (int i = 0; i < rowEnd; i++)
	{
		int rowIndex = i;
		int columnIndex = 0;
		while (rowIndex >= 0)
		{
			a[rowIndex, columnIndex].Dump();
			rowIndex = rowIndex - 1;
			columnIndex = columnIndex + 1;
		}
	}
	for (int columnStart = 1; columnStart < columnEnd; columnStart++)
	{
		int rowIndex = rowEnd - 1;
		int columnIndex = columnStart;

		while (columnIndex <= columnEnd - 1)
		{
			a[rowIndex, columnIndex].Dump();
			rowIndex = rowIndex - 1;
			columnIndex = columnIndex + 1;

		}
	}
}