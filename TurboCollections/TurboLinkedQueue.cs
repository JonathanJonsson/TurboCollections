namespace TurboCollections;
public class QueueNode<U>
{
	private U data;
	public QueueNode<U> next;
		 
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
	private QueueNode<T> frontQueueNode;
	private QueueNode<T> backQueueNode;

	public int Count { get; private set; }

	public void Enqueue(T item)
	{		Count++;

		var newNode = new QueueNode<T>(item);
		if (backQueueNode == null)
		{
			frontQueueNode = backQueueNode = newNode;
			return;
		}

		backQueueNode.next = newNode;
		backQueueNode = newNode;

	}

	public T Dequeue()
	{
		
		Count--;
		var frontObject = frontQueueNode.GetData();

		while (frontQueueNode.next != null)
		{
			frontQueueNode = frontQueueNode.next;
		}
		
		
		return frontObject;
	}

	public T Peek()
	{
		if (frontQueueNode == null)
		{
			throw new Exception("Exception: The Queue is empty!");
		}
		return frontQueueNode.GetData();

	}

	public void Clear()
	{
		throw new NotImplementedException();
	}
}
