namespace MergeSort;

internal static class Program
{
	private static void Merge(IList<int> arr, IList<int> aux, int low, int mid, int high)
	{
		int k = low, i = low, j = mid + 1;

		while (i <= mid && j <= high)
		{
			if (arr[i] <= arr[j])
				aux[k++] = arr[i++];
			else
				aux[k++] = arr[j++];
		}

		while (i <= mid)
			aux[k++] = arr[i++];

		for (i = low; i <= high; i++)
			arr[i] = aux[i];
	}

	private static void MergeSort(IList<int> arr, IList<int> aux, int low, int high)
	{
		if (high <= low)
			return;

		var mid = low + ((high - low) >> 1);
		
		MergeSort(arr, aux, low, mid);
		MergeSort(arr, aux, mid + 1, high);
		
		Merge(arr, aux, low, mid, high);
	}

	private static bool IsSorted(IReadOnlyList<int> arr)
	{
		var prev = arr[0];

		for (int i = 1; i < arr.Count; i++)
		{
			if (prev > arr[i])
			{
				Console.WriteLine("MergeSort failed.");
				return false;
			}

			prev = arr[i];
		}

		return true;
	}
	
	public static void Main()
	{
		var arr = new[] { 12, 3, 18, 24, 0, 5, -2 };
		var aux = new int[arr.Length];
		
		Array.Copy(arr, aux, arr.Length);
		
		MergeSort(arr, aux, 0, arr.Length - 1);

		if (IsSorted(arr))
			Console.WriteLine(string.Join (", ", arr));
	}
}