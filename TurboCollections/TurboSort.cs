namespace TurboCollections;

public static class TurboSort
{
	public static void TurboSelectionSort(TurboList<int> list)
	{
		 
		
	}

	public static int IndexOfMin(TurboList<int> list, int startIndex)
	{
		var minIndex = startIndex;
		var minList = list.Get(startIndex);

		for (int i = 0; i < list.Count-1; i++)
		{
			if (list.Get(i) < minList)
			{
				minIndex = i;
				minList = list.Get(i);
			}
		}

		return minIndex;



	}

	public static void SwapPositions(TurboList<int> list, int firstIndex, int secondIndex)
	{
		var temp = list.Get(firstIndex);
		list.Set(firstIndex, list.Get(secondIndex)) ;
		list.Set(secondIndex, temp);
	}
}
