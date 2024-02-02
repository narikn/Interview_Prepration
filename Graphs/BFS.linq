<Query Kind="Program" />

class Graph
{
	private int vertices;
	private List<int>[] adjacencyList;

	public Graph(int v)
	{
		vertices = v;
		adjacencyList = new List<int>[v];
		for (int i = 0; i < v; ++i)
		{
			adjacencyList[i] = new List<int>();
		}
	}

	public void AddEdge(int v, int w)
	{
		// Add an edge between vertices v and w
		adjacencyList[v].Add(w);
	}

	public void DFS(int startingVertex)
	{
		// Array to keep track of visited vertices
		bool[] visited = new bool[vertices];

		// Call the recursive DFS function starting from the given vertex
		DFSRecursive(startingVertex, visited);
	}

	private void DFSRecursive(int vertex, bool[] visited)
	{
		// Mark the current vertex as visited and print it
		visited[vertex] = true;
		Console.Write(vertex + " ");

		// Recur for all the vertices adjacent to this vertex
		foreach (int neighbor in adjacencyList[vertex])
		{
			if (!visited[neighbor])
			{
				DFSRecursive(neighbor, visited);
			}
		}
	}
}

class Program
{
	static void Main()
	{
		// Create a graph with 6 vertices
		Graph graph = new Graph(6);

		// Adding edges to the graph
		graph.AddEdge(0, 1);
		graph.AddEdge(0, 2);
		graph.AddEdge(1, 3);
		graph.AddEdge(2, 4);
		graph.AddEdge(2, 5);

		Console.WriteLine("DFS starting from vertex 0:");
		graph.DFS(0);
	}
}
