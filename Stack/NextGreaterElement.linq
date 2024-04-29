<Query Kind="Program" />


public void Main(string[] args)
{
	

	int[] a = { 5, 4, 2, 1, 3, 7 };

	int[] nextGreaterElements = NextGreaterElementTo_Left(a);

	Console.WriteLine("Next greater elements:");
	for (int i = 0; i < a.Length; i++)
	{
		Console.WriteLine($"{a[i]}: {nextGreaterElements[i]}");
	}
}

public int[] NextGreaterElementTo_Right(int[] array)
{
	int[] ax = new int[array.Length];
	Array.Fill(ax, -1);

	Stack<int> stack = new Stack<int>();

	for (int i = 0; i < array.Length; i++)
	{
		int aIn = array[i];

		while (stack.Count > 0 && aIn > array[stack.Peek()])
		{
			int index = stack.Pop();
			ax[index] = array[i];
		}
		stack.Push(i);
	}

	return ax;
}

public int[] NextGreaterElementTo_Left(int[] a)
{
	int[] ax = new int[a.Length];
	Array.Fill(ax, -1);

	Stack<int> stack = new Stack<int>();

	for (int i = a.Length - 1; i >= 0; i--)
	{
		int aIn = a[i];

		while (stack.Count > 0 && aIn >= a[stack.Peek()])
		{
			stack.Pop();
		}

		if (stack.Count > 0)
		{
			ax[i] = a[stack.Peek()];
		}
		stack.Push(i);
	}
	return ax;
}