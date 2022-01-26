using TurboCollections;


var list = new TurboList<int>();
Random r = new Random();
for (int i = 0; i < 10; i++)
{
	list.Add(r.Next(0,101));
}

TurboSort.TurboSelectionSort(list);

Console.WriteLine("---Done---");