using TurboCollections;

var queue = new TurboQueue<int>();

queue.Enqueue(8);
queue.Enqueue(0);
queue.Enqueue(2);

var returnedItem = queue.Dequeue();

Console.WriteLine("-----DONE-----");