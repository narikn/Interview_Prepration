<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>


 void Main(string[] args)
{
	//create an empty LinkedList
	LinkedList s = new LinkedList();

	s.AddAtStart(1);
	s.AddAtEnd(2);
	s.AddAtEnd(2);
	s.AddAtEnd(3);
	s.AddAtEnd(3);
	s.AddAtEnd(4);
	s.DeleteDuplicates();
	s.PrintRecursively();

}


class Node
{
	public int Data;
	public Node Next;
	public Node(int _data)
	{
		this.Data = _data;
	}
	public Node()
	{

	}
};

class LinkedList
{
	public Node head;
	//constructor to create an empty LinkedList
	public LinkedList()
	{
		head = null;
	}

	//display the content of the list
	public void PrintList()
	{
		Node temp = new Node();
		temp = this.head;
		if (temp != null)
		{
			Console.Write("The list contains: ");
			while (temp != null)
			{
				Console.Write(temp.Data + " ");
				temp = temp.Next;
			}
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("The list is empty.");
		}
	}

	public void AddAtFront(Node n)
	{
		if (n != null)
		{
			Node o = this.head;
			this.head = n;
			n.Next = o;
		}
	}

	public void AddAtStart(int x)
	{
		if (this.head != null)
		{
			Node n = new Node(x);
			Node t = this.head;
			n.Next = t;
			this.head = n;
		}
		else
		{
			this.head = new Node(x);
		}

	}

	public void AddAtEnd(int x)
	{
		if (this.head == null) return;

		Node p = this.head;
		while (p.Next != null)
		{
			p = p.Next;

		}

		p.Next = new Node(x);
	}

	public void AddAtEnd(Node n)
	{
		Node temp = this.head;
		while (temp.Next != null)
		{
			temp = temp.Next;
		}
		temp.Next = n;
	}

	public void DeleteNode(int data)
	{
		Node t = this.head;
		Node prev = t;
		while (t.Data != data)
		{
			prev = t;
			t = t.Next;
		}

		prev.Next = t.Next;
	}

	public void Reverse()
	{
		// a--> b--> c
		Node p = null;
		Node c = this.head;
		Node n = null;
		while (c != null)
		{
			n = c.Next; // copy the 2nd nodes address to temporary variable n ( known as next)
			c.Next = p; // make current node point to previous node ( 1st time it points to null)

			// by  above two steps we are breaking link between a and b ( first two nodes)   and then reverse the link direction by swaping address

			// swap address 
			p = c;
			c = n;
		}
		head = p; //by the end of linked list p will point the last node i.e c then make this last node (c) has head
	}

	public void MiddleNode()
	{
		Node s = this.head;
		Node f = this.head;

		while (f != null && f.Next != null)
		{
			s = s.Next;
			f = f.Next.Next;
		}
		$"Middle node is: {s.Data}".Dump();
	}

	public Node HasCycle()
	{
		Node s = this.head;
		Node f = this.head;
		Node h = null;
		while (f != null && f.Next != null)
		{
			s = s.Next;
			f = f.Next.Next;
			if (s == f)
			{
				h = PrintStartingNode(s);

				break;
			}
		}
		return h;
	}

	public Node PrintStartingNode(Node slowPointer)
	{
		Node t = this.head;

		while (slowPointer != t)
		{
			t = t.Next;
			slowPointer = slowPointer.Next;
		}

		$"Cycle starts at node {t.Data}".Dump();
		return slowPointer;
	}

	public void RemoveLoop(Node slowPointer)
	{

		slowPointer.Next = null; ;
	}

	public void DeleteDuplicates()
	{
		Node p = this.head;
		Node q = this.head.Next;


		while (q.Next != null)
		{
			if (p.Data == q.Data)
			{
				p.Next = q.Next;
				q = p.Next;

			}
			else
			{
				p = q;
				q = q.Next;

			}

		}
	}

	public void PrintRecursively()
	{
		"".PrintNewLine();
		DisplayRecursively(this.head);
	}

	private void DisplayRecursively(Node n)
	{
		Node p = n;
		if (p != null)
		{
			$"{p.Data}-->".PrintInLine();
			DisplayRecursively(p.Next);


		}
	}



};