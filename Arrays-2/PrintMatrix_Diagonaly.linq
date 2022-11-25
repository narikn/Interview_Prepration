<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[,] a = new int[3, 3] {
	{ 1, 2, 3 },
	{ 4, 5, 6 },
	{ 7, 8, 9 } };

	Top_to_Left(a);
}

public void Top_to_Left(int[,] a)
{
	int re = a.GetLength(0);
	int ce = a.GetLength(1);

	for (int c = 0; c < ce; c++)
	{
		int r = 0;
		int columnIndex = c;
		while (r <= c)
		{
			a[r, columnIndex].Dump();
			r = r + 1;
			columnIndex = columnIndex - 1;
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