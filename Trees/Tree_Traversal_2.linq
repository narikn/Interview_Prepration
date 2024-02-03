<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Tree bst = new Tree();
	int[] arr = { 1, 7, 3, 4, 5, 6, -2 };

	foreach (int val in arr)
	{
		bst.Insert(val);
	}
	bst.PreOrder_R(bst.root);
	"".Dump();
	bst.PreOrder_I(bst.root);
}

public class Tree
{
	public TreeNode root;

	public void PreOrder_R(TreeNode root)
	{

		if (root != null)
		{
			root.Data.PrintInLine();
			PreOrder_R(root.Left);
			PreOrder_R(root.Right);
		}
	}


	public void PreOrder_I(TreeNode root)
	{
		if (root == null) return;

		Stack<TreeNode> st = new Stack<TreeNode>();
		st.Push(root);

		while (st.Count > 0)
		{
			TreeNode node = st.Pop();
			node.Data.PrintInLine();

			if (node.Right != null) st.Push(node.Right); // Last one should be printed first (becof D L (left first) R)
			if (node.Left != null) st.Push(node.Left);
		}

	}



	public void Insert(int value)
	{
		if (root == null)
		{
			root = new TreeNode(value);
		}
		else
		{
			InsertRecursively(root, value);
		}
	}

	private void InsertRecursively(TreeNode node, int value)
	{
		if (value < node.Data)
		{
			if (node.Left == null)
			{
				node.Left = new TreeNode(value);
			}
			else
			{
				InsertRecursively(node.Left, value);
			}
		}
		else if (value > node.Data)
		{
			if (node.Right == null)
			{
				node.Right = new TreeNode(value);
			}
			else
			{
				InsertRecursively(node.Right, value);
			}
		}
		// Assuming that duplicate values are not inserted in this BST implementation
	}

	// Additional methods like PreOrder can be added here for tree traversal
}



public class TreeNode
{
	public TreeNode Left;
	public TreeNode Right;
	public int Data;

	public TreeNode(int data)
	{
		this.Data = data;
	}
}
