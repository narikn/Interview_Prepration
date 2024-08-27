<Query Kind="Program" />

void Main()
{
	CountZeros(1203).Dump();
}

//  Palindrome
bool IsPalindrome(string str, int s, int e)
{

	if (s >= e) return true;

	if (str[s] != str[e])
	{
		return false;
	}
	else
	{
		return IsPalindrome(str, s + 1, e - 1);
	}

}

#region Permutation
void Perm(string s, int p, List<string> r)
{

	if (p >= s.Length - 1)
	{
		r.Add(s);
		return;
	}

	for (int i = p; i < s.Length; i++)
	{
		s = Swap(s, p, i);
		Perm(s, p + 1, r);
		s = Swap(s, p, i);
	}

}

string Swap(string str, int i, int j)
{
	char[] charArray = str.ToCharArray();
	char temp = charArray[i];
	charArray[i] = charArray[j];
	charArray[j] = temp;
	return new string(charArray);
}

#endregion


int CountZeros(int n, int count = 0)
{
	if (n == 0) return count;

	if (n % 10 == 0)
		return CountZeros(n / 10, count + 1); 

	 return CountZeros(n / 10,count);
}
