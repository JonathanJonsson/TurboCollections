using System.Security.AccessControl;
using System.Xml.Xsl;

namespace TurboCollections;

public static class TurboQuickSorting
{
	public static void TurboQuickSort(TurboList<int> list, int left, int right)
	{
		
		 
		 
		
	}

	public static int Partition(TurboList<int> list, int left, int right)
	{

		

	}
	
	public static void SwapPositions(TurboList<int> list, int firstIndex, int secondIndex)
	{
		var temp = list.Get(firstIndex);
		list.Set(firstIndex, list.Get(secondIndex)) ;
		list.Set(secondIndex, temp);
		// Console.WriteLine($"Swaped: {temp} with {list.Get(firstIndex)}");
	}
}
