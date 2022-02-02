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
	
}
