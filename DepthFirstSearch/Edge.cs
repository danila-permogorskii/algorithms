namespace DepthFirstSearch;

public class Edge
{
	public int Source { get; set; }
	public int Destination { get; set; }

	public Edge(int source, int destination)
	{
		Source = source;
		Destination = destination;
	}
}