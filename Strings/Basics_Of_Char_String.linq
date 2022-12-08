<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	CheckStringPalindrome();
}


public void ToUpperCase()
{

	string a = "kiran";

	for (int i = 0; i < a.Length; i++)
	{
		int k = (char)a[i] - 32;
		char c = (char)k;
	}
}

public void Flip_UpperToLower_LowerToUpper()
{
	string str = "ABCxyz";
	char[] c = str.ToCharArray();

	for (int i = 0; i < c.Length; i++)
	{
		int k = c[i];
		if (k >= 65 && k < 90)  // its upper case
		{
			char r = (char)(k + 32);
			r.PrintInLine();

		}
		if (k >= 97 && k < 122)// its a lower case
		{
			char r = (char)(k - 32);
			r.PrintInLine();
		}
	}
}

public void CharConversions()
{

	char[] a = { 'A', 'B', 'C' };

	int x = (int)'A'; // Gets Ascii value of A

	Char y = (Char)x; // Gets Ascii value x which is integer

	foreach (Char c in a)
	{
		int v = ((int)c) + 32;
		Char k = (Char)v;
		k.Dump();
	}
}

public void CountTheSpace()
{

	string str = "a    b";
	int wordCount = 0;
	char[] ca = str.ToCharArray();

	for (int i = 0; i < ca.Length; i++)
	{
		if (ca[i] == ' ') // witht this we found white space Ok, now we will update only if previous char is not white space because there may be continous whitespaces
		{
			if (ca[i - 1] != ' ')
			{
				wordCount = wordCount + 1;
			}
		}
	}

	// Finally we have to print  word +1 one  as count, why +1 because this is for last word  examle " abc bbc cfg" in this string there are only two white spaces, so do +1
	(wordCount + 1).Dump();
}

public void IsValidString()
{
	// string with no special characters

	string str = "Sr%";
	char[] ca = str.ToCharArray();
	bool isValidString = true;
	for (int i = 0; i < ca.Length; i++)
	{
		int k = ca[i];
		if (!(k >= 65 && k <= 90) && !(k >= 97 && k <= 122) && !(k >= 48 && k <= 57))
		{
			// does not fall in Capital letters
			// does not fall in small letters
			// does not fall in numbers
			isValidString = false;
		}
	}
	if (isValidString == true)
	{
		"Valid String".Dump();
	}
	else
	{
		"Invalid String".Dump();
	}
}

public void CheckStringPalindrome()
{
	string str = "maddam";
	Char[] c = str.ToCharArray();
	bool isPalindrome = true;

	int s = 0, e = c.Length - 1;
	while (s < e)
	{
		if (c[s] != c[e])
		{
			isPalindrome = false;
			"Not a Palindrone".Dump();
			break;
		}
		s++; e--;
	}

	if (isPalindrome==true)
	{
		"Palindrome".Dump();
	}

}