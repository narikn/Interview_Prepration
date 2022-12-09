<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Bitwise_Merging(); ;
}

public void LeftShit()
{

	// left shift by 1 means , 2power1 * 5, leftshift 2 means 2Power2* 5 , leftshit 3 means 2power3*5 => Left is Number*2*shiftingTimes
	int x = 5;
	int y = x << 2;

	y.Dump();
}

public void Bitwise_And()
{

	int x = 5;
	int y = x & 2;

	y.Dump();
}

public void Bitwise_OR()
{

	int x = 5;
	int y = x | 2;

	y.Dump();
}


public void Bitwise_Masking()
{
	// checking a bit in memory if it is on and off is Masking
	int a = 5; // 101
	int b = 1;
	a = a & b; // This result gives 0 because 2nd bit is off.
	a.Dump();
}

public void Bitwise_Merging()
{

	// Setting a bit in memory if it is on or off is called Merging

	int a = 5; // 100
	int b = 1;    
	a = a | b;  // it will change 1st bit of a which is zero to 1 and stores result in a.
	Convert.ToString(a, 2).Dump();

	int x = 5; // 101
	int y = 2;
	x = x | y; // it will change 2nd bit of x which is zero to 1 and stores result in a.
	Convert.ToString(x, 2).Dump();
}