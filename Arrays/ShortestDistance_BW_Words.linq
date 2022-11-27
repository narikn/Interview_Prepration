<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

	string[] s = { "practice", "makes", "perfect", "coding", "makes" };
	string w1 = "coding", w2 = "practice";

	int a = -1;
	int b = -1;

	int mindistance = int.MaxValue;

	for (int i = 0; i < s.Length; i++)
	{
		if (s[i].Equals(w1))
		{
			a=i;
		}

		if (s[i].Equals(w2))
		{
			b=i;
		}
		if (a != -1 && b != -1)
		{mindistance = Math.Min(mindistance, Math.Abs(a - b));

		}
		
	}
	mindistance.Dump();
}

// Define other methods and classes here
