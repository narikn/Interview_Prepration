<Query Kind="Program" />

void Main()
{

	int[] a = new int[] { 1, 2, 3, 6, 5, 4 };
	int idx = BreakingIndex(a);
	if (idx == -1)
	{
		Reverse(a, 0);
	}
	else
	{
		SwapAtBreakingIndex(a, idx);
		Reverse(a, idx + 1);
	}
	
	a.PrintArray();
}


int BreakingIndex(int[] a)
{
	int idx = -1;
	for (int i = a.Length - 2; i >= 0; i--)
	{
		int l = a[i];
		int r = a[i + 1];
		if (l < r)
		{
			idx = i;
			break;
		}
	}
	return idx;
}


void SwapAtBreakingIndex(int[] a, int idx)
{
	for (int i = a.Length - 1; i >= idx; i--) // right part
	{
		if (a[i] > a[idx])
		{
			Swap(a, idx, i);
			break;
		}
	}
}


void Swap(int[] a, int i, int j)
{
	int temp = a[i];
	a[i] = a[j];
	a[j] = temp;
}

void Reverse(int[] a, int from)
{
	int l = from;
	int r = a.Length - 1;
	while (l < r)
	{

		int t = a[l];
		a[l] = a[r];
		a[r] = t;
		l++;
		r--;

	}

}