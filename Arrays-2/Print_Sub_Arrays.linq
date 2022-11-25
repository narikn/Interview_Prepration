<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int count = 0;
	int[] arr = { 1, 2, 3, 4, 5 };
	//int[] arr = { 2, 1, 5, 0, 9 };
	//Logic_1(arr);
	//Logic_2(arr);
	//Logic_3(arr);
	//Logic_4(arr);
//	Logic_5_Back(arr);
 	//Logic_6_Back(arr);
}

public void Logic_1(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		for (int j = i; j < arr.Length; j++)
		{   // internal j loop is fast mover
			//Print(i, j, arr);
			string.Format("{0} {1}", i, j).Dump();
			count++;
		}
		"--------------".Dump();
	}
	"--------------".Dump();
	string.Format("Sub array count {0}", count).Dump();

}

public void Logic_2(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		for (int j = 0; j < arr.Length; j++)
		{
			//Print(i, j, arr);
			string.Format("{0} {1}", i, j).Dump();
			//count++;
		}
		"--------------".Dump();
	}
	"--------------".Dump();
	string.Format("Sub array count {0}", count).Dump();

}

public void Logic_3(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		for (int j = 0; j <= i; j++)
		{
			//Print(j, i, arr);

			//count++;
			string.Format("{0} {1}", j, i).Dump();
		}
		"--------------".Dump();
	}
	"--------------".Dump();
	string.Format("Sub array count {0}", count).Dump();
}

public void Logic_4(int[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		for (int j = i; j <= i && j >= 0; j--)
		{
			//Print(j, i, arr);

			//count++;
			string.Format("{0} {1}", j, i).Dump();
		}
		"--------------".Dump();
	}
	"--------------".Dump();
	string.Format("Sub array count {0}", count).Dump();
}

public void Logic_5_Back(int[] arr)
{
	for (int i = arr.Length - 1; i >= 0; i--)
	{
		for (int j = i; j >= 0; j--)
		{
			PrintReverse(i, j, arr);
			//string.Format("{0} {1}", j, i).Dump();
		}
		"--------------".Dump();
	}

}

public void Logic_6_Back(int[] arr)
{
	for (int i = arr.Length - 1; i >= 0; i--)
	{
		for (int j = arr.Length-1; j >= i; j--)
		{
			PrintReverse(j, i, arr);
		}
		"--------------".Dump();
	}

}

public void Print(int startIndex, int endIndex, int[] arr)
{
	string str = string.Empty;
	for (int i = startIndex; i <= endIndex; i++)
	{
		str = str + arr[i];
	}
	str.Dump();
}

public void PrintReverse(int startIndex, int endIndex, int[] arr)
{
	string str = string.Empty;
	for (int i = startIndex; i >= endIndex; i--)
	{
		str = str + arr[i];
	}
	str.Dump();
}