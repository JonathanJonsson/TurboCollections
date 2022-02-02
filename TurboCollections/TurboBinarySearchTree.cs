namespace TurboCollections;

public class TurboBinarySearchTree
{
	public Tree root; //temp public for tests

	#region WITH RECURSION
	public void Insert(int value)
	{
		root = InsertRecursive(root, value);
	}

	private Tree InsertRecursive(Tree node, int value)
	{
		//if the root is null --> create new Node
		if (node == null)
		{
			node = new Tree();
			node.value = value;

			return node;
		}
		
		//if value > node value --> go to the right
		if (value > node.value)
		{
			node.right = InsertRecursive(node.right, value);
		}
		else // go to left
		{
			node.left = InsertRecursive(node.left, value);
		}

		return node;
	}

	public Tree Search(int searchValue)
	{
		var tempRoot = root;
		tempRoot = SearchRec(tempRoot, searchValue);

		return tempRoot;
	}

	private Tree SearchRec(Tree root, int searchVal)
	{
		if (root == null||root.value == searchVal )
		{
			return root;
		}

		if (searchVal > root.value)
		{
			//pass in right node to "continue searching from the node to the right of the current one"
			return SearchRec(root.right, searchVal);
		}
		//if not right was chosen --> choose left
		return SearchRec(root.left, searchVal);
	}

	public void Delete(int value)
	{
		DeleteRec(root, value);
	}
	private Tree GoLeftToMaxValue(Tree node)
	{
		while (node.left != null)
		{
			node = node.left;
		}
		return node;
	}
	private Tree DeleteRec(Tree root, int value)
	{

		if (root == null)
		{
			return root;
		}
		
		if (value == root.value)
		{
			//If leaf
			if (root.left == null && root.right == null)
			{
				root = null;
			}
			//2 child node
			else if (root.right != null && root.left != null)
			{
					var tempRoot = GoLeftToMaxValue(root.right);
						//copy the value
						root.value = tempRoot.value;
						root.right = DeleteRec(root.right, tempRoot.value);
			}
			//1 child nodes
			else
			{
				if (root.left != null)
				{
					var child = root.left;
					root = child;
				}
				else
				{
					var child = root.right;
					root = child;
				}
			}
			//value != root.value
		}
		else if (value > root.value)
		{
			root.right = DeleteRec(root.right, value);
		}
		else
		{
			root.left = DeleteRec(root.left, value);
		}
		
		return root;
	}
	#endregion

	#region WITHOUT RECURSION (No delete implemented cause it is kicking my ass for some reason)
	public void InsertIterative(int value)
	{
		// var newNode = new Tree();

		if (root == null)
		{
			root = new Tree();
			root.value = value;

			return;
		}

		var newRoot = root;

		while (newRoot != null)
		{
			if (value > newRoot.value)
			{
				if (newRoot.right == null)
				{
					newRoot.right = new Tree();
					newRoot.right.value = value;

					break;
				}

				newRoot = newRoot.right;
			}
			else
			{
				if (newRoot.left == null)
				{
					newRoot.left = new Tree();
					newRoot.left.value = value;

					break;
				}

				newRoot = newRoot.left;
			}
		}
	}

	public Tree SearchIterative(int searchVal)
	{
		if (root.value == searchVal)
		{
			return root;
		}

		var newNode = root;

		while (newNode != null && searchVal != newNode.value)
		{
			if (searchVal > newNode.value)
			{
				//Goto right subtree
				newNode = newNode.right;
			}
			else
			{
				//goto left subtree
				newNode = newNode.left;
			}
		}

		if (newNode != null)
		{
			return newNode;
		}

		return null;
	}
	//
	// public void DeleteIterative(int value)
	// {
	// }
	#endregion

	public void GetInOrder()
	{
		GetEnumerator(root);
	}

	public void GetReversedOrder()
	{
		GetReversedOrder(root);
	}
	private void GetReversedOrder(Tree node)
	{
		if (node == null)
		{
			return;
		}
		
		GetReversedOrder(node.right);
		Console.WriteLine(node.value);
		GetReversedOrder(node.left);
		
	}
	private void GetEnumerator(Tree node)
	{
		if (node == null)
		{
			return;
		}

		GetEnumerator(node.left);
		Console.WriteLine(node.value);
		GetEnumerator(node.right);
	}
}
public class Tree
{
	public Tree left;
	public Tree right;
	public int value;
}
