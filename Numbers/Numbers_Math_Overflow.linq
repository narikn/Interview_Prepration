<Query Kind="Program" />

void Main()
{
	Reverse(123).Dump();
}

public int Reverse(int n)
{
	int rv = 0; // This will hold the reversed number
	int x = n;

	// Precomputed for efficiency
	int inMax = int.MaxValue / 10;
	int inMin = int.MinValue / 10;

	while (x != 0)
	{
		int d = x % 10; // Get the last digit
		x = x / 10;     // Remove the last digit

		// Check for overflow and underflow before adding the digit
		if ((rv > inMax) || (rv == inMax && d > 7)) return 0; // Overflow check
		if ((rv < inMin) || (rv == inMin && d < -8)) return 0; // Underflow check

		rv = rv * 10 + d; // Add the digit to the reversed number
	}

	return rv;
}


