<Query Kind="Program" />

class Program
{
	static void Main()
	{
		int n = 4; // Total numbers from 1 to n
		int k = 9; // We want the 9th permutation
		string result = GetPermutation(n, k);
		Console.WriteLine(result); // Output should be "2314"
	}

	// Main method to get the k-th permutation
	static string GetPermutation(int n, int k)
	{
		List<int> numbers = InitializeNumbers(n); // Create list [1, 2, ..., n]
		
		int[] factorial = CalculateFactorials(n); // Precompute factorial values

		k--; // Decrease k by 1 to convert to zero-based index
		StringBuilder sb = new StringBuilder(); // To build the result string

		// Loop through n positions
		for (int i = n; i >= 1; i--)
		{
			int index = GetIndex(k, factorial[i - 1]); // Find the index of the next number
			sb.Append(numbers[index]);                 // Add that number to result
			numbers.RemoveAt(index);                   // Remove the used number from the list
			k = GetNewK(k, factorial[i - 1]);           // Update k for next iteration
		}

		return sb.ToString();
	}

	// Initialize the list of numbers from 1 to n
	static List<int> InitializeNumbers(int n)
	{
		List<int> numbers = new List<int>();
		for (int i = 1; i <= n; i++)
			numbers.Add(i);
		return numbers;
	}

	// Precompute factorials up to n
	static int[] CalculateFactorials(int n)
	{
		int[] factorial = new int[n + 1];
		factorial[0] = 1; // 0! is 1
		for (int i = 1; i <= n; i++)
			factorial[i] = factorial[i - 1] * i; // n! = (n-1)! * n
		return factorial;
	}

	// Find which index number should be placed next
	static int GetIndex(int k, int factorial)
	{
		return k / factorial;
	}

	// Update k for the next position
	static int GetNewK(int k, int factorial)
	{
		return k % factorial;
	}
}
