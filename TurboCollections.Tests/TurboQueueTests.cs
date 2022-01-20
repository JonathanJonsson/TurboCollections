using System;
using NUnit.Framework;

namespace TurboCollections.Tests;

public class TurboQueueTests
{
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
	public void CheckThatEmptyThrowsExceptionForEmptyStack()
	{
		var queue = new TurboQueue<string>();
		
		queue.Enqueue("Hello");
		queue.Clear();
		
		Assert.Throws<Exception>(() => queue.Peek());
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
	public void FullArrayExpandsAndEnqueuesDoesNotOverwriteButContinuesCorrectlyEnqueuing()
	{
		var queue = new TurboQueue<int>();
		
		queue.Enqueue(222);
		queue.Enqueue(666);
		
		Assert.AreEqual(222, queue.Dequeue());
		
		queue.Enqueue(222);
		queue.Enqueue(333); 
		queue.Enqueue(555);
		
		Assert.AreEqual(666, queue.Dequeue());
	}

	[Test]
	public void InternalTestForDebug() //Technically internal test
	{
		var queue = new TurboQueue<int>();
		
		queue.Enqueue(1); // 1
		queue.Enqueue(2); // 2
		queue.Enqueue(3); // 3
		queue.Enqueue(4); // 4
		
		Assert.AreEqual(1, queue.Dequeue());
		
		queue.Enqueue(5);
		queue.Enqueue(6); // 4
		
		Assert.AreEqual(2, queue.Dequeue());
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

	[Test]
	public void InternalTestButWithString() //Technically internal test
	{
		var queue = new TurboQueue<string>();
		
		queue.Enqueue("Welcome"); // 1
		queue.Enqueue("to"); // 2
		queue.Enqueue("my"); // 3
		queue.Enqueue("zoo!"); // 4
		
		Assert.AreEqual("Welcome", queue.Dequeue());
		queue.Enqueue("We");
		queue.Enqueue("got"); // 4
		
		Assert.AreEqual("to", queue.Dequeue());
		Assert.AreEqual("my", queue.Dequeue());
		Assert.AreEqual("zoo!", queue.Dequeue());
		Assert.AreEqual("We", queue.Dequeue());
		
		queue.Enqueue("dogs"); // 2
		queue.Enqueue("cats"); // 3
		queue.Enqueue("and zebras"); // 4
		
		Assert.AreEqual("got", queue.Dequeue());
		Assert.AreEqual("dogs", queue.Dequeue());
		Assert.AreEqual("cats", queue.Dequeue());
		Assert.AreEqual("and zebras", queue.Dequeue());
	}

	public class QueueCreation
	{
		[Test]
		public void ThrowExceptionOnEmptyQueue()
		{
			var queue = new TurboQueue<string>();
			
			Assert.Throws<Exception>(() => queue.Dequeue());
		}
	}
}