using System.Collections;
using System.Collections.Generic;

namespace TurboCollections;

public class TurboList<T> //: IEnumerable<T>
{
	private T[] items = Array.Empty<T>();
	
	// returns the current amount of items contained in the list.
	public int Count =0;
	private int arraySize = 1;
	
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
		
		// //Create new temp array with size of old array
		T[] tempArray = new T[Count+1];

		if (arraySize <= Count)
		{
			arraySize *= 2;
		}

		Count++;
		for (int i = 0; i < Count-1; i++)
		{
			tempArray[i] = items[i];
		}
		
		tempArray[Count-1] = item;
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

	public T Set(int index, T value)
	{
		if (index < 0 || index > GetCount())
		{
			throw new Exception("Exception: the index is not within the array!");
			
		}
		return items[index] = value;
	}

	// removes all items from the list.
	public void Clear()
	{
		items = Array.Empty<T>();
		Count = 0;

	}

	// removes one item from the list. If the 4th item is removed, then the 5th item becomes the 4th, the 6th becomes the 5th and so on.
	public void RemoveAt(int index)
	{
		if (index < 0 || index>Count)
		{
			throw new Exception("Exception: the index is not within the array!");
		}
		T[] tempArray = new T[Count-1];

		int a = 0; 
		for (int i = 0; i < Count-1; i++)
		{
			if (i != index)
			{
				tempArray[a] = items[i]; // temparray need to follow a, cause the one time i!=index --> mismatch otherwise, skipping one array element in temparrayu
				a++;
			}
		}

		Count--;
		items = tempArray;

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
	void AddRange(IEnumerable<T> items)
	{
		throw new NotImplementedException();
	}

	
	// gets the iterator for this collection. Used by IEnumerator to support foreach.
	// IEnumerator<T> IEnumerable<T>.GetEnumerator();
	// IEnumerator<T> IEnumerable<T>.GetEnumerator();
	
}
