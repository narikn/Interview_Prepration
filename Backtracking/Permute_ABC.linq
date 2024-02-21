<Query Kind="Program" />

void Main()
{

	char[] array = { 'a', 'b', 'c' };
	Permute(array, 0);
}

// https://www.youtube.com/watch?v=vKQ6oUH02gw&ab_channel=TAPACADEMY

 void Permute(char[] array, int fi)
{
	if (fi == array.Length - 1)
	{
		Console.WriteLine(array);
		return;
	}

	for (int i = fi; i < array.Length; i++)
	{
		Swap(array, fi, i);
		Permute(array, fi + 1);
		Swap(array, fi, i);
	}
}

 void Swap(char[] array, int index1, int index2)
{
	char temp = array[index1];
	array[index1] = array[index2];
	array[index2] = temp;
}