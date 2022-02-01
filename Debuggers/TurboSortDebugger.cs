// using System.Diagnostics;
// using TurboCollections;
//
// var numberOfListAdditions = 10000;
// var randomListForSelectionSort = new TurboList<int>();
// var randomListForQuickSort = new TurboList<int>();
// var reversedListForSelectionSort = new TurboList<int>();
// var reversedListForQuickSort = new TurboList<int>();
// var sortedListForSelectionSort = new TurboList<int>();
// var sortedListForQuickSort = new TurboList<int>();
// var r = new Random();
//
// #region List Generation
// for (var i = 0; i < numberOfListAdditions; i++)
// {
// 	var randomNum = r.Next(0, 101);
// 	randomListForSelectionSort.Add(randomNum);
// 	randomListForQuickSort.Add(randomNum);
// }
//
// for (var i = numberOfListAdditions; i > 0; i--)
// {
// 	reversedListForSelectionSort.Add(i);
// 	reversedListForQuickSort.Add(i);
// }
//
// for (var i = 0; i < numberOfListAdditions; i++)
// {
// 	sortedListForQuickSort.Add(i);
// 	sortedListForSelectionSort.Add(i);
// }
// #endregion
//
// var stopwatch = new Stopwatch();
//
// #region RandomList - QuickSort
// Console.WriteLine();
// Console.WriteLine("---Starting time logging - Quicksort---");
// stopwatch.Start();
// TurboQuickSorting.TurboQuickSort(randomListForSelectionSort,0, randomListForQuickSort.Count-1);
// stopwatch.Stop();
// ReportTime(stopwatch, "Random list", "Quick sort");
// stopwatch.Reset();
// #endregion
//
// Console.WriteLine();
//
// #region Reversed - QuickSort
// stopwatch.Start();
// TurboQuickSorting.TurboQuickSort(reversedListForQuickSort,0, randomListForQuickSort.Count-1);
// stopwatch.Stop();
// ReportTime(stopwatch, "Reversed list", "Quick sort");
// stopwatch.Reset();
// #endregion
//
// Console.WriteLine();
//
// #region Reversed - QuickSort
// stopwatch.Start();
// TurboQuickSorting.TurboQuickSort(sortedListForQuickSort,0, randomListForQuickSort.Count-1);
// stopwatch.Stop();
// ReportTime(stopwatch, "Sorted list", "Quick sort");
// stopwatch.Reset();
// #endregion
//
//
// Console.WriteLine();
// Console.WriteLine("----------------------------------------------------------------------");
// Console.WriteLine();
//
// #region RandomList - selectionsort
// Console.WriteLine();
// Console.WriteLine("---Starting time logging - SelectionSort---");
// stopwatch.Start();
// TurboSelectionSorting.TurboSelectionSort(randomListForSelectionSort);
// stopwatch.Stop();
// ReportTime(stopwatch, "Random list", "Selection sort");
// stopwatch.Reset();
// #endregion
//
// Console.WriteLine();
//
// #region ReversedList - selectionsort
// stopwatch.Start();
// TurboSelectionSorting.TurboSelectionSort(reversedListForSelectionSort);
// stopwatch.Stop();
// ReportTime(stopwatch, "Reversed list", "Selection sort");
// stopwatch.Reset();
// #endregion
//
// Console.WriteLine();
//
// #region SortedList - selectionsort
// stopwatch.Start();
// TurboSelectionSorting.TurboSelectionSort(sortedListForSelectionSort);
// stopwatch.Stop();
// ReportTime(stopwatch, "sorted array", "Selection sort");
// stopwatch.Reset();
// #endregion
//
// Console.WriteLine();
//
//
// Console.WriteLine("---Done---");
//
// void ReportTime(Stopwatch _stopwatch, string _listName, string _sortingMethod)
// {
// 	var ts = _stopwatch.Elapsed;
// 	var elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds/10);
// 	Console.WriteLine($"RunTime for {_listName} using {_sortingMethod} " + elapsedTime);
// }
