using System.Diagnostics.Metrics;

namespace TurboCollections;

public class TurboQueue<T>
{
	
	// returns the current amount of items contained in the stack.
	public int Count { get; private set; }
	private T[] queue =Array.Empty<T>();
	public int Offset { get; private set; }
	public int write { get; private set; } = -1;
	
	
	
	
	// // adds one item to the back of the queue.
	public void Enqueue(T item)
	{
		
		EnsureQueueSize(Count+1); // if Count (=number of elements in array >= length --> resize)

		// queue[Count++%queue.Length] = item;
		// write = (Count++)%queue.Length;
		write = (write+1)%queue.Length;

		queue[write] = item;
	 

		Count++;
	}
	
	// // returns the item in the front of the queue without removing it.
	public T Peek()
	{
		return queue[0];
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

		//Copy to new array (repeating)
		if (queue.Length > 0  )
		{
		
			for (int i = 0; i < tempQueue.Length; i++)
			{
				tempQueue[i] = queue[i%Count];
			}	
			
			
		}

		 
			T[] ArrayBetweenBegginingAndOffset = new T[Offset];
			//get first part of the array all the way to the offset
			for (int i = 0; i < Offset; i++)
			{
				ArrayBetweenBegginingAndOffset[i] = tempQueue[i];  
			}
//	Shift all values from Offset to beginning of array
			for (int i = 0; i < tempQueue.Length-Offset; i++)
			{
				tempQueue[i] = tempQueue[i + Offset];
			}
//Add the first part before offset as end part of array
			for (int i = 0; i < ArrayBetweenBegginingAndOffset.Length; i++)
			{
				tempQueue[tempQueue.Length-ArrayBetweenBegginingAndOffset.Length] = ArrayBetweenBegginingAndOffset[i];
			}

			if (queue.Length > 0)
			{
				//for ease of debugging (and also good I think?) - Set default to copies that has not been enqueued 
				for (int i = queue.Length; i < tempQueue.Length; i++)
				{
					tempQueue[i] = default;
				}	
			}

			write = queue.Length - 1;
			//Reset offset now that it has been put to the front of the array
			Offset = 0;
		

		queue = tempQueue;

	}	
}

