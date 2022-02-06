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
}

