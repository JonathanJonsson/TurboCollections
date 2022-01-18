namespace TurboCollections;

public class TurboList<T> //: IEnumerable<T>
{
	private int arraySize;

	// returns the current amount of items contained in the list.
	public int Count;
	private T[] items = Array.Empty<T>();

	public int GetCount()
	{
		return Count;
	}

	public int GetArraySize()
	{
		return arraySize;
	}

	// adds one item to the end of the list.
	public void Add(T item)
	{
		// Array.Resize(ref elements, count);
		if (arraySize == 0)
		{
			arraySize = 1;
		}

		// //Create new temp array with size of old array
		var tempArray = new T[Count + 1];

		if (arraySize <= Count)
		{
			arraySize *= 2;
		}

		Count++;

		for (var i = 0; i < Count - 1; i++)
		{
			tempArray[i] = items[i];
		}

		tempArray[Count - 1] = item;
		items = tempArray;
	}

	// gets the item at the specified index. If the index is outside the correct range, an exception is thrown.
	public T Get(int index)
	{
		if (index < 0 || index > GetCount())
		{
			throw new Exception("Exception: the index is not within the array!");
		}

		return items[index];
	}

	public void Set(int index, T value)
	{
		if (index < 0 || index > GetCount())
		{
			throw new Exception("Exception: the index is not within the array!");
		}

		items[index] = value;
	}

	// removes all items from the list.
	public void Clear()
	{
		for (var i = 0; i < Count - 1; i++)
		{
			items[i] = default;
		}

		Count = 0;
	}

	// removes one item from the list. If the 4th item is removed, then the 5th item becomes the 4th, the 6th becomes the 5th and so on.
	public void RemoveAt(int index)
	{
		if (index < 0 || index > Count)
		{
			throw new Exception("Exception: the index is not within the array!");
		}

		var tempArray = new T[items.Length];
		Count--;
		var a = 0;

		for (var i = 0; i <= Count; i++)
		{
			if (i != index)
			{
				tempArray[a] = items[i];
				a++;
			}
			else
			{
				tempArray[i] = default;
			}
		}

		items = tempArray;
	}

	// returns true, if the given item can be found in the list, else false.
	public bool Contains(T item)
	{
		for (var i = 0; i < Count; i++)
		{
			if (Equals(item, items[i]))
			{
				return true;
			}
		}

		return false;
	}

	// returns the index of the given item if it is in the list, else -1.
	public int IndexOf(T item)
	{
		for (var i = 0; i < Count; i++)
		{
			if (item.Equals(items[i]))
			{
				return i;
			}
		}

		return -1;
	}

	// removes the specified item from the list, if it can be found.
	public void Remove(T item)
	{
		var indexOfItem = -1;

		if (IndexOf(item) != -1)
		{
			indexOfItem = IndexOf(item);
		}
		else
		{
			throw new Exception("Exception: item was not found and no index could be retrieved!");
		}

		RemoveAt(indexOfItem);
	}

	// adds multiple items to this list at once.
	public void AddRange(IEnumerable<T> items)
	{
		foreach (var item in items)
		{
			Add(item);
		}
	}

	// gets the iterator for this collection. Used by IEnumerator to support foreach.
	// IEnumerator<T> IEnumerable<T>.GetEnumerator();
	// IEnumerator<T> IEnumerable<T>.GetEnumerator();
}
