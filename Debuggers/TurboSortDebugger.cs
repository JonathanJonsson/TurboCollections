using TurboCollections;


var list = new TurboList<int>();

list.Add(1);
list.Add(3);
list.Add(2);

TurboSort.TurboSelectionSort(list);