namespace KaratsubaMultiplication;

public class Karatsuba
{
	private string Multiply(string first, string second)
	{
		if (first.Length == 1 || second.Length == 1)
			return (int.Parse(first) * int.Parse(second)).ToString();
		
		
	}
}