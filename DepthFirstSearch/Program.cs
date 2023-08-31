using DepthFirstSearch;

internal static class Program
{
	private static void RecursiveDFS(Graph graph, int v, IList<bool> discovered)
	{
		discovered[v] = true;

		Console.WriteLine(v + " ");

		foreach (var u in graph.adjList[v])
			if (!discovered[u])
				RecursiveDFS(graph, u, discovered);
	}

	private static void DFS(Graph graph, int v, IList<bool> discovered)
	{
		var stack = new Stack<int>();
		
		stack.Push(v);

		while (stack.Count != 0)
		{
			v = stack.Pop();

			if (discovered[v]) 
				continue;

			discovered[v] = true;
			Console.WriteLine(v + " ");

			var adjList = graph.adjList[v];

			for (int i = adjList.Count - 1; i >= 0; i--)
			{
				var u = adjList[i];
				if (!discovered[u])
					stack.Push(u);
			}
		}
	}
	
	public static void Main()
	{
		var edges = new List<Edge>
		{
			new Edge(1, 2),
			new Edge(1, 7),
			new Edge(1, 8),
			new Edge(2, 3),
			new Edge(2, 6),
			new Edge(3, 4),
			new Edge(3, 5),
			new Edge(8, 9),
			new Edge(8, 12),
			new Edge(9, 10),
			new Edge(9, 11)
		};

		var n = 13;
		
		var graph = new Graph(edges, n);

		var discovered = new bool[n];

		for (int i = 0; i < n; i++)
			if (!discovered[i])
				// DFS(graph, i, discovered);
				RecursiveDFS(graph, i, discovered);
	}
}