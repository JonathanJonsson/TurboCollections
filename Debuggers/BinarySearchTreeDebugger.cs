using TurboCollections;

 

 
	var TBS = new TurboBinarySearchTree();
	TBS.InsertIterative(1);
	TBS.SearchIterative(1);
	TBS.InsertIterative(2);
	TBS.InsertIterative(-1);
	TBS.InsertIterative(3);
	TBS.SearchIterative(3);
	TBS.DeleteIterative(3);
	Console.WriteLine("---DONE---");