<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	//	int[][] a = new int[2][] { new int[] { 1, 4 }, new int[] { 2, 8 } };
	int[][] a = new int[2][] { new int[] { 1, 9 }, new int[] { 12, 5 } };
	Merge_1(a);
}


public int[][] Merge_1(int[][] a)
{
	if (a == null || a.Length == 0 || a.Length == 1)
		return a;

	List<int[]> c = new List<int[]>();

	a = a.OrderBy(x => x[0]).ToArray();

	int x1 = a[0][0];
	int y1 = a[0][1];

	for (int i = 1; i < a.Length; i++)
	{
		int x2 = a[i][0];
		if (x2 > y1)
		{
			c.Add(new int[] { x1, y1 });
			x1 = a[i][0];
			y1 = a[i][1];
		}
		else
		{
			y1 = Math.Max(y1, a[i][1]);
		}
	}

	c.Add(new int[] { x1, y1 });
	Print(c);
	return c.ToArray();
}
public int[][] Merge_2(int[][] a)
{
	if (a == null || a.Length == 0 || a.Length == 1)
		return a;

	List<int[]> c = new List<int[]>();
	a = a.OrderBy(x => x[0]).ToArray();

	int x1 = a[0][0];
	int y1 = a[0][1];

	for (int i = 1; i < a.Length; i++)
	{
		int x2 = a[i][0];
		int y2 = a[i][1];

		if (x2 < y1) // x2 falls in between first range
		{
			y1 = Math.Max(y1, y2); // then find max y
		}
		else
		{  //  else first and second ranges are different , add first range to collection
			c.Add(new int[] { x1, y1 });
			x1 = x2;
			y1 = y2;
		}
		c.Add(new int[] { x1, y1 });
	}
	Print(c);
	return c.ToArray();
}

public void Print(List<int[]> a)
{
	foreach (var element in a)
	{
		string.Format("{0} --{1}", element[0], element[1]).Dump();
	}
}



public void Merge_Stack()
{
	int[][] a = new int[2][] { new int[] { 1, 9 }, new int[] { 4, 5 } };
	a = a.OrderBy(x => x[0]).ToArray();

	Stack<int[]> c = new Stack<int[]>();

	for (int i = 0; i < a.Length; i++)
	{
		if (c.Count == 0)
		{
			c.Push(a[i]);
		}
		else
		{
			int[] cp = c.Pop();
			int y1 = cp[1];
			int[] current = a[i];
			int x2 = current[0];
			int y2 = current[1];

			if (x2 <= y1) // overlapping
			{
				cp[1] = Math.Max(y1, y2);
				c.Push(cp);
			}
			else
			{
				c.Push(a[i]);
			}
		}
	}
	PrintStack(c);
	c.ToArray();
}

public void PrintStack(Stack<int[]> a)
{
	foreach (var element in a)
	{
		string.Format("{0} --{1}", element[0], element[1]).Dump();
	}
}