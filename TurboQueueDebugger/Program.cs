using TurboCollections;

var queue = new TurboQueue<int>();
       
queue.Enqueue(111);
queue.Enqueue(666);
queue.Dequeue(); 
queue.Enqueue(222);
queue.Enqueue(333); // Issue is here - when calculating write for the full array it jumps back to write = 0 --> overwrites. Implement Count??
queue.Enqueue(555);

queue.Dequeue();

queue.Enqueue(444);


Console.WriteLine("-----DONE-----");