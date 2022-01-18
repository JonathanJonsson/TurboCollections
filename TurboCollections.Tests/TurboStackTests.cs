namespace TurboCollections.Tests;
using NUnit.Framework;

public class TurboStackTests
{

	[Test]
	public void AddingToStackIncreasesCount()
	{
		var stack = new TurboStack<int>();
		var initialStackSize = stack.GetCount(); 
		stack.Push(1);
		Assert.True(stack.GetCount() > initialStackSize);
		
	}

	[Test]
	public void PeekReturnsLatestAddedValue()
	{
		var stack = new TurboStack<int>();
		stack.Push(2);
		stack.Push(5);
		stack.Push(8);
		
		Assert.AreEqual(8, stack.Peek());
		 
	}
	
	[Test]
	public void WhenRemovingTheTopValueBecomesTheValueUnderThePreviousTopInStack()
	{
		var stack = new TurboStack<int>();
		
		stack.Push(5);
		stack.Push(10);
		stack.Pop();
		
		Assert.AreEqual(5, stack.Peek());
	}

	[Test]
	public void ClearEmptiesTheStack()
	{
		var stack = new TurboStack<int>();
		
		stack.Push(2);
		stack.Push(2);
		stack.Push(2);
		stack.Push(2);

		stack.Clear();
		
		
		Assert.Zero(stack.GetCount());
		
		
	}
	
}
