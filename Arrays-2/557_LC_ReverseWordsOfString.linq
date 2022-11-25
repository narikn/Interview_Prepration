<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	//LC:557 Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
	string str = "Let's take LeetCode contest";

	var x = ReverseWords(str);
	x.Dump();
}

public string ReverseWords(string s)
{
	Stack<char> stack = new Stack<char>();
	StringBuilder sb = new StringBuilder();
	foreach (char ch in s)
	{
		if (ch == ' ')
		{
			while (stack.Count > 0)
			{
				sb.Append(stack.Pop());
			}
			sb.Append(ch);
		}
		else
			stack.Push(ch);
	}
	while (stack.Count > 0)
	{
		sb.Append(stack.Pop());
	}

	return sb.ToString();
}