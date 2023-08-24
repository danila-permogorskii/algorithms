static class Program
{
	public static void Main(string[] args)
	{
		var str = "pwwkew";

		var res = OtherSolution(str);

		Console.WriteLine(res);
	}

	static int MySolution()
	{
		var str = "pwwkew";
		var hs = new HashSet<char>();

		for (int i = 0; i < str.Length; i++)
		{
			if (!hs.Contains(str[i]))
				hs.Add(str[i]);
		}

		return hs.Count;
	}

	static int OtherSolution(string s)
	{
		var charSet = new HashSet<char>();
		int left = 0, right = 0, maxLength = 0;
		while(right < s.Length)
		{
			if (!charSet.Contains(s[right]))
			{
				charSet.Add(s[right]);
				right++;
				maxLength = Math.Max(maxLength, charSet.Count);
			}
			else
			{
				charSet.Remove(s[left]);
				left++;
			}
		}
		return maxLength;
	}

}