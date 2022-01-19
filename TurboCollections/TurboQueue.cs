using System.Diagnostics.Metrics;

namespace TurboCollections;

public class TurboQueue<T>
{
	
	// returns the current amount of items contained in the stack.
	public int Count { get; private set; }
	public int QueueSize { get; private set; }
	private T[] queue = Array.Empty<T>();
	public int Offset { get; private set; }
	
	// // adds one item to the back of the queue.
	public void Enqueue(T item)
	{
		EnsureQueueSize(Count+1); // if Count (=number of elements in array >= length --> resize)
		//ADD NEW ITEM TO EMPTY SLOT Not necessarily to the end but first free after offset. ALso need to (if no free to the end of array, check the beginning all the way to the offset)
		queue[Count++] = item;
 
		//Modulo 1%4 = 1; --> USE modulo to loop through array. compare array length with Count(?). Eg., array of size 4: Count%Items.length --> 0%4 = 0, 1%4=0, 2%4=2, 3%4=3, 4%4=0, 5%4=1....

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

		// for (int i = 0; i < Count-1; i++)
		// {
		// 	queue[i] = queue[i + 1];
		// }

		queue[Offset] = default;
		Offset++;
		
		Count--;
		
		return firstQueueObject;
	}
	
	
	
	//GOOD IMPLEMENTATION
	//START = offset - ok
	//WHEN DEQUING, REMOVE FROM offset - ok
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
		//SORT HERE SOMEWHERE
		
		queue = tempQueue;

	}	
}

