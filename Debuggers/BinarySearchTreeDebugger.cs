using TurboCollections;

 

 
	var TBS = new TurboBinarySearchTree();
	TBS.Insert(1);
	// TBS.Search(1);
		TBS.Insert(2);
	TBS.Insert(-1);
	TBS.Insert(3);
	var g = TBS.Search(3);
	TBS.Delete(3);
	Console.WriteLine("---DONE---");