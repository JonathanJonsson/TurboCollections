using System.Diagnostics;
using TurboCollections;

var BSTRecMethods = new TurboBinarySearchTree();
var BSTIterativeMethods = new TurboBinarySearchTree();
// var stopwatch = new Stopwatch();
//
// stopwatch.Start();
// BSTIterativeMethods.InsertIterative(1);
// BSTIterativeMethods.InsertIterative(2);
// BSTIterativeMethods.InsertIterative(-1);
// BSTIterativeMethods.InsertIterative(3);
// stopwatch.Stop();
// Console.WriteLine("Iterative insert time: " + stopwatch.Elapsed);
// stopwatch.Reset();
//
// stopwatch.Start();
// BSTRecMethods.Insert(1);
// BSTRecMethods.Insert(2);
// BSTRecMethods.Insert(-1);
// BSTRecMethods.Insert(3);
// stopwatch.Stop();
// Console.WriteLine("Recursive insert time: " + stopwatch.Elapsed);
// stopwatch.Reset();
//
// Console.WriteLine("------------------------");
// stopwatch.Start();
//
// var subtreeIt = BSTIterativeMethods.SearchIterative(2);
// stopwatch.Stop();
// Console.WriteLine("Iterative search time: " + stopwatch.Elapsed);
// stopwatch.Reset();
//
// stopwatch.Start();
// var subTreeRec = BSTRecMethods.Search(2);
// stopwatch.Stop();
// Console.WriteLine("Recursive search time: " + stopwatch.Elapsed);
// stopwatch.Reset();
BSTIterativeMethods.InsertIterative(7);
BSTIterativeMethods.InsertIterative(2);
BSTIterativeMethods.InsertIterative(0);
BSTIterativeMethods.InsertIterative(3);
BSTIterativeMethods.InsertIterative(4);
BSTIterativeMethods.InsertIterative(11);
BSTIterativeMethods.InsertIterative(8);
BSTIterativeMethods.InsertIterative(15);
BSTIterativeMethods.GetInOrder();



// BSTIterativeMethods.Delete(5);
// BST.Search(1);
// var subTree = BST.SearchIterative(2);
// var subTreeValue = subTree.value;
// subTree.value = 10; //--feels bad that main tree is changed here
// var subTreeValueChange = subTree.value;
Console.WriteLine("---DONE---");
