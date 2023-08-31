using System.Text;

internal static class Program
{
	public static void Main(string[] args)
	{
		const string parentheses = "(]";

		var res = ValidateParentheses(parentheses);

		Console.WriteLine(res);
	}

	private static bool ValidateParentheses(string s)
	{
		var bracketsMap = new Dictionary<char, char>
		{
			{ '{', '}' },
			{ '(', ')' },
			{ '[', ']' }
		};

		var openBrackets = new Stack<char>();

		foreach (var bracket in s)
		{
			if (bracketsMap.ContainsKey(bracket))
				openBrackets.Push(bracket);
			else
			{
				if (openBrackets.Count == 0) return false;
				if (bracketsMap[openBrackets.Pop()] == bracket)
					continue;

				return false;
			}
		}

		return openBrackets.Count == 0;
	}
}