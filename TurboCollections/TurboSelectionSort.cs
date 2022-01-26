namespace TurboCollections;

public static class TurboSort
{
	public static void TurboSelectionSort(TurboList<int> list)
	{
		int minIndex;

		for (int startIndex = 0; startIndex < list.Count; startIndex++)
		{
			minIndex = IndexOfMin(list, startIndex);
			
			if(list.Get(minIndex) == list.Get(startIndex))  
				continue;
			
			SwapPositions(list,minIndex,startIndex);
		}
		

	}

	public static int IndexOfMin(TurboList<int> list, int startIndex)
	{
		var minIndex = startIndex;
		var minList = list.Get(startIndex);

		for (int i = minIndex+1; i < list.Count; i++)
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
		// Console.WriteLine($"Swaped: {temp} with {list.Get(firstIndex)}");
	}
}
