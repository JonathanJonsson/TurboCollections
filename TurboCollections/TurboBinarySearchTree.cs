namespace TurboCollections;

public class TurboBinarySearchTree
{
	public Tree root;
	
	#region WITHOUT RECURSION (No delete implemented cause it is kicking my ass for some reason
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
