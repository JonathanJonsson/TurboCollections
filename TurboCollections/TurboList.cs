namespace TurboCollections;

public class TurboList<T>
{
	private T[] items = Array.Empty<T>();
	// returns the current amount of items contained in the list.
	public int Count => items.Length;
	
	public int GetCount()
	{
		return Count;
	}
	
	// adds one item to the end of the list.
	public void Add(T item)
	{
		// Array.Resize(ref elements, count);
		
		// //Create new temp array with size of old array
		T[] tempArray = new T[Count+1];

		for (int i = 0; i < Count; i++)
		{
			tempArray[i] = items[i];
		}
		
		tempArray[Count] = item;
		items = tempArray;
	
		// //Copy old array into temp array
		// for (int i = 0; i < Count; i++)
		// {
		// 	tempArray[i] = items[i];
		// }
		// //Increase Count by 1
		// Count++;
		// //extend old array by 1
		// items = new T[Count];
		//
		// //Copy temp array into old extended array
		// for (int i = 0; i < Count-1; i++)
		// {
		// 	items[i] = tempArray[i];
		// }
		// //Add new item to the end of array
		// items[Count - 1] = item;
	}

	// gets the item at the specified index. If the index is outside the correct range, an exception is thrown.
	public T Get(int index)
	{
		if (index < 0 || index > GetCount())
		{
			throw new Exception("Exception: the index is not in inside array!");
		}
		return items[index];
	}

	// removes all items from the list.
	public void Clear()
	{
		items = Array.Empty<T>();

	}

	// removes one item from the list. If the 4th item is removed, then the 5th item becomes the 4th, the 6th becomes the 5th and so on.
	void RemoveAt(int index)
	{
		throw new NotImplementedException();
	}

	// returns true, if the given item can be found in the list, else false.
	public bool Contains(T item)
	{
		for (int i = 0; i < Count; i++)
		{
			if (item.Equals(items[i]))
			{
				return true;

			}
		}

		return false;
	}

	// returns the index of the given item if it is in the list, else -1.
	public int IndexOf(T item)
	{
		for (int i = 0; i < Count; i++)
		{
			if (item.Equals(items[i]))
			{
				return i;

			}
		}

		return -1;
	}

	// removes the specified item from the list, if it can be found.
	void Remove(T item)
	{
		throw new NotImplementedException();
	}

	// adds multiple items to this list at once.
	void AddRange(IEnumerable<T> items)
	{
		throw new NotImplementedException();
	}

	// gets the iterator for this collection. Used by IEnumerator to support foreach.
	// IEnumerator<T>.GetEnumerator();

}
