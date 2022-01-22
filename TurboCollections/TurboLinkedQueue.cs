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
	public void Enqueue(T item)
	{
		throw new NotImplementedException();
	}

	public void Dequeue()
	{
		throw new NotImplementedException();

	}

	public void Peek()
	{
		throw new NotImplementedException();

	}

	public void Clear()
	{
		throw new NotImplementedException();
	}
}
