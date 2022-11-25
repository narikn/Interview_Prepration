<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Function(2, 4, 0);
}


int Function(int l, int r, int level)
{
	//string.Format("------l ={0}  r= {1}",l,r).Dump();

	for (int i = 0; i < level; i++)
	{
		" ".Dump();
		
		string.Format("({0} ,{1} )", l, r).Dump();
	}

	if (l > r)
	{
		return 0;
	}
	if (l == r)
	{
		"-------------".Dump();
		return 1;
	}
	"*** For ***".Dump();
	return Function(l + 1, r, level + 1) + Function(l, r - 1, level + 1);

}
