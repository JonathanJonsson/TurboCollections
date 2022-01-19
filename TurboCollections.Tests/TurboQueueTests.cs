﻿using System;
using NUnit.Framework;

namespace TurboCollections.Tests;

public class TurboQueueTests
{
	[Test]
	public void EnqueueToQueueTest()
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
	public void ThrowExceptionOnEmptyQueue()
	{
		var queue = new TurboQueue<string>();

		Assert.Throws<Exception>(()=>queue.Dequeue());
	}
	
	
}
