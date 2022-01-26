namespace TurboCollections;

public static class TurboSort
{
	public static void TurboSelectionSort(TurboList<int> list)
	{
		 
		
	}

	private static int IndexOfMin(TurboList<int> list, int startIndex)
	{
		var minIndex = startIndex;



		return minIndex;



	}

	public static void SwapPositions(TurboList<int> list, int firstIndex, int secondIndex)
	{
		var temp = list.Get(firstIndex);
		list.Set(firstIndex, list.Get(secondIndex)) ;
		list.Set(secondIndex, temp);
	}
}
