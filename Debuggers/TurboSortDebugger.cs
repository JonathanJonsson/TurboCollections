using System.Diagnostics;
using TurboCollections;

int numberOfListAdditions = 10000;
var randomList = new TurboList<int>();
var reversedList = new TurboList<int>();
var sortedList = new TurboList<int>();

Random r = new Random();

#region Array Generation
for (int i = 0; i < numberOfListAdditions; i++)
{
	randomList.Add(r.Next(0,101));
}

for (int i = numberOfListAdditions; i > 0; i--)
{
	reversedList.Add(i);
}

for (int i = 0; i < numberOfListAdditions; i++)
{
	sortedList.Add(i);
}
#endregion


Stopwatch stopwatch = new Stopwatch();




#region RandomArray
stopwatch.Start();
TurboSort.TurboSelectionSort(randomList);
stopwatch.Stop();
ReportTime(stopwatch, "Random array", "Selection sort");
stopwatch.Reset();
#endregion

Console.WriteLine();

#region ReversedArray
stopwatch.Start();
TurboSort.TurboSelectionSort(reversedList);
stopwatch.Stop();
ReportTime(stopwatch, "Reversed array", "Selection sort");
stopwatch.Reset();
#endregion

Console.WriteLine();

#region SortedList
stopwatch.Start();
TurboSort.TurboSelectionSort(sortedList);
stopwatch.Stop();
ReportTime(stopwatch, "sorted array", "Selection sort");
stopwatch.Reset();
#endregion



Console.WriteLine("---Done---");

void ReportTime(Stopwatch _stopwatch, string listName, string sortingMethod)
{
	TimeSpan ts = _stopwatch.Elapsed;
	string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds/10);
	Console.WriteLine($"RunTime for {listName} using {sortingMethod} " + elapsedTime);
}