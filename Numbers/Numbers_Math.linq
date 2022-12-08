<Query Kind="Program" />

void Main()
{

	BinaryToDecimal();

}


public void ReverseNumber()
{
	int number = 1234;
	int reminder, result = 0;
	while (number > 0)
	{
		//Get the remainder by dividing the number with 10  
		reminder = number % 10;
		//multiply the result with 10 and then add the reminder
		result = (result * 10) + reminder;
		//Get the quotient by dividing the number with 10 
		number = number / 10;
	}
}

public void Fibo()
{
	int numberOfElements = 5;
	int firstNumber = 0, SecondNumber = 1, nextNumber;
	for (int i = 2; i < numberOfElements; i++)
	{
		nextNumber = firstNumber + SecondNumber;
		Console.Write(nextNumber + " ");
		firstNumber = SecondNumber;
		SecondNumber = nextNumber;
	}
}

public void Armstrong_Number()
{
	int number = 371;
	double result = 0;

	int temp = number;
	while (temp > 0)
	{
		int r = temp % 10;

		result = result + Math.Pow((double)r, (double)3);
		temp = temp / 10;
	}
	if (result == number) "Yes".Dump();

}

public void SumOfDigits()
{
	int n = 1234;

	int sum = 0;
	while (n > 0)
	{
		int r = n % 10;
		sum = sum + r;
		n = n / 10;
	}
}

public void DecimalToBinary()
{
	int n = 3;
	int[] a = new int[10];

	int i = 0;
	while (n > 0)
	{
		int r = n % 2;
		a[i] = r;
		i++;
		n = n / 2;
	}
	a.PrintArray();
}

public void BinaryToDecimal()
{
	int binaryNumber = 101;
	double result = 0D; // D is explicit conver to double from int
	int i = 0;
	while (binaryNumber > 0)
	{
		int leftDigit = binaryNumber % 10;
		result = result + leftDigit * Math.Pow(2, i);
		i++;
		binaryNumber = binaryNumber / 10;
	}

	result.Dump();
}