<Query Kind="Program" />


void Main()
{
	int n = 4;
	int k = 9; // We want the 9th permutation
	string result = GetPermutation(n, k);
	Console.WriteLine(result); // Output: 2314
}

//  get the k-th permutation
string GetPermutation(int n, int k)
{
	List<int> numbers = InitializeNumbers(n); // Create list [1, 2, ..., n]

	int[] factorial = CalculateFactorials(n); // Precompute factorial values


	k--; // Convert to zero-based index
	StringBuilder answer = new StringBuilder(); // To build result

	for (int i = n; i >= 1; i--)
	{
		int blockIndex = FindBlock(k, factorial[i - 1]); // Find which block (which number to pick)
		
		answer.Append(numbers[blockIndex]);                  // Add number to result
		numbers.RemoveAt(blockIndex);                     // Remove used number
		k = StepsRemaining(k, factorial[i - 1]);          // Steps remaining inside current block
	}

	return answer.ToString();
}

// Create a list of numbers from 1 to n
List<int> InitializeNumbers(int n)
{
	List<int> numbers = new List<int>();
	for (int i = 1; i <= n; i++)
		numbers.Add(i);
	return numbers;
}

// Precompute factorial values
int[] CalculateFactorials(int n)
{
	int[] factorial = new int[n + 1];
	factorial[0] = 1;
	for (int i = 1; i <= n; i++)
	{
		factorial[i] = factorial[i - 1] * i;
	}
	
	return factorial;
}

// Find which block (which number) to pick based on k and block size
int FindBlock(int k, int blockSize)
{
	return k / blockSize;
}

// Find steps remaining inside the selected block
int StepsRemaining(int k, int blockSize)
{
	return k % blockSize;
}

