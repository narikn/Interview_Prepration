<Query Kind="Program" />

void Main()
{

	TreeNode root = new TreeNode(1);

	root.Left = new TreeNode(2);
	root.Right = new TreeNode(3);

	root.Left.Left = new TreeNode(4);
	root.Left.Right = new TreeNode(5);

	root.Right.Left = new TreeNode(6);

	root.Right.Right = new TreeNode(7);

	InOrder(root);

}

public void PreOrder(TreeNode root)
{
	if (root != null)
	{
		Console.Write(root.Data);
		PreOrder(root.Left);
		PreOrder(root.Right);

	}
}


public void PreOrder_Iterative(TreeNode _root)
{

	if (_root != null)
	{
		Stack<TreeNode> st = new Stack<TreeNode>();
		st.Push(_root);

		while (st.Count() > 0)
		{
			TreeNode node = st.Pop();
			node.Data.PrintInLine();


			if (node.Right != null) st.Push(node.Right);
			if (node.Left != null) st.Push(node.Left);

		}
	}
}


public void InOrder(TreeNode root)
{
	if (root != null)
	{
		InOrder(root.Left);
		Console.Write(root.Data);
		InOrder(root.Right);

	}
}

public void InOrder_Iterative(TreeNode _root)
{
	 // LDR
	 
	if (_root == null) return;

	Stack<TreeNode> stack = new Stack<TreeNode>();
	TreeNode current = _root;

	while (current != null || stack.Count > 0)
	{
		// Traverse to the leftmost node
		while (current != null)
		{
			stack.Push(current);
			current = current.Left;
		}

		// Current is null at this point
		current = stack.Pop();
		Console.WriteLine(current.Data);  // Use Console.WriteLine to print the data

		// Now, visit the right subtree
		current = current.Right;
	}
}



public void PostOrder(TreeNode root)
{
	if (root != null)
	{
		PostOrder(root.Left);
		PostOrder(root.Right);
		Console.Write(root.Data);
	}
}


public void PostOrder_Iterative(TreeNode  root)
{
	if (root == null) return;

	Stack<TreeNode> stack1 = new Stack<TreeNode>();
	Stack<TreeNode> stack2 = new Stack<TreeNode>();

	stack1.Push(root);

	while (stack1.Count > 0)
	{
		TreeNode node = stack1.Pop();
		stack2.Push(node);

		if (node.Left != null)
		{
			stack1.Push(node.Left);
		}
		if (node.Right != null)
		{
			stack1.Push(node.Right);
		}
	}

	while (stack2.Count > 0)
	{
		TreeNode node = stack2.Pop();
		Console.WriteLine(node.Data);
	}
}
public class TreeNode
{

	public int Data;
	public TreeNode Left;
	public TreeNode Right;
	public TreeNode()
	{

	}
	public TreeNode(int data)
	{
		this.Data = data;
	}
}