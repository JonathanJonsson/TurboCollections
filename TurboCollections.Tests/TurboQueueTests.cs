using System;
using NUnit.Framework;

namespace TurboCollections.Tests;

public class TurboQueueTests
{
	public class QueueCreation
	{
		[Test]
		public void ThrowExceptionOnEmptyQueue()
		{
			var queue = new TurboQueue<string>();

			Assert.Throws<Exception>(()=>queue.Dequeue());
		}
	}
	
	[Test]
	public void EnqueueToQueue()
	{
		var queue = new TurboQueue<string>();
		
		queue.Enqueue("Hello");
		Assert.AreEqual(1, queue.Count);
	}

	[Test]
	public void PeekOnFirstElement()
	{
		var queue = new TurboQueue<string>();
		
		queue.Enqueue("Hi");
		queue.Enqueue("Marc");
		
		Assert.AreEqual("Hi", queue.Peek()); //Check that peek looks at index 0
		Assert.AreNotEqual("Marc", queue.Peek()); // checks that peek does not refer to last index for some reason.
	}

	[Test]
	public void CheckThatEmptySetsToDefault()
	{
		var queue = new TurboQueue<string>();
		
		queue.Enqueue("Hello");
		queue.Clear();	
		Assert.AreEqual(default, queue.Peek());
		
	}

	[Test]
	public void GetTheFirstElementFromQueueWhenDequeuing()
	{
		var queue = new TurboQueue<string>();
		queue.Enqueue("Hello");
		queue.Enqueue("World");
		var firstStringElement = queue.Dequeue();
		Assert.AreEqual("Hello", firstStringElement);
 	
	}
	[Test]
	public void OffsetPointsAtNextElementAfterDequeue()
	{
		var queue = new TurboQueue<int>();
		queue.Enqueue(111);
		queue.Enqueue(222);
		queue.Dequeue();
		
		Assert.AreEqual(1, queue.Offset);
	}

	[Test]
	public void MarcSmartArrayTest()
	{
		var queue = new TurboQueue<int>();
		queue.Enqueue(1); // 1
		queue.Enqueue(2); // 2
		queue.Enqueue(3); // 3
		queue.Enqueue(4); // 4
		Assert.AreEqual(1,queue.Dequeue());
		queue.Enqueue(5);
		Assert.AreEqual(2, queue.Dequeue());
		queue.Enqueue(6); // 4
		Assert.AreEqual(3, queue.Dequeue());
		Assert.AreEqual(4, queue.Dequeue());
		Assert.AreEqual(5, queue.Dequeue());

		
		queue.Enqueue(7); // 2
		queue.Enqueue(8); // 3
		queue.Enqueue(9); // 4
		Assert.AreEqual(6, queue.Dequeue());
		Assert.AreEqual(7, queue.Dequeue());
		Assert.AreEqual(8, queue.Dequeue());
		Assert.AreEqual(9, queue.Dequeue());

	}

	public void JJArrayTest()
	{
		var queue = new TurboQueue<int>();
		queue.Enqueue(222);
		queue.Enqueue(666);
		Assert.AreEqual(111,queue.Dequeue()); 
		queue.Enqueue(222); // Full array here
		queue.Enqueue(333); // Issue is here - when calculating write for the full array it jumps back to write = 0 --> overwrites 666 in index 1.
		queue.Enqueue(555);

		Assert.AreEqual(666,queue.Dequeue());

		// queue.Enqueue(444);
	}
[Test]
	public void MarcFailingTest() //Technically internal test
	{
		var queue = new TurboQueue<int>();
		queue.Enqueue(1); // 1
		queue.Enqueue(2); // 2
		queue.Enqueue(3); // 3
		queue.Enqueue(4); // 4
		Assert.AreEqual(1,queue.Dequeue());
		queue.Enqueue(5);
		queue.Enqueue(6); // 4

		Assert.AreEqual(2, queue.Dequeue());
		Assert.AreEqual(3, queue.Dequeue());
		Assert.AreEqual(4, queue.Dequeue());
		Assert.AreEqual(5, queue.Dequeue());
		//
		//
		// queue.Enqueue(7); // 2
		// queue.Enqueue(8); // 3
		// queue.Enqueue(9); // 4
		// Assert.AreEqual(6, queue.Dequeue());
		// Assert.AreEqual(7, queue.Dequeue());
		// Assert.AreEqual(8, queue.Dequeue());
		// Assert.AreEqual(9, queue.Dequeue());

	}
	
	
}
