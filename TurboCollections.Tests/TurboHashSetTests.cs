using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using NUnit.Framework;

namespace TurboCollections.Tests;

 
public class TurboHashSetTests
{
	[Test]
	public void SearchingForItemThatDoesNotExistsReturnsFalse()
	{
		var hashSet = new TurboHashSet<int>();

		
		Assert.False(hashSet.Exists(5));
	}
	
	[Test]
	public void InsertItemReturnsIncreaseInCount()
	{
		var hashSet = new TurboHashSet<int>();

		hashSet.Insert(1);
		Assert.AreEqual(1, hashSet.itemCount);

	}

	[Test]
	public void RemoveItemDecreasesCount()
	{
		var hashSet = new TurboHashSet<int>();

		hashSet.Insert(1);
		hashSet.Remove(1);
		Assert.AreEqual(0, hashSet.itemCount);
	}

	[Test]
	public void InsertingSomethingThatAlreadyExistsReturnsFalse()
	{
		var hashset =new TurboHashSet<string>();
		hashset.Insert("a");
		Assert.IsFalse(hashset.Insert("a"));
	}

	[Test]
	public void InsertingSomethingThatDoesNotExistReturnsTrue()
	{
		var hashset =new TurboHashSet<string>();
		hashset.Insert("a");
		Assert.IsTrue(hashset.Insert("b"));
	}


	[Test]
	public void ResizeArrayDoublesArraySize()
	{
		var hashSet = new TurboHashSet<int>();
		var initalSize = hashSet.hashSet.Length;
		hashSet.Insert(1);
		hashSet.Insert(2);
		hashSet.Insert(3);
		Assert.AreEqual(initalSize*2, hashSet.hashSet.Length*2);

	}

	[Test]
	public void ResizedArrayContainsSameThingsAsBeforeResize()
	{
		var hashset = new TurboHashSet<string>();
		hashset.Insert("Aa");
		hashset.Insert("Bb");
		hashset.Insert("Cc");
		hashset.Insert("Dd");
		//Resized has happened
		Assert.IsTrue(hashset.Exists("Aa"));
		Assert.IsTrue(hashset.Exists("Bb"));
		Assert.IsTrue(hashset.Exists("Cc"));
		Assert.IsTrue(hashset.Exists("Dd"));

	}

	[Test]
	public void RemoveItemRemovesObjectFromArray()
	{
		var hashset = new TurboHashSet<string>();
		hashset.Insert("Aa");
		hashset.Insert("Bb");
		hashset.Remove("Aa");
		
		Assert.IsFalse( hashset.Exists("Aa"));
	}
}

