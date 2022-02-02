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

	[Test]
	public void SearchForMissingNumberReturnsNull()
	{
		var BST = new TurboBinarySearchTree();
		BST.Insert(5);
		BST.Insert(2);
		BST.Insert(10);
		
		Assert.Null(BST.Search(1));
	}
	[Test]
	public void SearchingForPresentNumberReturnsRootWithCorrectValue()
	{
		var BST = new TurboBinarySearchTree();
		BST.Insert(5);
		BST.Insert(2);
		BST.Insert(10);
		
		Assert.AreEqual(10,BST.Search(10).value); //Search().value since search return a root
		
	}

	[Test]
	public void DeleteLeafNode()
	{
		var BST = new TurboBinarySearchTree();
		BST.Insert(5);
		BST.Insert(2);
		BST.Insert(10);
		BST.Delete(10);
		Assert.IsNull(BST.Search(10));
	}

	[Test]
	public void DeleteNodeWithOneChild()
	{
		var BST = new TurboBinarySearchTree();

		BST.Insert(5);
		BST.Insert(2);
		BST.Insert(10);
		BST.Insert(9);
		BST.Delete(10);
		Assert.IsNull(BST.Search(10));
		Assert.AreEqual(9, BST.Search(9).value);
 
	}

	
	
	
	
}
