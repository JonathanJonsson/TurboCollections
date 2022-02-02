using System.Diagnostics;
using TurboCollections;

var BSTRecMethods = new TurboBinarySearchTree();
var BSTIterativeMethods = new TurboBinarySearchTree();
var stopwatch = new Stopwatch();
Console.WriteLine();
stopwatch.Start();
BSTIterativeMethods.InsertIterative(7);
BSTIterativeMethods.InsertIterative(2);
BSTIterativeMethods.InsertIterative(0);
BSTIterativeMethods.InsertIterative(3);
BSTIterativeMethods.InsertIterative(4);
BSTIterativeMethods.InsertIterative(11);
BSTIterativeMethods.InsertIterative(8);
BSTIterativeMethods.InsertIterative(15);
stopwatch.Stop();
Console.WriteLine("Iterative insert time: " + stopwatch.Elapsed);
stopwatch.Reset();

stopwatch.Start();
BSTRecMethods.Insert(7);
BSTRecMethods.Insert(2);
BSTRecMethods.Insert(0);
BSTRecMethods.Insert(3);
BSTRecMethods.Insert(4);
BSTRecMethods.Insert(11);
BSTRecMethods.Insert(8);
BSTRecMethods.Insert(15);
stopwatch.Stop();
Console.WriteLine("Recursive insert time: " + stopwatch.Elapsed);
stopwatch.Reset();

Console.WriteLine("------------------------");
stopwatch.Start();

var subtreeIt = BSTIterativeMethods.SearchIterative(1);
stopwatch.Stop();
Console.WriteLine("Iterative search time: " + stopwatch.Elapsed);
stopwatch.Reset();

stopwatch.Start();
var subTreeRec = BSTRecMethods.Search(11);
stopwatch.Stop();
Console.WriteLine("Recursive search time: " + stopwatch.Elapsed);
stopwatch.Reset();
Console.WriteLine("-------------------------");
 
BSTIterativeMethods.GetInOrder();
Console.WriteLine("-------------------------");
BSTIterativeMethods.GetReversedOrder();

Console.WriteLine("-------------------------");


BSTIterativeMethods.Delete(11); // bugged delete function!

BSTIterativeMethods.GetInOrder();
Console.WriteLine("-------------------------");
BSTIterativeMethods.GetReversedOrder();




// BSTIterativeMethods.Delete(5);
// BST.Search(1);
// var subTree = BST.SearchIterative(2);
// var subTreeValue = subTree.value;
// subTree.value = 10; //--feels bad that main tree is changed here
// var subTreeValueChange = subTree.value;
Console.WriteLine("---DONE---");
