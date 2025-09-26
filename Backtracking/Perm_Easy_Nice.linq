<Query Kind="Program" />

void Main()
{
	int[] numbers = { 1, 2, 3 }; // The numbers to arrange
	List<int> current = new List<int>(); // Holds the current arrangement

	Perm(numbers, current); // Start the backtracking
}



void Perm(int[] a, List<int> c)
{

	if (c.Count() == a.Length)
	{
		Console.WriteLine(string.Join(",", c));
	}

	for (int i = 0; i < a.Length; i++)
	{
		if (c.Contains(a[i]))
			continue;

		c.Add(a[i]);
		Perm(a, c);
		
		c.Remove(c.Count() - 1);

	}
}

private void Backtrack(List<List<int>> resultList, List<int> col, int[] nums)
{
	// If we match the length, it is a permutation
	if (col.Count == nums.Length)
	{
		resultList.Add(new List<int>(col));
		return;
	}

	foreach (int number in nums)
	{
		// Skip if we get same element
		if (col.Contains(number))
			continue;

		// Add the new element
		col.Add(number);

		// Go back to try other element
		Backtrack(resultList, col, nums);

		// Remove the element
		col.RemoveAt(col.Count - 1);
	}
}



void GeneratePermutations(string str, string current, bool[] used)
{
	// Base case: All characters are used
	if (current.Length == str.Length)
	{
		Console.WriteLine(current); // Process current permutation
		return;
	}

	for (int i = 0; i < str.Length; i++)
	{
		// Skip already used characters
		if (used[i]) continue;

		// Mark the character as used
		used[i] = true;

		// Include the current character in the permutation
		GeneratePermutations(str, current + str[i], used);

		// Backtrack: Unmark the character as used
		used[i] = false;
	}
}


//function Backtrack(array, currentList):
//    # Step 1: Check if the arrangement is complete
//    if currentList.size == array.size:
//        print currentList  # Output the valid arrangement
//        return
//
//	# Step 2: Try each element in the array
//	for each number in array:
//        # Step 3: Skip if the number is already in currentList
//        if number is already in currentList:
//continue  # Skip to the next number
//
//        # Step 4: Add the number to currentList
//        add number to currentList
//
//		# Step 5: Call Backtrack recursively
//		Backtrack(array, currentList)
//
//		# Step 6: Backtrack by removing the last number
//		remove the last number from currentList




//Start: []
//
//  Add 1 -> [1]
//    Add 2 -> [1, 2]
//      Add 3 -> [1, 2, 3]  --> Output: 1, 2, 3
//      Remove 3 <- [1, 2]
//    Remove 2 <- [1]
//    Add 3 -> [1, 3]
//      Add 2 -> [1, 3, 2]  --> Output: 1, 3, 2
//      Remove 2 <- [1, 3]
//    Remove 3 <- [1]
//  Remove 1 <- []
//
//  Add 2 -> [2]
//    Add 1 -> [2, 1]
//      Add 3 -> [2, 1, 3]  --> Output: 2, 1, 3
//      Remove 3 <- [2, 1]
//    Remove 1 <- [2]
//    Add 3 -> [2, 3]
//      Add 1 -> [2, 3, 1]  --> Output: 2, 3, 1
//      Remove 1 <- [2, 3]
//    Remove 3 <- [2]
//  Remove 2 <- []
//
//  Add 3 -> [3]
//    Add 1 -> [3, 1]
//      Add 2 -> [3, 1, 2]  --> Output: 3, 1, 2
//      Remove 2 <- [3, 1]
//    Remove 1 <- [3]
//    Add 2 -> [3, 2]
//      Add 1 -> [3, 2, 1]  --> Output: 3, 2, 1
//      Remove 1 <- [3, 2]
//    Remove 2 <- [3]
//  Remove 3 <- []
//