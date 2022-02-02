using TurboCollections;

 

 
	var BST = new TurboBinarySearchTree();

	BST.Insert(1);
	BST.Insert(2);
	BST.Insert(-1);
	BST.Insert(3);
	
	// BST.SearchIterative(2);
	var subTree = BST.Search(2);
	
	
	
	// BST.Search(1);
	// var subTree = BST.SearchIterative(2);
	// var subTreeValue = subTree.value;
	// subTree.value = 10; //--feels bad taht main tree is changed here
	// var subTreeValueChange = subTree.value;
	Console.WriteLine("---DONE---");