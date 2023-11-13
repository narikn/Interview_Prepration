<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	SL s = new SL();
	s.AddAtStart(1);
	s.AddAtStart(2);
	s.AddAtEnd(3);

	s.PrintRecursively();
	s.GetCountRecursive().Dump();

}


public class Node
{
	public Node()
	{

	}
	public Node(int n)
	{
		this.data = n;
	}
	public int data;
	public Node Next;
}


public class SL
{
	public Node head;
	public int Count;

	public void AddAtStart(int d)
	{
		Node n = new Node(d);
		if (this.head == null)
		{
			this.head = n;
		}
		else
		{
			var t = this.head;
			this.head = n;
			n.Next = t;
		}
	}

	public void PrintSL()
	{
		Node p = this.head;
		while (p != null)
		{
			p.data.Dump();
			p = p.Next;
		}
	}

	public void AddAtEnd(int x)
	{
		Node n = new Node(x);
		var p = this.head;
		if (p == null)
		{
			p = n;
		}
		else
		{
			while (p.Next != null)
			{
				p = p.Next;
			}

			p.Next = n;
		}
	}

	public void DeleteAtStart()
	{

		var t = this.head.Next;
		this.head = t;
	}

	public void DeletData(int n)
	{
		Node p = this.head;
		while (p != null && p.data == n)
		{

			p = p.Next;
		}

	}

	public void GetCount()
	{
		int c = 0;
		Node p = this.head;

		while (p != null)
		{
			c++;
			p = p.Next;
		}

		Count = c;
		$"--Count is--- {Count}".Dump();
	}


	public void PrintRecursively()
	{
		DisplayRecursively(this.head);

	}
	private void DisplayRecursively(Node n)
	{
		Node p = n;
		if (p != null)
		{
			$"{p.data}-->".PrintInLine();
			DisplayRecursively(p.Next);

			//$"{p.data}-->".PrintInLine();
			//DisplayRecursively(p.Next);
		}
	}


	public int GetCountRecursive()
	{
		return Kount(this.head);
	}
	public int Kount(Node n)
	{
		Node p = n;
		if (p == null) return 0;
		return Kount(p.Next) + 1;

	}
}
