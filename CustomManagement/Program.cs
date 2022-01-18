

using TurboCollections;

var list = new TurboList<int>();

list.Add(5);
list.Add(3);
list.Add(1);
Console.WriteLine(list.Count);
list.RemoveAt(0);
list.Add(100);
list.RemoveAt(0);
list.Add(50);
list.RemoveAt(1);
// var t = new TurboStack<int>();
//
// t.Push(1);
// t.Push(2);
// t.Push(3);
// t.Peek();
// t.Pop();
// t.Peek();
// t.Pop();
Console.WriteLine("--DONE--");