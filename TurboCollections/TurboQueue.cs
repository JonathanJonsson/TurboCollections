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
		
		
		
		
		return default;
	}
	
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

