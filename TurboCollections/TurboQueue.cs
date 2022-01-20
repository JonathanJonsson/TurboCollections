namespace TurboCollections;

public class TurboQueue<T>
{
	private T[] queue = Array.Empty<T>();
	
	public int Count { get; private set; }
	public int Offset { get; private set; }
	private int write { get; set; } = -1;

	// // adds one item to the back of the queue.
	public void Enqueue(T item)
	{
		EnsureQueueSize(Count + 1); // if Count (=number of elements in array >= length --> resize)
		write = (write + 1)%queue.Length;
		queue[write] = item;
		Count++;
	}

	// // returns the item in the front of the queue without removing it.
	public T Peek()
	{
		if (Count <= 0)
		{
			throw new Exception("Exception: Stack is empty. Returning default value from empty slot");
		}

		return queue[Offset];
	}

	// // returns the item in the front of the queue and removes it at the same time.
	public T Dequeue()
	{
		if (Count <= 0)
		{
			throw new Exception("Error: Queue is empty");
		}

		var firstQueueObject = queue[Offset];
		queue[Offset] = default;
		Offset = (Offset + 1)%queue.Length;
		Count--;

		return firstQueueObject;
	}

	// // removes all items from the queue.
	public void Clear()
	{
		for (var i = 0; i < queue.Length; i++)
		{
			queue[i] = default;
		}

		//reset Count
		Count = 0;
		//reset offset
		Offset = 0;
		//Default pos to start write
		write = -1;
	}

	private void EnsureQueueSize(int sizeRequired)
	{
		if (queue.Length >= sizeRequired)
		{
			return;
		}

		var newSize = Math.Max(sizeRequired, queue.Length*2);
		var tempQueue = new T[newSize];

		//Copy to new array, where the numbers enqueued are repeating
		if (queue.Length > 0)
		{
			for (var i = 0; i < tempQueue.Length; i++)
			{
				tempQueue[i] = queue[i%Count];
			}
		}

		var arraySegmentBetweenZeroAndOffset = new T[Offset];

		//get first part of the array all the way to the offset
		for (var i = 0; i < Offset; i++)
		{
			arraySegmentBetweenZeroAndOffset[i] = tempQueue[i];
		}

		//	Shift all values from Offset to beginning of array
		for (var i = 0; i < tempQueue.Length - Offset; i++)
		{
			tempQueue[i] = tempQueue[i + Offset];
		}

		//Add the first part before offset as end part of array
		for (var i = 0; i < arraySegmentBetweenZeroAndOffset.Length; i++)
		{
			tempQueue[tempQueue.Length - arraySegmentBetweenZeroAndOffset.Length] = arraySegmentBetweenZeroAndOffset[i];
		}

		if (queue.Length > 0)
		{
			//for ease of debugging (and also good I think?) - Set default to copies that has not been enqueued 
			for (var i = queue.Length; i < tempQueue.Length; i++)
			{
				tempQueue[i] = default;
			}
		}

		//So that the next index enters at the end of current series instead of restarting at index =0.
		write = queue.Length - 1;

		//Reset offset now that it has been put to the front of the array
		Offset = 0;
		queue = tempQueue;
	}
}
