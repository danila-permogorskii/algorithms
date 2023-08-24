static class Program
{
	public static void Main()
	{
		var nums = new int[] { 2, 7, 11, 15 };
		var target = 9;

		var res = TwoSum(nums, target);

		Console.WriteLine($"[{res[0]}, {res[1]}]");
	}

	private static int[] TwoSum(int[] nums, int target)
	{
		var dict = new Dictionary<byte, byte>();

		for (byte i = 0; i < nums.Length; i++)
		{
			var complement = (byte)(target - nums[i]);

			if (dict.TryGetValue(complement, out var value))
				return new[] {(int)value, i};

			dict[(byte)nums[i]] = i;
		}

		return Array.Empty<int>();
	}
}