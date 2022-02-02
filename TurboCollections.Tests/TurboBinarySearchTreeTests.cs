using NUnit.Framework;

namespace TurboCollections.Tests;
 
public class TurboBinarySearchTreeTests
{

	[Test]
	public void AddingOneNodeMeansTwoNullChildren()
	{
		var BST = new TurboBinarySearchTree();
		BST.Insert(1);
		
		Assert.IsNull(BST.root.left);
		Assert.IsNull(BST.root.right);
	}

	[Test]
	public void HigherNumbersGoesToTheRightWhileLowerToTheLeft()
	{
		var BST = new TurboBinarySearchTree();
		BST.Insert(5);
		BST.Insert(2);
		BST.Insert(10);
		
		Assert.AreEqual(10, BST.root.right.value);
		Assert.AreEqual(2, BST.root.left.value);
	}
	
}
