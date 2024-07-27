<Query Kind="Program" />

void Main()
{
	string input = "ABC";
	List<string> permutations = Permutations(input);

	foreach (string permutation in permutations)
	{
		Console.WriteLine(permutation);
	}
}

List<string> Permutations(string inputStr)
{
	List<string> results = new List<string>();
	bool[] visited = new bool[inputStr.Length];

	// Start DFS with an empty result list
	DFS(inputStr, new List<char>(), visited, results);
	return results;
}

void DFS(string inputString, List<char> result, bool[] visited, List<string> results)
{
	if (result.Count == inputString.Length)
	{
		results.Add(new string(result.ToArray()));
		return;
	}

	for (int i = 0; i < inputString.Length; i++)
	{
		if (visited[i] == false)
		{
			result.Add(inputString[i]);
			visited[i] = true;
			result.ToArray().PrintArray();

			DFS(inputString, result, visited, results);
			$"About to remove {result[result.Count - 1]}".Dump();
			result.RemoveAt(result.Count - 1);
			
			visited[i] = false;
		}
	}
}
