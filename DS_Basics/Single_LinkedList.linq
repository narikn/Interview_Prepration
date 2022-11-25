<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

class Implementation
{
	static void Main(string[] args)
	{
		//create an empty LinkedList
		LinkedList list = new LinkedList();

		//Add first node.
		Node first = new Node();
		first.data = 10;
		first.next = null;
		//linking with head node
		list.head = first;

		//Add second node.
		Node second = new Node();
		second.data = 20;
		second.next = null;
		//linking with first node
		first.next = second;

		//Add third node.
		Node third = new Node();
		third.data = 30;
		third.next = null;
		//linking with second node
		second.next = third;

		//print the content of list
		//list.PrintList();
		list.AddAtEnd(new Node() { data = 40 });
		list.AddAtEnd(new Node() { data = 50 });

		Node sixty = new Node() { data = 60 };
		list.AddAtEnd(sixty);

		// creating loop 	
		{
			//sixty.next = first;
			sixty.next = third;
		}


		//list.DeleteNode(30);
		//list.PrintList();
		//list.Reverse();
		//list.PrintList();
		//list.MiddleNode();
	 Node s=	list.HasCycle();
		list.RemoveLoop(s);
		list.PrintList();

	}
}



class Node
{
	public int data;
	public Node next;
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
				Console.Write(temp.data + " ");
				temp = temp.next;
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
			n.next = o;
		}
	}

	public void AddAtEnd(Node n)
	{
		Node temp = this.head;
		while (temp.next != null)
		{
			temp = temp.next;
		}
		temp.next = n;
	}

	public void DeleteNode(int data)
	{
		Node t = this.head;
		Node prev = t;
		while (t.data != data)
		{
			prev = t;
			t = t.next;
		}

		prev.next = t.next;
	}

	public void Reverse()
	{
		// a--> b--> c
		Node p = null;
		Node c = this.head;
		Node n = null;
		while (c != null)
		{
			n = c.next; // copy the 2nd nodes address to temporary variable n ( known as next)
			c.next = p; // make current node point to previous node ( 1st time it points to null)

			// by this we are breaking link between a and b ( first two nodes)   and then reverse the link direction by swaping address

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

		while (f != null && f.next != null)
		{
			s = s.next;
			f = f.next.next;
		}
		$"Middle node is: {s.data}".Dump();
	}

	public Node HasCycle()
	{
		Node s = this.head;
		Node f = this.head;
		Node h = null;
		while (f != null && f.next != null)
		{
			s = s.next;
			f = f.next.next;
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
			t = t.next;
			slowPointer = slowPointer.next;
		}

		$"Cycle starts at node {t.data}".Dump();
		return slowPointer;
	}

	public void RemoveLoop(Node slowPointer)
	{
	
		slowPointer.next=null;;
	}
};