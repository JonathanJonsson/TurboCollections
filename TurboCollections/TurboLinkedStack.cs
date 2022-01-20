namespace TurboCollections;

public class TurboLinkedStack<T>
{
	public Node<T> head;
	
	
	
	
	public void Push(T item)
	{
		head = new Node<T>(item, head);

	}

	public T Peek()
	{
		throw new NotImplementedException();
	}

	public T Yeet()
	{
		throw new NotImplementedException();
	}


	public void Clear()
	{
		throw new NotImplementedException();
	}

	public class Node<U>
	{
		private U data;
		private Node<U> next;

		public Node(U _data) // first element
		{
			data = _data;
		}

		public Node(U _data, Node<U> _next) // for subsequent elements
		{
			data = _data;
			next = _next;
		}
	}
}