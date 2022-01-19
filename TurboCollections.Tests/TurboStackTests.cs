using System;
using NUnit.Framework;

namespace TurboCollections.Tests;

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
		stack.Yeet();
		Assert.AreEqual(5, stack.Peek());
	}

	private void CheckForEmptyStack(TurboStack<int> stack)
	{
		Assert.Zero(stack.GetCount());
		Assert.Throws<IndexOutOfRangeException>(() => stack.Yeet());
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
		CheckForEmptyStack(stack);
	}
}
