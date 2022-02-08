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
	hashSet.Insert("Bb");
	hashSet.Insert("Cc");
	hashSet.Insert("Dd");
	hashSet.Insert("Ee");
	hashSet.Insert("Aa");
	hashSet.Remove("Bb");
	hashSet.Exists("Bb");
	hashSet.Exists("Aa");
	
	// hashSet.Insert(1);
	// hashSet.Insert(2);
	// hashSet.Insert(3);
	// hashSet.Insert(4);
	// hashSet.Insert(5);

	Console.WriteLine("---Done---");
	
