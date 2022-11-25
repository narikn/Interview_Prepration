<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	IsAnagram("abc","cba").Dump();
}

public bool IsAnagram(string str, string matching)
{
	string stsr = string.Empty;
	int[] arr = new int[26];

	foreach (Char ch in str)
	{
		int x = ch - 'a';
		arr[x] = arr[x] + 1;
	}
	foreach (Char ch in matching)
	{
		int y = ch - 'a';
		if (arr[y] <= 0)
		{
			return false;
		}
		arr[y] = arr[y] - 1;
	}
	return true;
}