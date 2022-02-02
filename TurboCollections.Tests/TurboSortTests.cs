using System;
using NUnit.Framework;

namespace TurboCollections.Tests;

public class TurboSortTests
{
	[Test]
	public void SwapTwoElementsWork() // requires Swap() to be public (for now) - is this internal test?
	{
		var list = new TurboList<int>();
		
		list.Add(1);
		list.Add(2);
		
		Assert.AreEqual(1, list.Get(0));
		
		TurboSorting.SwapPositions(list,1,0);
		
		Assert.AreEqual(2, list.Get(0));
		
		
		
		
	}
	
	[Test]
	public void GetMinFromList() // requires IndexOfMin() to be public (for now) - is this internal test?
	{
		var list = new TurboList<int>();
		
		list.Add(1);
		list.Add(11);
		list.Add(-9);
		list.Add(87);
		
		Assert.AreEqual(2, TurboSorting.IndexOfMin(list, 0));
		
		
	}

	[Test]
	public void ArraySortsFromSmallestToLargest()
	{
		var list = new TurboList<int>();

		Random r = new Random();
		
		for (int i = 0; i < 100; i++)
		{
			list.Add(r.Next(0,101));
		}
		
		TurboSorting.TurboSelectionSort(list);

		for (int i = 0; i < list.Count-1; i++)
		{
			Assert.GreaterOrEqual(list.Get(i+1), list.Get(i));
			
		}
	}
}
