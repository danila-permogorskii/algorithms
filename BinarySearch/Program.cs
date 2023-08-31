internal static class Program
{
	private static int IterativeBinarySearch(int[] nums, int target)
	{
		int left = 0, right = nums.Length - 1;

		while (left <= right)
		{
			var middle = (left + right) / 2;
			
			// to avoid overflow
			// var middle = left + (right - left) / 2;
			// var middle = right - (right - left) / 2;

			if (target == nums[middle])
				return middle;

			if (target < nums[middle])
				right = middle - 1;

			else 
				left = middle + 1;
			
			
		}

		return -1;
	}

	private static int RecursiveBinarySearch(int[] nums, int left, int right, int target)
	{
		if (left > right)
			return -1;

		var mid = (left + right) / 2;
		
		// to avoid overflow
		// var mid = left + (right - left) / 2;

		if (target == nums[mid])
			return mid;

		return target < nums[mid] 
			? RecursiveBinarySearch(nums, left, mid - 1, target)
			: RecursiveBinarySearch(nums, mid + 1, right, target);
	}
	
	public static void Main()
	{
		var nums = new int[] { 2, 5, 6, 8, 9, 10 };
		var target = 5;

		var left = 0;
		var right = nums.Length - 1;

		// var index = IterativeBinarySearch(nums, target);
		var index = RecursiveBinarySearch(nums, left, right, target);

		Console.WriteLine($"Index: {index}, value: {nums[index]}");
	}
}