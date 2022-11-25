<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	
	//Leetcode: 438 Find All Anagrams in a String
	string s = "cbaebabacd";
	string p = "abc";


	for (int i = 0; i < s.Length - 3; i++)
	{
		if (AnyMatching(s[i], p))
		{
			var x = s.Substring(i, 3);
			if (IsAnagram(x, p))
			{
				string.Format("Anagram at {0}", i).Dump();
			}

		}
	}
}

public bool AnyMatching(Char ch, string _str)
{
	foreach (char c in _str)
	{
		if (c.Equals(ch))
		{
			return true;
		}
	}
	return false;
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