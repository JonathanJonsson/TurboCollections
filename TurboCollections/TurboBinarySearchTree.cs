namespace TurboCollections;

public class TurboBinarySearchTree
{
	private Tree root;

	public void Insert(int value)
	{
		// var newNode = new Tree();
		
		if (this.root == null)
		{
			this.root = new Tree();
			this.root.value = value;

			return;
		}

		var newRoot = this.root;
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
				else
				{
					newRoot = newRoot.right;
					
				}
			}
			else
			{
				if (newRoot.left == null)
				{
					newRoot.left = new Tree();
					newRoot.left.value = value;

					break;
				}
				else
				{
					newRoot = newRoot.left;
					
				}
			}
		}
	}

	public Tree Search(int searchVal)
	{
		if (root.value == searchVal)
		{
			return root;
		}

		var newNode = root;

		
		while (newNode != null && searchVal!= newNode.value)
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


	public void Delete(int value)
	{
		
		root = Search(value);

		if (root.right == null || root.left == null)
		{
			root = null;
		}
		// var rootToCheck = Search(value);
		//
		// if (rootToCheck.right == null && rootToCheck.left == null)
		// {
		// 	rootToCheck = null;
		// }
	}
}
public class Tree
{
	public Tree left;
	public Tree right;
	public int value;
}
