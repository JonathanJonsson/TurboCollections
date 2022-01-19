using TurboCollections;

var queue = new TurboQueue<int>();

queue.Enqueue(111);
queue.Enqueue(666);
queue.Dequeue();
queue.Enqueue(222);
queue.Enqueue(333);
queue.Enqueue(555);

queue.Dequeue();

queue.Enqueue(444);

Console.WriteLine("-----DONE-----");