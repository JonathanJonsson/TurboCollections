using TurboCollections;

var linkedStack = new TurboLinkedStack<int>();

linkedStack.Push(1);
linkedStack.Push(2);
linkedStack.Peek();
linkedStack.Push(3);

// linkedStack.Yeet();

linkedStack.LoopThroughListTest();
Console.WriteLine("---DONE---");