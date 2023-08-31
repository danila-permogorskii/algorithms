using System.Runtime.CompilerServices;

namespace DepthFirstSearch;

public class Graph
{
	public IList<IList<int>>? adjList;
	
	public Graph(IList<Edge> edges, int n)
	{
		adjList = new List<IList<int>>();

		for (int i = 0; i < n; i++)
			adjList.Add(new List<int>());

		foreach (var edge in edges)
		{
			var src = edge.Source;
			var dest = edge.Destination;
			
			adjList[src].Add(dest);
			adjList[dest].Add(src);
		}
	}
}