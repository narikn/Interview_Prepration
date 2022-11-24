<Query Kind="Program" />

void Main()
{
	Factorial(5).Dump();

}


// Tail recursion activation records gr

//Tail Recursion: 
public void Print_TailRecursion(int n)
{
	if (n == 0) return;
	n.Dump();
	Print_TailRecursion(n - 1); // After func call there are no statments to compute.while 
								// All computation happens while recursion activation records are created i.e while piling records
}

public int SumOfNaturalNumbers(int n, int runningTotal = 0)
{
	if (n == 0) return runningTotal;

	// Compute here pass the result to next call.Not its not while returning but while making activation records i.e while piling
	int sum = runningTotal + n;
	return SumOfNaturalNumbers(n - 1, sum);
}

public int Factorial(int n, int runningFact = 1)
{
	if (n == 1) return runningFact;
	int fact = n * runningFact;
	return Factorial(n - 1, fact);
}

public int Fib(int n, int a, int b)
{

	if (n == 0) return a;
	if (n == 1) return b;
	int sum = a + b;

	return Fib(n - 1, b, sum);
}




//Head Recursion: 
public void Print_HeadRecursion(int n)
{
	if (n == 0) return;

	Print_HeadRecursion(n - 1); // After func call there are computing statments to compute.while un-piling recpords it returns a value
	n.Dump();
	// All computation happens while recursiona activation records are created i.e while piling
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