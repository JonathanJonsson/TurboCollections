namespace TurboCollections;

public class Node<U>
{
	private U data;
	public Node<U> next;
		 
	public Node(U _data)
	{
		data = _data;
		next = null;
	}

	public U GetData()
	{
		return data;
	}
}

public class TurboLinkedStack<T>
{
	private Node<T> head;
	public int Count { get; private set; } = 0;
	
	public void Push(T item)
	{
		Count++;
		
		if (head == null)
		{
			head = new Node<T>(item);
			return;
		}
		
		var newNode = new Node<T>(item);
		newNode.next = head;

		head = newNode;
	}

	
	public T Peek()
	{
		if (Count < 0)
		{
			throw new Exception("Exception: Trying to peek at empty linked stack but it is empty!");
		}
		return head.GetData();
	}
	
	public T Pop()
	{

		if (head == null)
		{
			throw new Exception("Error: Empty stack!");
		}

		var topNode = head;
		head = head.next;
		Count--;
		return topNode.GetData();
		 
	}


	public void Clear()
	{
		throw new NotImplementedException();
	}
}