using BreadFirstSerach;

internal static class Program
{
	private static void RecursiveBFS(Graph graph, Queue<int> q, IList<bool> discovered)
	{
		if (q.Count == 0) return;

		var v = q.Dequeue();
		Console.WriteLine(v + " ");

		foreach (var u in graph.adjList[v])
			if (!discovered[u])
			{
				discovered[u] = true;
				q.Enqueue(u);
			}
		
		RecursiveBFS(graph, q, discovered);
	}
	
	private static void BFS(Graph graph, int v, IList<bool> discovered)
	{
		var q = new Queue<int>();

		discovered[v] = true;
		
		q.Enqueue(v);

		while (q.Count != 0)
		{
			v = q.Dequeue();
			Console.WriteLine(v + " ");

			if (graph.adjList == null) continue;
			
			foreach (var u in graph.adjList[v])
			{
				if (!discovered[u])
				{
					discovered[u] = true;
					q.Enqueue(u);
				}
			}
		}
	}
	
	public static void Main(string[] args)
	{
		var edges = new List<Edge>
		{
			new Edge(1,2),
			new Edge(1,3),
			new Edge(1,4),
			new Edge(2,5),
			new Edge(2,6),
			new Edge(5,9),
			new Edge(5,10),
			new Edge(4,7),
			new Edge(4,8),
			new Edge(7,11),
			new Edge(7,12)
		};

		var n = 15;

		var graph = new Graph(edges, n);

		var discovered = new bool[n];

		
		// for (int i = 0; i < n; i++)
		// {
		// 	if (discovered[i] == false)
		// 		BFS(graph, i, discovered);
		// }
		
		
		var q = new Queue<int>();

		for (int i = 0; i < n; i++)
		{
			if (discovered[i] == false)
			{
				discovered[i] = true;

				q.Enqueue(i);
				
				RecursiveBFS(graph, q, discovered);
			}
		}
	}
}