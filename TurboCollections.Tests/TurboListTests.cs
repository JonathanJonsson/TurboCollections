using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TurboCollections.Tests;

public class TurboListTests
{
	[Test]
	public void NewListIsEmpty()
	{
		var list = new TurboList<int>();
		Assert.Zero(list.Count);
	}

	[Test]
	public void AddingAnElementIncreasesCountToOne() // Is this test relevant anymore?
	{
		var list = new TurboList<int>();
		list.Add(5);
		Assert.AreEqual(1,list.Count);
	}
	
	[Test, TestCase(5), TestCase(7)]
	public void AddingAnElementIncreasesCount(int numberOfElements)
	{
		var list = new TurboList<int>();

		for (int i = 0; i < numberOfElements; i++)
		{
			list.Add(5);
		}
	
		Assert.AreEqual(numberOfElements,list.Count);
	}

	[Test]
	public void GetValueFromIndex()
	{
		var list = new TurboList<int>();

		list.Add(1234);
		Assert.AreEqual(1234, list.Get(0));
	}

	[Test]
	public void CheckIfArrayIsEmpty()
	{
		var list = new TurboList<int>();
		list.Add(2);
		list.Clear();
		Assert.Zero(list.Count);
	}

	[Test]
	public void CheckIfArrayContainsItem()
	{
		var list = new TurboList<int>();
		list.Add(4);
		list.Add(9);
		list.Add(3);

		Assert.True(list.Contains(3));
	
	}

	[Test]
	public void GetIndexOfPresentElement()
	{
		var list = new TurboList<int>();
		list.Add(1);
		list.Add(2);
		
		Assert.AreEqual(0,list.IndexOf(1));
	}

	[Test]
	public void GetIndexOfNotPresentElement()
	{
		var list = new TurboList<int>();
		
		Assert.AreEqual(-1, list.IndexOf(999));
	}

	[Test, TestCase(5), TestCase(7)]
	public void RemoveAtIndexAndElementsShiftOneToLeft(int numberOfElements)
	{
		var list = new TurboList<int>();

		for (int i = 0; i < numberOfElements; i++)
		{
			list.Add(1);
			
		}
		list.RemoveAt(0);
		Assert.AreEqual(numberOfElements-1, list.Count);
	}

	[Test]
	public void RemoveSpecifiedItem()
	{
		var list = new TurboList<int>();
		
		list.Add(3);
		list.Add(8);
		list.Remove(3);
		Assert.IsFalse(list.Contains(3));
	}

	[Test]
	public void CheckThatArraySizeIsConstantAfterRemovingItem()
	{
		var list = new TurboList<int>();
		
		list.Add(3);
		list.Add(6);
		var startingArraySize = list.GetArraySize();
		list.RemoveAt(0);
		
		Assert.AreEqual(list.GetArraySize(), startingArraySize);
	}

	[Test]
	public void SetItemInList()
	{
		var list = new TurboList<int>();
		
		list.Add(1);
		list.Add(2);
		list.Set(0, 10);
		Assert.AreEqual(10, list.Get(0));

	}

	[Test]
	public void NoDoubleArraySizeWhenAddingOneObject()
	{
		var list = new TurboList<int>();
		
		list.Add(1);
		Assert.AreEqual(list.Count, list.GetArraySize());
		 
	}

	[Test]
	public void DoubleArraySizeWhenCountExceedsArraySize()
	{
		var list = new TurboList<int>();
		
		list.Add(2);
		list.Add(4);
		Assert.AreEqual(2, list.GetArraySize());
	}
	
}