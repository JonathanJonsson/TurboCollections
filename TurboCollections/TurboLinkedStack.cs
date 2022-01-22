namespace TurboCollections;

public class StackNode<U>
{
	private U data;
	public StackNode<U> next;
		 
	public StackNode(U _data)
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
	private StackNode<T> head;
	public int Count { get; private set; } = 0;
	
	public void Push(T item)
	{
		Count++;
		
		if (head == null)
		{
			head = new StackNode<T>(item);
			return;
		}
		
		var newNode = new StackNode<T>(item);
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
		while (head != null)
		{
			var prev = head.next;
			head = null;
			head = prev;
		}

		Count = 0;
	}
}