namespace TurboCollections;

public class TurboHashSet<T>
{
	private static readonly int initialSize = 3;
	public T[] hashSet = new T[initialSize];
	public int itemCount;

	public bool Insert(T item)
	{
		if (Exists(item))
		{
			return false;
		}

		if (itemCount/hashSet.Length > 0.7)
		{
			ResizeAndReHash();
		}

		var arrayPos = GetItemPosition(item);
		var positionCorrection = CollisionResolver(arrayPos);

		if (positionCorrection == -1)
		{
			ResizeAndReHash();
		}

		Console.WriteLine($"Inserting item {item} in position {positionCorrection}");
		hashSet[positionCorrection] = item;
		itemCount++;

		return true;
	}

	public bool Exists(T item)
	{
		var arrayPos = GetItemPosition(item);

		for (var i = 0; i < 3; i++)
		{
			if (arrayPos + i > hashSet.Length - 1)
			{
				arrayPos = 0;
			}

			if (hashSet[arrayPos + i] != null && hashSet[arrayPos + i].Equals(item))
			{
				return true;
			}
		}

		return false;
	}

	private int GetItemPosition(T item)
	{
		var itemHashCode = (uint) item.GetHashCode();
		var arrayPos = itemHashCode%hashSet.Length;

		return (int) arrayPos;
	}

	public bool Remove(T item)
	{
		if (!Exists(item))
		{
			return false;
		}

		var arrayPos = GetItemPosition(item);
		hashSet[arrayPos] = default;
		itemCount--;

		return true;
	}

	private void ResizeAndReHash()
	{
		Console.WriteLine("Resize here!");
		itemCount = 0;
		var tempArray = new T[hashSet.Length];

		for (var i = 0; i < hashSet.Length; i++)
		{
			tempArray[i] = hashSet[i];
			hashSet[i] = default;
		}

		hashSet = new T[tempArray.Length*2];

		for (var i = 0; i < tempArray.Length; i++)
		{
			Insert(tempArray[i]);
		}
	}

	private int CollisionResolver(int positionToCheck)
	{
		for (var i = 0; i < 3; i++) //checking the next three slots if available
		{
			if (positionToCheck > hashSet.Length - 1) // If we reach the end end of the array --> start from the front again
			{
				positionToCheck = 0;
			}

			// if (hashSet[positionToCheck] == null) // if the slot is empty 
			if (Equals(hashSet[positionToCheck], default(T)))
			{
				return positionToCheck; //return the new empty slot for the object
			}

			positionToCheck++; // if it was not empty increase position to check next slot
		}

		return -1; //if all slots were occupied, return -1 (which will mean a resize & rehash) 
	}
}
