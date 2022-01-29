namespace TurboCollections;

//implemented with some pseudocode help from: https://www.geeksforgeeks.org/quick-sort/
public static class TurboQuickSorting
{
	public static void TurboQuickSort(TurboList<int> list, int left, int right)
	{
		if (left < right)
		{
			var pi = Partition(list, left, right);
			TurboQuickSort(list, left, pi - 1);
			TurboQuickSort(list, pi + 1, right);
		}
	}

	private static int Partition(TurboList<int> list, int left, int right)
	{
		
		var pivot = list.Get(right);
		var i = left - 1;

		for (var j = left; j <= right; j++)
		{
			if (list.Get(j) < pivot)
			{
				i++;
				SwapPositions(list, i, j);
			}
		}

		SwapPositions(list, i + 1, right);

		return i + 1;
	}

	private static void SwapPositions(TurboList<int> list, int firstIndex, int secondIndex)
	{
		var temp = list.Get(firstIndex);
		list.Set(firstIndex, list.Get(secondIndex));
		list.Set(secondIndex, temp);
		// Console.WriteLine($"Swaped: {temp} with {list.Get(firstIndex)}");
	}
}
