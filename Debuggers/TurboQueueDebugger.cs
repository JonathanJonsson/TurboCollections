using TurboCollections;


var queue = new TurboQueue<int>();
       
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);     
queue.Enqueue(5);
queue.Enqueue(6);
queue.Dequeue(); 
queue.Dequeue(); 
queue.Enqueue(7);
queue.Enqueue(8);
queue.Enqueue(9);


queue.Dequeue(); 
queue.Dequeue(); 
queue.Dequeue(); 
queue.Dequeue(); 


Console.WriteLine("-----DONE-----");

