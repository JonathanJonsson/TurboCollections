using TurboCollections;



	var hashSet = new TurboHashSet<string>();
	// var hashSet = new TurboHashSet<int>();


	// var y = "A";
	// var X = "B";
	// Console.WriteLine(X.GetHashCode());
	// Console.WriteLine((uint)X.GetHashCode());
	// Console.WriteLine(y.GetHashCode());
	// Console.WriteLine((uint)y.GetHashCode());
	// Console.WriteLine(X.GetHashCode()%10);
	// Console.WriteLine(y.GetHashCode()%10);
	// Console.WriteLine((uint)X.GetHashCode()%10);
	// Console.WriteLine((uint)y.GetHashCode()%10);
	//
	hashSet.Insert("Aa");
	hashSet.Insert("Be");
	hashSet.Insert("Ce");
	hashSet.Insert("De");
	hashSet.Insert("Ee");
	hashSet.Insert("Aa");

	hashSet.Exists("Qu");
	hashSet.Exists("Aa");
	
	// hashSet.Insert(1);
	// hashSet.Insert(2);
	// hashSet.Insert(3);
	// hashSet.Insert(4);
	// hashSet.Insert(5);

	Console.WriteLine("---Done---");
	
