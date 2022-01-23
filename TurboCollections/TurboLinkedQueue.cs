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
	private QueueNode<T> head;
	private QueueNode<T> tail;

	public int Count { get; private set; }

	public void Enqueue(T item)
	{		Count++;

		var newNode = new QueueNode<T>(item);
		if (tail == null)
		{
			head = tail = newNode;
			return;
		}

		tail.next = newNode;
		tail = newNode;



	}

	public void Dequeue()
	{

		Count--;

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
