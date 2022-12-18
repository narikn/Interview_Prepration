<Query Kind="Program" />

void Main()
{
	var ls = new List<int>() { 1, 2, 3 };
	permute(ls).PrintListOfList();
}

public List<List<int>> permute(List<int> A)
{

	List<List<int>> result = new List<List<int>>();

	List<int> ip = new List<int>(A);
	List<int> op = new List<int>();

	Permute(ip, op, result);

	return new List<List<int>>(result);
}

private void Permute(List<int> input, List<int> output, List<List<int>> resultCollection)
{
	if (input.Count == 0)
	{
		resultCollection.Add(output);
		return;
	}

	for (int i = 0; i < input.Count; i++)
	{
		int temp = input[0]; // Extract 1st character  i.e 1 is extracted and store in temp for future use
		output.Add(temp); //  Add extracted 1st character to output collection
		input.RemoveAt(0); // Now remove 1 from input collection so that collection will have 2 ,3 which becames new input

		List<int> new_Input = new List<int>(input); // Now input has 2,3
		List<int> new_Ouput = new List<int>(output); // Now output has 1 

		Permute(new_Input, new_Ouput, resultCollection);

		output.RemoveAt(output.Count - 1);
		input.Add(temp);
	}
}

