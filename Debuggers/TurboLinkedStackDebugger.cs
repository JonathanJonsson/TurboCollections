using TurboCollections;

var linkedStack = new TurboLinkedStack<int>();

linkedStack.Push(1);
linkedStack.Push(2);
linkedStack.Push(3);
linkedStack.Pop();
linkedStack.Push(4);
linkedStack.Clear();

// linkedStack.Yeet();

Console.WriteLine("---DONE---");