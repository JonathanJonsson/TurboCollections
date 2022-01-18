

using TurboCollections;

var t = new TurboStack<int>();

t.Push(1);
t.Push(2);
t.Push(3);
t.Peek();
t.Pop();
t.Peek();
t.Pop();
Console.WriteLine("--DONE--");