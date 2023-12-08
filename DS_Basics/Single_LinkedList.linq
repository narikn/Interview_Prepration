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
		first.Data = 10;
		first.Next = null;
		//linking with head node
		list.head = first;

		//Add second node.
		Node second = new Node();
		second.Data = 20;
		second.Next = null;
		//linking with first node
		first.Next = second;

		//Add third node.
		Node third = new Node();
		third.Data = 30;
		third.Next = null;
		//linking with second node
		second.Next = third;

		//print the content of list
		//list.PrintList();
		list.AddAtEnd(new Node() { Data = 40 });
		list.AddAtEnd(new Node() { Data = 50 });

		Node sixty = new Node() { Data = 60 };
		list.AddAtEnd(sixty);

		// creating loop 	
		{
			//sixty.next = first;
			sixty.Next = third;
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
	public int Data;
	public Node Next;
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



	public Node ReverseRecursive(Node head)
	{
		
		// https://www.youtube.com/watch?v=pbVqruZDWrw  
		// Base case: if head is null or only one node, it's already reversed.
		if (head == null || head.Next == null)
		{
			return head;
		}

		// Recursive call to reverse the rest of the list.
		Node p = ReverseRecursive(head.Next);

		// Set the next node's next pointer to the current head.
		int tt = head.Data;

		head.Next.Next = head;

		// Set the current head's next pointer to null.
		head.Next = null;

		// The new head of the reversed list.
		return p;
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
	
		slowPointer.Next=null;;
	}
};