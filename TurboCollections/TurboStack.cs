namespace TurboCollections;

public class TurboStack<T>
{
	private int arraySize;

	private int count;
	private T?[] stack = Array.Empty<T>();

	public int GetCount()
	{
		return count;
	}

	// adds one item on top of the stack.
	public void Push(T? item)
	{
		if (arraySize == 0)
		{
			arraySize = 1;
		}

		if (arraySize <= count)
		{
			arraySize *= 2;
		}

		count++;
		var tempStack = new T?[count];

		for (var i = 0; i < count - 1; i++)
		{
			tempStack[i] = stack[i];
		}

		tempStack[count - 1] = item;
		stack = tempStack;
	}

	// // returns the item on top of the stack without removing it.
	public T? Peek()
	{
		return stack[count - 1];
	}

	// // returns the item on top of the stack and removes it at the same time.
	public T? Pop()
	{
		count--; // = Count-1
		var objectToReturn = stack[count];
		stack[count] = default;

		return objectToReturn;
	}

	// // removes all items from the stack.
	public void Clear()
	{
		for (var i = 0; i < count - 1; i++)
		{
			stack[i] = default;
		}

		count = 0;
	}

	// // gets the iterator for this collection. Used by IEnumerable<T>-Interface to support foreach.
	// // IEnumerator<T> IEnumerable<T>.GetEnumerator();
}
