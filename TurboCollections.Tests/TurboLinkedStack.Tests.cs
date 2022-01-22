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
		Assert.Zero(linkedStack.Count);
	}
	
	
	
}
