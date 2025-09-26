<Query Kind="Program" />


void Main(string[] args)
{

	int[] input = new int[] { 1, 2, 3 };

	GeneratePermutations(input, new List<int>());
}

void GeneratePermutations(int[] ar, List<int> col)
{
	// Base case: If the current list (col) has all the elements of the array, we have a complete permutation
	if (col.Count == ar.Length)
	{
		// Print the completed permutation
		Console.WriteLine(string.Join(" ", col));
		return; // End this branch of recursion
	}

	// Get all the numbers that are not yet used in the current permutation
	var choices = GetAvailableChoices(ar, col);

	// Try each available number as the next element in the permutation
	foreach (var choice in choices)
	{
		// Add the chosen number to the current permutation
		col.Add(choice);

		// Recur with the updated list
		GeneratePermutations(ar, col);

		// Backtrack: Remove the last number added to try other possibilities
		
		col.RemoveAt(col.Count - 1);
	}
}

List<int> GetAvailableChoices(int[] input, List<int> current)
{
	// Create a new list to store the numbers that can still be used
	List<int> choices = new List<int>();

	// Go through every number in the input array
	foreach (var c in input)
	{
		// If the number is not already in the current list, it is available to use
		if (current.Contains(c) == false)
		{
			choices.Add(c);
		}
	}

	// Return the list of available numbers
	return choices;
}



// You can define other methods, fields, classes and namespaces here