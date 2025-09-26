<Query Kind="Program" />

  void Main()
{
	int[] nums = { 1, 2, 3 };

	// DFS Permutation: Using backtracking to generate permutations
	var dfsResult = new List<List<int>>();

	// 'used' array keeps track of which elements in 'nums' are already in the current permutation
	var used = new bool[nums.Length]; // Initially, all elements are marked as not used
	Backtrack(nums, new List<int>(), dfsResult, used); // Call Backtrack to generate permutations
	Console.WriteLine("DFS Permutations:");
	foreach (var perm in dfsResult)
	{
		Console.WriteLine(string.Join(", ", perm)); // Print each permutation in the result
	}

	// BFS Permutation: Using a queue to generate permutations iteratively
	var bfsResult = GeneratePermutations(nums); // Generate permutations using BFS
	Console.WriteLine("BFS Permutations:");
	foreach (var perm in bfsResult)
	{
		Console.WriteLine(string.Join(", ", perm)); // Print each permutation in the result
	}
}

void Backtrack(int[] nums, List<int> current, List<List<int>> result, bool[] used)
{
	if (current.Count == nums.Length)
	{
		// Base case: If current permutation has all elements, add it to result
		result.Add(new List<int>(current)); // Add the current complete permutation to result
		return;
	}

	for (int i = 0; i < nums.Length; i++)
	{
		if (used[i])
			continue; // Skip if this element has already been used in the current permutation

		used[i] = true; // Mark the element as used in the current permutation

		current.Add(nums[i]); // Add the current element to the current permutation
		
		Backtrack(nums, current, result, used); // Recurse to build the next part of the permutation
		
		current.RemoveAt(current.Count - 1); // Backtrack: Remove the last element added
		
		used[i] = false; // Unmark this element so it can be used in the next permutation
	}
}

List<List<int>> GeneratePermutations(int[] nums)
{
	var result = new List<List<int>>(); // List to store all permutations
	var queue = new Queue<List<int>>(); // Queue to manage the current list of permutations
	queue.Enqueue(new List<int>()); // Start with an empty permutation

	// Process permutations level by level
	while (queue.Count > 0)
	{
		var current = queue.Dequeue(); // Dequeue the next permutation to explore

		if (current.Count == nums.Length)
		{
			// Base case: If the current permutation is complete
			result.Add(new List<int>(current)); // Add it to the result
			continue;
		}

		// Loop through each element in nums to add it to the current permutation
		for (int i = 0; i < nums.Length; i++)
		{
			if (current.Contains(nums[i]))
				continue; // Skip if the element is already in the current permutation

			// Create a new permutation by adding the current element to the existing permutation
			var newPerm = new List<int>(current) { nums[i] };
			queue.Enqueue(newPerm); // Add the new permutation to the queue for further processing
		}
	}
	return result;
}
