<Query Kind="Program" />

void Main()
{
	FindHighestPowerOfTwo_2(3).Dump();
}

long FindHighestPowerOfTwo(long number)
{
	long power = 1;
	var temp = number / 2;
	while (temp >= power)
	{
		power *= 2;
	}
	return power;
}

long FindHighestPowerOfTwoWithShit(long number)
{
	long power = 1;
	while ((power << 1) <= number)  // Same as power*2 <= number // bitwise version is fast cpu
	{
		power <<= 1;
	}
	return power;

}

long FindHighestPowerOfTwo_2(long number)
{
	long power = 1;
	while ((power * 2) <= number)  // Same as power*2 <= number
	{
		power = power *2;
	}
	return power;

}