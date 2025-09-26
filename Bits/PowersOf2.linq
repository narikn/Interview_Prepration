<Query Kind="Program" />

void Main()
{
	GetPowersOfTwo(5).Dump();
}

public static List<long> GetPowersOfTwo(long number)
{
	List<long> powers = new List<long>();

	if (number <= 0)
	{
		return powers;
	}

	long highestPower = FindHighestPowerOfTwo(number);
	DecomposeIntoPowersOfTwo(number, highestPower, powers);

	return powers;
}

private static long FindHighestPowerOfTwo(long number)
{
	long power = 1;
	while (power <= number / 2)
	{
		power *= 2;
	}
	return power;
}

private static void DecomposeIntoPowersOfTwo(long number, long currentPower, List<long> powers)
{
	long remaining = number;

	while (remaining > 0 && currentPower > 0)
	{
		if (currentPower <= remaining)
		{
			powers.Add(currentPower);
			remaining = remaining - currentPower;
		}
		currentPower = currentPower / 2;
	}
}
