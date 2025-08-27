using System;
using System.Collections;

namespace Session_02
{
    internal class Program
    {
        #region Methods
        public static int SumArrayList(ArrayList array)
        {
            int Sum = 0;
            if (array?.Count > 0)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    Sum = Sum + (int?)array[i] ?? 0;
                }
            }
            return Sum;
        }

        public static int SumList(List<int> array)
        {
            int Sum = 0;
            if (array?.Count > 0)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    Sum = Sum + array[i];
                }
            }
            return Sum;
        }

        #endregion

        static void Main(string[] args)
        {

            //------------------------------------- Vedio 03 ---------------------------------------
            #region Non - Generic Collctions - Array List
            //ArrayList arrayList = new ArrayList();

            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");// 0 , 0

            #region Add Elements
            //arrayList.Add(1);//Boxing
            //                 // Add new Element using Add() , Adding At End of the ArrayList

            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");// 4 , 1

            //arrayList.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");// 4 , 4

            //arrayList.Add(5);
            //arrayList.Add(6);
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}");// 8 , 5

            //arrayList.AddRange(new int[] { 6, 7, 8, 9 });
            ////Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 16 , 9

            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            //------------------------------------- Vedio 04 ---------------------------------------
            #region Insert Element
            //arrayList.Insert(1, 10); // Boxing
            //Console.WriteLine("////////////////////////");
            //foreach (int i in arrayList) // unboxing
            //{
            //    Console.WriteLine(i);
            //}

            ////arrayList.Insert(7, 200); // ArgumentOutOfRangeException

            //arrayList.InsertRange(2, new int[] { 20, 30 });
            //Console.WriteLine("////////////////////////");
            //foreach (int i in arrayList) // unboxing
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}"); // 8 , 8

            #endregion

            #region Trim
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8 , 6

            //arrayList.TrimToSize();
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8 , 6

            //arrayList.Add(100);
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 12 , 7

            #endregion

            #region Remove()
            //Console.WriteLine($"{arrayList.Capacity}, {arrayList.Count}"); // 12, 7

            //arrayList.Add(1);
            //foreach (int i in arrayList) // 1, 2, 3, 4, 5, 6, 100, 1
            //{
            //    Console.WriteLine(i);
            //}

            //arrayList.Remove(1);
            //Console.WriteLine("////////////////////////");
            //foreach (int i in arrayList) // 1, 2, 3, 4, 5, 6, 100
            //{
            //    Console.WriteLine(i);
            //} 

            #endregion

            #region Contains
            //int FirstElement = (int?)arrayList[0] ?? 0;

            //bool flag = arrayList.Contains(1000);
            //Console.WriteLine(flag);
            #endregion

            #region 3 Constructors in ArrayList
            //arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8, 5

            //arrayList = new ArrayList(10);
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 10, 0
            //arrayList.AddRange(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 10, 5

            //arrayList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"{arrayList.Capacity} , {arrayList.Count}"); // 8, 5

            #endregion

            //arrayList = new ArrayList(5);
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            ////arrayList.Add("Route"); // InvalidCastException
            ////Console.WriteLine(SumArrayList(arrayList));

            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            //------------------------------------- Vedio 05 ---------------------------------------
            #region Generic Collections - List
            //List<int> list = new List<int>();
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 0 , 0

            #region Add Elements
            //list.Add(1);
            //Console.WriteLine($"{list.Capacity}, {list.Count}"); // 4 , 1

            ////list.AddRange(new int[] { 2, 3, 4 });
            //list.AddRange(2, 3, 4 );
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 4 , 4

            //list.Add(5);
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 8 , 5

            #endregion

            #region Insert()
            //list.InsertRange(1, new int[] { 20, 30, 40 });

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Trim
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 8 , 5

            //list.TrimExcess();

            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 5 , 5
            //list.Add(10);
            //Console.WriteLine($"{list.Capacity} , {list.Count}"); // 10 , 6

            #endregion

            #region Remove
            //Console.WriteLine($"{list.Capacity}, {list.Count}");
            //foreach (int i in list)
            //    Console.WriteLine(i);

            //list.Remove(1);
            //list.RemoveAt(4);
            //list.RemoveRange(0, 2);
            //Console.WriteLine("////////////////////////");
            //foreach (int i in list)
            //    Console.WriteLine(i);

            #endregion

            #region Constains
            //int FirstElemnet = list[0];

            //bool flag = list.Contains(111);
            //Console.WriteLine(flag);

            #endregion

            #region 3 Constructors in list
            //list = new List<int>() { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"list.Capacity}, {list.Count}"); // 8, 5

            //list = new List<int>(10);
            //Console.WriteLine($"list.Capacity, {list.Count}"); // 10, 5

            //list = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"list.Capacity, {list.Count}"); // 5, 5

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //list[0] = 100;
            //Console.WriteLine(list[0]);

            //list[10] = 200;

            #endregion

            #region EnsureCapacity
            //list = new List<int>(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine(list.Capacity); // 5

            //list.EnsureCapacity(10);
            //Console.WriteLine(list.Capacity); // 10

            //list.EnsureCapacity(11);
            //Console.WriteLine(list.Capacity); // 20 

            #endregion

            #region ReadOnlyCollection
            //list = new List<int>(10) { 1, 2, 3, 4, 5 };
            //list.Add(10);
            //list.AddRange(new int[] { 20, 30, 40, 50, 60 });

            //System.Collections.ObjectModel.ReadOnlyCollection<int> ReadOnlyNumbers = list.AsReadOnly<int>();

            //ReadOnlyNumbers[0] = 100; 

            #endregion

            #region BinarySearch
            //list = new List<int>(10) { 3, 5, 1, 6, 8, 2 };
            //// 1, 2, 3, 5, 6, 8
            //// 1 2 3      5 6 8

            //int index = list.BinarySearch(100);

            //Console.WriteLine(index);

            #endregion

            #region Clear
            //list = new List<int>(10) { 3, 5, 1, 6, 8, 2 };
            //Console.WriteLine($"{list.Capacity}, {list.Count}"); // 10, 6
            //list.Clear();
            //Console.WriteLine($"{list.Capacity}, {list.Count}"); // 10, 0

            #endregion

            #region GetRange
            //list = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> list02 = list.GetRange(0, 3);
            //foreach (int item in list02)
            //    Console.WriteLine(item); 

            #endregion

            #region IndexOf
            //list = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int index = list.IndexOf(10);
            //Console.WriteLine(index); 

            #endregion

            #region IndexOf
            //list = new List<int>(10) { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //      int index = list.LastIndexOf(10);
            //      Console.WriteLine(index); 

            #endregion

            #region CopyTo
            //list = new List<int>(10) { 1, 2, 3, 4 };

            //int[] arr = new int[5]; // 0 0 0 0 0

            //list.CopyTo(arr);

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //} 

            #endregion

            #endregion

            //------------------------------------- Vedio 06 ---------------------------------------
            #region Generic Collections - Linked List
            //LinkedList<int> linkedList = new LinkedList<int>();
            //LinkedListNode<int> FirstNode = linkedList.AddFirst(10);
            //LinkedListNode<int> SecondNode = linkedList.AddFirst(20);
            //LinkedListNode<int> Node = new LinkedListNode<int>(30);

            //linkedList.AddFirst(Node);

            //// prev  | Data | Next
            //// Ref() |  10  | Ref()

            ////foreach(int item in linkedList)
            ////    Console.WriteLine(item);

            //LinkedListNode<int> Node02 = new LinkedListNode<int>(100);

            //linkedList.AddAfter(SecondNode, Node02);

            //foreach (int item in linkedList)
            //    Console.WriteLine(item);

            //Console.WriteLine(linkedList.Count());

            //LinkedListNode<int>? FNode = linkedList?.First;
            //LinkedListNode<int>? LNode = linkedList?.Last;

            ////Console.WriteLine(FNode?.Value);
            ////Console.WriteLine(FNode?.ValueRef);

            ////LinkedListNode<int>? PrevNode = FNode?.Previous;
            ////Console.WriteLine(PrevNode.Value);

            //LinkedList<int>? NewList = Node.List;

            //foreach (int item in NewList)
            //    Console.WriteLine(item);

            #endregion

            //------------------------------------- Vedio 07 ---------------------------------------
            #region Stack
            //Stack<int> stack = new Stack<int>();

            //Console.WriteLine($"{stack.Capacity} , {stack.Count}"); // 0 , 0

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            ////Console.WriteLine($"{stack.Capacity} , {stack.Count}"); // 4 , 4

            //stack.Push(5);

            ////Console.WriteLine($"{stack.Capacity} , {stack.Count}"); // 8 , 5

            //foreach (int i in stack)
            //    Console.WriteLine(i);
            //Console.WriteLine("/////////////////");

            ////int top = stack.Pop();
            ////top = stack.Pop();
            ////top = stack.Pop();
            ////top = stack.Pop();
            ////top = stack.Pop(); // InvalidOpeerationException

            //stack.TryPop(out int top);
            //Console.WriteLine(top);

            //Console.WriteLine("/////////////////");

            //foreach (int i in stack)
            //    Console.WriteLine(i);

            #endregion

            //------------------------------------- Vedio 08 ---------------------------------------
            #region Queue
            //Queue<int> queue = new Queue<int>();
            //Console.WriteLine($"{queue.Capacity} , {queue.Count}");

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //Console.WriteLine($"{queue.Capacity} , {queue.Count}");

            ////int First =  queue.Dequeue();
            ////First =  queue.Peek();
            ////Console.WriteLine(First);

            //Console.WriteLine("//////////////");

            //foreach (int i in queue)
            //    Console.WriteLine(i);

            #endregion


        }
    }
}
