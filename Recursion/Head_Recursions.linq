<Query Kind="Program" />

void Main()
{
;
}

//Head Recursion: 
public void Print_HeadRecursion(int n)
{
	if (n == 0) return;

	Print_HeadRecursion(n - 1); // After func call there are computing statments to compute.while un-piling recpords it returns a value
	n.Dump();
	// All computation happens while recursiona activation records are created i.e while piling
}


public int Fact(int n)
{

  if(n==0) return 1;
  
   return n*Fact(n-1);
}

public int SumDigits(int n)
{

	if (n == 0) return 0;
	if (n < 10) return n;

	int lastDigit = n % 10;
	int remainingDigits = n / 10;

	int retVal = SumDigits(remainingDigits);
	return lastDigit + retVal;
}