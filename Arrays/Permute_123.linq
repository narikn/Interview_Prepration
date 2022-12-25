<Query Kind="Program" />

void Main()
{
	int[] a = new int[] { 1, 2, 3 };
	permute(a).PrintListOfList();
}


public virtual IList<IList<int>> permute(int[] nums)
{
	IList<IList<int>> resultList = new List<IList<int>>();
	List<int> tempList = new List<int>();

	DFS_Backtrack(nums, resultList, tempList);

	return resultList;
}

private void DFS_Backtrack(int[] nums, IList<IList<int>> resultList, List<int> tempList)
{
	// If we match the length, it is a permutation
	if (tempList.Count == nums.Length)
	{
		resultList.Add(new List<int>(tempList));
		return;
	}

//tempList.PrintListInLine();
//"".Dump();
	foreach (int number in nums)
	{
		// Skip if we get same element
		if (tempList.Contains(number))
		{
			continue;
		}

		// Add the new element
		tempList.Add(number);

		// Go back to try other element
		DFS_Backtrack(nums, resultList, tempList);

		// Remove the element
	//	$"---  Remove {tempList[tempList.Count - 1]} from temporary list ---".Dump();
		tempList.RemoveAt(tempList.Count - 1);
	}
}

//---Remove 3 from temporary list ---
//---Remove 2 from temporary list ---
//---Remove 2 from temporary list ---
//---Remove 3 from temporary list ---
//---Remove 1 from temporary list ---
//---Remove 3 from temporary list ---
//---Remove 1 from temporary list ---
//---Remove 1 from temporary list ---
//---Remove 3 from temporary list ---
//---Remove 2 from temporary list ---
//---Remove 2 from temporary list ---
//---Remove 1 from temporary list ---
//---Remove 1 from temporary list ---
//---Remove 2 from temporary list ---
//---Remove 3 from temporary list ---
