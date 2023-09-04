internal static class Program
{
	private static void Swap(int[] arr, int i, int j)
	{
		(arr[i], arr[j]) = (arr[j], arr[i]);
	}

	private static int Partition(int[] a, int start, int end)
	{
		var pivot = a[end];

		var pIndex = start;

		for (int i = start; i < end; i++)
		{
			if (a[i] <= pivot)
			{
				Swap(a, i, pIndex);
				pIndex++;
			}
		}
		
		Swap(a, end, pIndex);

		return pIndex;
	}

	private static void QuickSort(int[] a, int start, int end)
	{
		while (true)
		{
			if (start >= end) return;

			var pivot = Partition(a, start, end);

			QuickSort(a, start, pivot - 1);
			start = pivot + 1;
		}
	}

	public static void Main()
	{
		var a = new int[] { 9, -3, 5, 2, 6, 8, -6, 1, 3 };
		
		QuickSort(a, 0, a.Length - 1);

		Console.WriteLine(a.ToString());
	}
}