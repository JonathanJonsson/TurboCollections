using System.Reflection;

namespace TurboCollections;

public class TurboHashSet<T>
{
	private static readonly int initialSize = 4;
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
			Resize();
		}

		var arrayPos = GetItemPosition(item);
		var positionCorrection = CollisionResolver(arrayPos);

		if (positionCorrection == -1)
		{
			Resize();
		}

		Console.WriteLine($"Inserting item {item} in position {arrayPos}");
		hashSet[positionCorrection] = item;
		itemCount++;

		return true;
		/*
		if(item.Exists) {
		return false;
		}
		
		var itemHashCode = item.gethashcode();
		
		var arraypos = itemHashCode%array.length;
		CheckCollision(); //If three collisions happen --> expondArray();
		
		if(numberOfSlotstaken/Arraysize < 0.3) {
		ExpandArray(); //When expanding array --> ned to re-insert again, new hashcodes will be generated (I think?)
		}
		
		array[arrayPos] = item;
		return true;
		
		*/
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
		itemCount--;

		return false;
	}

	private void Resize()
	{
		
		Console.WriteLine("Resize here!");
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
			if(Equals(hashSet[positionToCheck],default(T)))
			{
				return positionToCheck; //return the new empty slot for the object
			}

			positionToCheck++; // if it was not empty increase position to check next slot
		}

		return -1; //if all slots were occupied, return -1 (which will mean a resize & rehash) 
	}
}
