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
}
