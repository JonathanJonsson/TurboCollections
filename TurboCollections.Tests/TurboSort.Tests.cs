using NUnit.Framework;

namespace TurboCollections.Tests;

public class TurboSort_Tests
{
	[Test]
	public void SwapTwoElementsWork() // requires Swap() to be public (for now) - is this internal test?
	{
		var list = new TurboList<int>();
		
		list.Add(1);
		list.Add(2);
		
		Assert.AreEqual(1, list.Get(0));
		
		TurboSort.SwapPositions(list,1,0);
		
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
		
		Assert.AreEqual(2, TurboSort.IndexOfMin(list, 0));
		
		
	}
}
