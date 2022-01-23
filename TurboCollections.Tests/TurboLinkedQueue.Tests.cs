using System;
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

	[Test]
	public void PeekReturnsFirstQueueValue()
	{
		var lQueue = new TurboLinkedQueue<int>();
		lQueue.Enqueue(5);
		
		Assert.AreEqual(5, lQueue.Peek());
		
	}

	[Test]
	public void PeekingAtEmptyQueueThrowsException()
	{
		var lQueue = new TurboLinkedQueue<string>();

		Assert.Throws<Exception>(() => lQueue.Peek());

	}
	
}
