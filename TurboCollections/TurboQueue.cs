using System.Diagnostics.Metrics;

namespace TurboCollections;

public class TurboQueue<T>
{
	
	// returns the current amount of items contained in the stack.
	public int Count { get; private set; }
	public int QueueSize { get; private set; }
	private T[] queue = Array.Empty<T>();
	
	// // adds one item to the back of the queue.
	public void Enqueue(T item)
	{
		EnsureQueueSize(Count+1);
		queue[Count++] = item;
	}
	
	// // returns the item in the front of the queue without removing it.
	public T Peek()
	{
		return queue[0];
	}
	
	//POOR IMPLEMENTATION
	// // returns the item in the front of the queue and removes it at the same time.
	public T Dequeue()
	{
		if (Count <= 0)
		{
			throw new Exception("Error: Queue is empty");
		}
		var firstQueueObject = queue[0];

		for (int i = 0; i < Count-1; i++)
		{
			queue[i] = queue[i + 1];
		}

		queue[Count - 1] = default;
		Count--;
		
		
		return firstQueueObject;
	}
	
	//GOOD IMPLEMENTATION
	//FROMT = Offest + index points att start in array
	//WHEN DEQUING, REMOVE FROM FRONT
	//WHEN ADDING, ADD TO THE END, IF FULL AFTER START POINT--> START CHECKING FROM INDEX=0 AND SEE IF FREE SLOTS
	// ADD TO FREE SLOT INFRONT OF STARTER
	// IF START REACHES END OF ARRAY --> USE MODULO TO RESET START TO INDEX =0
	//IF ALL SLOTS ARE FULL (BOTH BEFORE AND AFTER START) EXPAND ARRAY, SORT SO THAT THE START (AND ALL ELEMENTS) ARE MOVED TO START AT INDEX=0, AND CONTINUE ADD TO THE END AS USUAL
	
	// // removes all items from the queue.
	public void Clear()
	{
		for (int i = 0; i < Count; i++)
		{
			queue[i] = default;
		}

		Count = 0;
	}



	private void EnsureQueueSize(int sizeRequired)
	{
		if (queue.Length >= sizeRequired)
		{
			return;
		}

		int newSize = Math.Max(sizeRequired, queue.Length*2);

		T[] tempQueue = new T[newSize];

		for (int i = 0; i < Count; i++)
		{
			tempQueue[i] = queue[i];
		}

		queue = tempQueue;

	}	
}

