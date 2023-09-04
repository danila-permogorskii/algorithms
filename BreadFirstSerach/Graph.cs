namespace BreadFirstSerach;

public class Graph
{
	public IList<IList<int>>? adjList = null;

	public Graph(List<Edge> edges, int n)
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