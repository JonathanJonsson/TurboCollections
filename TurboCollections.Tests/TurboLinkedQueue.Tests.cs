using NUnit.Framework;

namespace TurboCollections.Tests;

public class TurboLinkedQueue_Tests
{

	[Test]
	public void EnqueueIncreasesCount()
	{
		
		var lQueue = new TurboLinkedQueue<int>();
		lQueue.Enqueue(78);
		Assert.AreEqual(1, lQueue.Count);
	}
	
	
	
}
