namespace TurboCollections;
public class QueueNode<U>
{
	private U data;
	public StackNode<U> next;
		 
	public QueueNode(U _data)
	{
		data = _data;
		next = null;
	}

	public U GetData()
	{
		return data;
	}
}

public class TurboLinkedQueue<T>
{
	private QueueNode<T> head;
	public int Count { get; private set; }

	public void Enqueue(T item)
	{		Count++;

		if (head == null)
		{
			head = new QueueNode<T>(item);

			return;
		}
		
	}

	public void Dequeue()
	{
		throw new NotImplementedException();

	}

	public T Peek()
	{
		if (head == null)
		{
			throw new Exception("Exception: The Queue is empty!");
		}
		return head.GetData();

	}

	public void Clear()
	{
		throw new NotImplementedException();
	}
}
