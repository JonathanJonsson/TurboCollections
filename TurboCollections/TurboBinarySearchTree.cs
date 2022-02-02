namespace TurboCollections;

public class TurboBinarySearchTree
{
	private Tree root;

	#region WITH RECURSION
	public void Insert(int value)
	{
		root = InsertRecursive(root, value);
	}

	private Tree InsertRecursive(Tree root, int value)
	{
		if (root == null)
		{
			root = new Tree();
			root.value = value;

			return root;
		}

		if (value > root.value)
		{
			root.right = InsertRecursive(root.right, value);
		}
		else
		{
			root.left = InsertRecursive(root.left, value);
		}

		return root;
	}

	public Tree Search(int searchValue)
	{
		var tempRoot = root;
		tempRoot = SearchRec(tempRoot, searchValue);

		return tempRoot;
	}

	private Tree SearchRec(Tree root, int searchVal)
	{
		if (root.value == searchVal || root == null)
		{
			return root;
		}

		if (searchVal > root.value)
		{
			return SearchRec(root.right, searchVal);
		}

		return SearchRec(root.left, searchVal);
	}

	public void Delete(int value)
	{
		DeleteRec(root, value);
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
			{var temp = root.right;

				while (temp.left != null)
				{
					temp = temp.left;
				}

				root.value = temp.value;
				DeleteRec(root.right, temp.value);
				
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
		} else if (value > root.value)
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

	public void DeleteIterative(int value)
	{
			
	
	}
	#endregion
}
public class Tree
{
	public Tree left;
	public Tree right;
	public int value;
}
