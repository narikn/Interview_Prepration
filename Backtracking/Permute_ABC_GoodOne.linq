<Query Kind="Program" />

class Program
{
	static List<List<char>> collection = new List<List<char>>();

	static void Main()
	{
		List<char> chars = new List<char> { 'A', 'B','C' };
		List<List<char>> permutations = Permute(chars);

		foreach (var permutation in permutations)
		{
			Console.WriteLine(string.Join(", ", permutation));
		}
	}

	static List<List<char>> Permute(List<char> chars)
	{
		int start = 0;
		int end = chars.Count - 1;
		Permute_Helper(start, end, chars);
		return collection;
	}

	static void Permute_Helper(int start, int end, List<char> chars)
	{
		// Base condition to stop recursion
		if (start == end)
		{
			collection.Add(new List<char>(chars));
			return;
		}

		for (int i = start; i <= end; i++)
		{
			Console.WriteLine($"About to swap {chars[start]} with {chars[i]}");
			Swap(chars, start, i);
			Console.WriteLine($"Swapped: {string.Join("", chars)}");
			Permute_Helper(start + 1, end, chars);
			Console.WriteLine($"Backtracking... reverting previous state from {string.Join("", chars)} by swapping {chars[start]} back with {chars[i]}");
			Swap(chars, start, i); // Backtrack
			Console.WriteLine($"Reverted: {string.Join("", chars)}");
		}
	}

	static void Swap(List<char> chars, int i, int j)
	{
		char temp = chars[i];
		chars[i] = chars[j];
		chars[j] = temp;
	}
}
