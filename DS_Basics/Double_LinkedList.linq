<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{

	DoubleLinkedList list = new DoubleLinkedList();

	DNode d1 = new DNode(1);
	list.head = d1;

	DNode d2 = new DNode(2);
	d1.Next = d2;
	d2.Prev = d1;


	DNode d3 = new DNode(3);
	d2.Next = d3;
	d3.Prev = d2;


	DNode d4 = new DNode(4);
	d4.Next = null;
	d4.Prev = d3;

	list.tail = d4;

	DNode d0 = new DNode(0);
	list.AddAtStart(d0);

	list.PrintAll_FromStart();
	list.PrintAll_FromEnd();
}


public class DNode
{
	public DNode Next = null;
	public DNode Prev = null;
	public int Data;

	public DNode(int x)
	{
		this.Data = x;

	}
}

public class DoubleLinkedList
{
	public DNode head;
	public DNode tail;

	public DoubleLinkedList()
	{
		this.head = null;
	}

	public void PrintAll_FromStart()
	{
		DNode t = this.head;
		while (t != null)
		{
			t.Data.Dump();
			t = t.Next;
		}
	}

	public void PrintAll_FromEnd()
	{
		DNode t = this.tail;
		while (t != null)
		{
			t.Data.Dump();
			t = t.Prev;
		}
	}
	public void AddAtStart(DNode _n)
	{
		DNode t = this.head;
		this.head = _n;
		_n.Next = t;

	}
}
