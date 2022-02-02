namespace TurboCollections;

public static class TurboSorting
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

	public static void TurboQuickSort(TurboList<int> list, int left, int right)
	{
		if (left < right)
		{
			//Sets pivot to Correct position before passing in the sub-arrays
			var pivot = Partition(list, left, right);
			//pass in left sub array (0 to pivot -1)
			TurboQuickSort(list, left, pivot - 1);
			//Pass ion right array 
			TurboQuickSort(list, pivot + 1, right);
		}
	}

	private static int Partition(TurboList<int> list, int left, int right)
	{
		//pivot is set to the farthest right element
		var pivot = list.Get(right);
		//i used to put new values into the left end (so it increased when swapping)
		var i = left - 1;
		// start looping from left
		for (var j = left; j <= right-1; j++)
		{
			//If value from is lesser than pivot value
			if (list.Get(j) < pivot)
			{
				//increase i when swapping
				i++;
				//Swap the initial pointed number (i) with the lesser number contained in j
				SwapPositions(list, i, j);
			}
		}
		// swaps the pivot to its correct position.
		SwapPositions(list, i + 1, right);
		//return pivot index
		return i + 1;
	}

	public static void SwapPositions(TurboList<int> list, int firstIndex, int secondIndex)
	{
		var temp = list.Get(firstIndex);
		list.Set(firstIndex, list.Get(secondIndex));
		list.Set(secondIndex, temp);
	}
}
