namespace TurboCollections;

public class TurboHashSet<T>
{
	private static int initialSize = 4;
	public T[] hashSet = new T[initialSize];
	public int itemCount =0;

	 
	
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
		hashSet[arrayPos+positionCorrection] = item;
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

		for (int i = 0; i < 3; i++)
		{
			if ((arrayPos + i) > hashSet.Length-1)
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

		return (int)arrayPos;
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
		for (int i = 0; i < 3; i++)
		{
			if ((positionToCheck + i) > hashSet.Length-1)
			{
				positionToCheck = 0;
			}
			if (hashSet[positionToCheck+i] == null)
			{
				return i;
				
			} 
		}
		
		return -1;
	}



}
