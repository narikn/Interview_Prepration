<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	string s1 = "abaac";
	string s2 = "acaba";
	int[] a = new int[26];

	IsAnagram(s1, s2);

}
public void IsAnagram(string s1, string s2)
{
	int[] a = new int[26];
	for (int i = 0; i < s1.Length; i++)
	{
		int index = (int)s1[i] - 97;
		a[index]= a[index] + 1; // or ++a[index];
	}

	for (int i = 0; i < s2.Length; i++)
	{
		int index = (int)s2[i] - 97;
		if (a[index] <= 0)
		{
			"Not Anagram".Dump();
		}
		else
		{
			a[index] = a[index] - 1;
		}
	}
	"Its Anagram".Dump();

}

