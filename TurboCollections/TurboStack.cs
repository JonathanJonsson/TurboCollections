namespace TurboCollections;

public class TurboStack<T>
{
	private T[] stack = Array.Empty<T>();
	
	private int count =0;
	private int arraySize = 1;
	
	public int GetCount()
	{
		return count;
	}
 
	// adds one item on top of the stack.
	public void Push(T item)
	{
		T[] tempStack = new T[count+1];

		if (arraySize <= count)
		{
			arraySize *= 2;
		}

		count++;
		for (int i = 0; i < count-1; i++)
		{
			tempStack[i] = stack[i];
		}
		
		tempStack[count-1] = item;
		stack = tempStack;
		
	}
	// // returns the item on top of the stack without removing it.
	public T Peek()
	{
		return stack[count - 1];
	}
	
	// // returns the item on top of the stack and removes it at the same time.
	public T Pop()
	{
		var objectToReturn = stack[count - 1];
		T[] tempStack = new T[count - 1];
		for (int i = 0; i < count-1; i++)
		{
			tempStack[i] = stack[i];
		}

		count--;
		stack = tempStack;

		return objectToReturn;
	}
	// // removes all items from the stack.
	public void Clear()
	{
		stack = Array.Empty<T>();
		count = 0;
	}
	// // gets the iterator for this collection. Used by IEnumerable<T>-Interface to support foreach.
	// // IEnumerator<T> IEnumerable<T>.GetEnumerator();
	
	
	
	
	
	
	
}
