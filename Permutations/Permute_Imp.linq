<Query Kind="Program" />

void Main()
{
	int[] nums = { 1, 2, 3 };
	Permute2(nums, 0,0);
}


void Permute(int[] arr, int fix)
{
	if (fix == arr.Length - 1)
	{
		Console.WriteLine(string.Join(",", arr));
	}
	else
	{
		for (int i = 0; i < arr.Length; i++)   // always start from 0
		{
			Swap(arr, fix, i);
			Permute(arr, fix + 1);
			Swap(arr, fix, i); // backtrack
							 
		}
	}
}

void Swap(int[] arr, int i, int j)
{
	int temp = arr[i];
	arr[i] = arr[j];
	arr[j] = temp;
}


 void Permute2(int[] arr, int fix, int idx)
{
	if (fix == arr.Length - 1)
	{
		Console.WriteLine(string.Join(",", arr));
	}
	else
	{
		for (int i = idx; i < arr.Length; i++)
		{
			Swap(arr, fix, i);
			Permute2(arr, fix + 1, i); // continue from current i
			Swap(arr, fix, i);
		}
	}
}



