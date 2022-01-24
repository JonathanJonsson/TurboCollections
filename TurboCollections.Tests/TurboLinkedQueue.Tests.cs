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

	[Test]
	public void DequeueDecreasesCount()
	{
		var lQueue = new TurboLinkedQueue<int>();
		lQueue.Enqueue(2);
		lQueue.Enqueue(1);
		var initialCount = lQueue.Count;
		lQueue.Dequeue();
		Assert.AreEqual(initialCount-1, lQueue.Count);
	}

	[Test]
	public void DequeueReturnsFirstObject()
	{
		var lQueue = new TurboLinkedQueue<int>();
		lQueue.Enqueue(4);
		lQueue.Enqueue(1);
		
		Assert.AreEqual(4, lQueue.Dequeue());
	}

	[Test]
	public void DequeueAdvancesQueueForward()
	{
		var lQueue = new TurboLinkedQueue<int>();
		lQueue.Enqueue(1);
		lQueue.Enqueue(2);
		lQueue.Dequeue();
		Assert.AreEqual(2, lQueue.Peek());
	}

	[Test]
	public void ClearEmptiesTheQueue()
	{
		var lQueue = new TurboLinkedQueue<int>();
		lQueue.Enqueue(1);
		lQueue.Enqueue(2);
		lQueue.Enqueue(3);
		
		lQueue.Clear();
		
		Assert.Throws<Exception>(() => lQueue.Clear());
 
	}
	
	
}
