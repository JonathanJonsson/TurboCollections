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
	public void AddingAnElementIncreasesCountToOne()
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
	
	
}