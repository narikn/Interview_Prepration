<Query Kind="Program" />


public void Main(string[] args)
{
	int[] array = { 1, 2, 3, 4, 5 };

	int[] nextGreaterElements = NextGreaterElementTo_Right(array);

	Console.WriteLine("Next greater elements:");
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine($"{array[i]}: {nextGreaterElements[i]}");
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

public int[] NextGreaterElementTo_Left(int[] array)
{
	int[] ax = new int[array.Length];
	Array.Fill(ax, -1);

	Stack<int> stack = new Stack<int>();

	for (int i = array.Length - 1; i >= 0; i--)
	{
		int aIn = array[i];

		while (stack.Count > 0 && aIn >= array[stack.Peek()])
		{
			int index = stack.Pop();
			ax[index] = array[i];
		}
		stack.Push(i);
	}

	return ax;
}