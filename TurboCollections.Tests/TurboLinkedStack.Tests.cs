using System;
using NUnit.Framework;

namespace TurboCollections.Tests;

 
public class TurboLinkedStack_Tests
{

	[Test]
	public void StackHasNotBeenInitialized()
	{
		var linkedStack = new TurboLinkedStack<int>();
	
		Assert.Throws<NullReferenceException>(()=>linkedStack.Peek());
	}

	[Test]
	public void PushToTheStackIncreasesCount()
	{
		var linkedStack = new TurboLinkedStack<int>();
		linkedStack.Push(1);
		Assert.AreEqual(1, linkedStack.Count);
	}


	[Test]
	public void ClearEmptiesTheStack()
	{
		var linkedStack = new TurboLinkedStack<string>();
		
		linkedStack.Push("Hello");
		linkedStack.Push("World");
		linkedStack.Clear();
		Assert.Zero(linkedStack.Count);
	}

	[Test]
	public void LatestEntryIsReturnedAndRemovedWhenPop()
	{
		var linkedStack = new TurboLinkedStack<int>();
		
		linkedStack.Push(8);
		linkedStack.Push(5);

		var g = linkedStack.Pop();
		Assert.AreEqual(5, g);
		Assert.AreEqual(8, linkedStack.Peek());
		Assert.AreEqual(1, linkedStack.Count);
		 
	}
	
	
	
	
	
	
}
