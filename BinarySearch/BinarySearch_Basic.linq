<Query Kind="Program" />

void Main()
{

	BinarySearchRecursion();

}

public void BinarySearch_Iterative()
{

	int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

	int l = 0;
	int r = a.Length - 1;
	int k = 7;
	while (l <= r)
	{
		int mid = l + (r - l / 2);

		if (mid == k) { $"Found {mid}".Dump(); return; }

		if (k < mid)
		{
			r = mid - 1;
		}

		if (k > mid)
		{
			l = mid + 1;
		}
	}
}

public void BinarySearchRecursion()
{
	int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
	int l = 0;
	int h = a.Length - 1;
	int k = 7;
	BinarySearch(a, k, l, h);
}

public int BinarySearch(int[] a, int k, int l, int r)
{
	int mid = l + (r - l) / 2;

	if (a[mid] == k) { $"Found {mid}".Dump(); return mid; }
	if (k > a[mid]) return BinarySearch(a, k, mid + 1, r);  // K is greater than Mid , so search right side
	if (k < a[mid]) return BinarySearch(a, k, l, mid - 1);  // K is less than mid , so search left side

	return -1;
}