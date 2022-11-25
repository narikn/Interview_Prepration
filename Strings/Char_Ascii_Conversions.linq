<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

	char[] a = { 'A', 'B', 'C' };

     int x=(int)'A'; // Gets Ascii value of A
    
	 Char y=(Char)x; // Gets Ascii value x which is integer

	  

	foreach (Char c in a)
	{
		int v = ((int)c) + 32;
		Char k=(Char)v;
		k.Dump();
	}
}
// Define other methods and classes here
