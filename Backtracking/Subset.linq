<Query Kind="Program" />

void Main()
{
	
}


public void GenerateSubsets(string s)
{
	var resultList = new List<string>();
	Backtrack(s, 0, new List<char>(), resultList);

	// Print all subsets
	foreach (var subset in resultList)
	{
		Console.WriteLine(subset);
	}
}

private void Backtrack(string s, int index, List<char> currentSubset, List<string> resultList)
{
	if (index == s.Length)
	{
		// Convert list to string and add to results
		resultList.Add(new string(currentSubset.ToArray()));
		return;
	}

	// Case 1: Exclude the current character
	Backtrack(s, index + 1, currentSubset, resultList);

	// Case 2: Include the current character
	currentSubset.Add(s[index]);
	Backtrack(s, index + 1, currentSubset, resultList);

	// Undo the inclusion of the current character (backtracking)
	currentSubset.RemoveAt(currentSubset.Count - 1);
}

