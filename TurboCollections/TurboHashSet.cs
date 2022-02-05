namespace TurboCollections;

public class TurboHashSet<T>
{
	private static int initialSize = 15;
	private T[] hashSet = new T[initialSize];
	public int itemCount =0;

	 
	
	public bool Insert(T item)
	{


		if (Exists(item))
		{
			return false;
		}

		if (itemCount/hashSet.Length < 0.3)
		{
			Resize();
		}
		var arrayPos = GetItemPosition(item);
		var positionCorrection = CollisionResolver(arrayPos);

		if (positionCorrection == -1)
		{
			Resize();
		}
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
			if (hashSet[arrayPos + i].Equals(item))
			{
				return true;
			}
		}
		
		return false;
	}

	private long GetItemPosition(T item)
	{
		var itemHashCode = (uint) item.GetHashCode();
		var arrayPos = itemHashCode/hashSet.Length;

		return arrayPos;
	}

	public bool Remove(T item)
	{
		itemCount--;
		return false;
	}

	private void Resize()
	{
		
	}

	private int CollisionResolver(long positionToCheck)
	{
		for (int i = 0; i < 3; i++)
		{
			if (hashSet[positionToCheck+i] != null)
			{
				return i;
				
			}
		}
		
		return -1;
	}



}
