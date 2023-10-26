<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	string s = "abcdefg";
	int offeset = 3;
	s = Res(s, 0, s.Length - 1);
	s = Res(s, 0, offeset - 1);
	s = Res(s, offeset, s.Length - 1);
	s.ToArray().PrintArray();
}



public string Res(string _s, int s, int e)
{

	if (_s.Length > 0)
	{
		char[] c = _s.ToArray();

		while (s < e)
		{
			char t = c[s];
			c[s] = c[e];
			c[e] = t;
			s++; e--;
		}
		return new string(c);
	}
	return null;
}
