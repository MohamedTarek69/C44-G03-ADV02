using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_02
{
    internal class Program
    {
        #region Methods
        public static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        public static bool CheckParentheses(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in str)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();

                    if ((ch == ')' && top != '(') || (ch == ']' && top != '[') || (ch == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        public static int[] RemoveDuplicates(int[] arr)
        {
            List<int> result = new List<int>();

            foreach (int num in arr)
            {
                if (!result.Contains(num))
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }

        public static ArrayList RemoveOddNumbers(ArrayList arr)
        {
            if(arr.Count > 0 && arr is not null)
            {
                ArrayList result = new ArrayList();
                foreach (int item in arr)
                {
                    if (item % 2 == 0)
                    {
                        result.Add(item);
                    }
                }

                return result;
            }
            else
            {
                return new ArrayList();
            }
            
        }

        public static void PushOntoStack(Stack stack, int[] numbers)
        {
            foreach (int num in numbers)
            {
                stack.Push(num);
            }
        }

        public static void FindTarget(Stack stack, int target)
        {
            int count = 0;
            bool found = false;

            foreach (int item in stack)
            {
                count++;
                if (item == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count- 1}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Target was not found");
            }
        }

        public static ArrayList FindSublistWithSumUpToTarget(ArrayList arr, int target)
        {
            int start = 0, sum = 0;

            for (int end = 0; end < arr.Count; end++)
            {
                sum += (int)arr[end];

                while (sum > target && start <= end)
                {
                    sum -= (int)arr[start];
                    start++;
                }

                if (sum == target)
                {
                    ArrayList sublist = new ArrayList();
                    for (int i = start; i <= end; i++)
                        sublist.Add(arr[i]);
                    return sublist;
                }
            }
            return null;
        }

        public static void ReverseFirstKInQueue(Queue<int> q, int k)
        {
            Stack<int> st = new Stack<int>();

            for (int i = 0; i < k; i++)
                st.Push(q.Dequeue());

            while (st.Count > 0)
                q.Enqueue(st.Pop());

            int size = q.Count;
            for (int i = 0; i < size - k; i++)
                q.Enqueue(q.Dequeue());
        }

        #endregion

        static void Main(string[] args)
        {
            #region Q1)
            //Given an array consists of numbers with size N and number of queries,
            //in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X
            //Ex:
            //Input
            //3 3                    //Size of array , number of queries
            //11 5 3             //Array 
            //1                      //Query1
            //5                     //Query2
            //13                  //Query 3
            //Output
            //3                   //11,5,3
            //1                  //11
            //0

            //int Size, NumberOfQueries;
            //while (true)
            //{
            //    Console.WriteLine("Enter size an number of queries: ");
            //    string[] line = Console.ReadLine().Split();

            //    if (line.Length != 2 ||!int.TryParse(line[0], out Size) || Size <= 0 ||!int.TryParse(line[1], out NumberOfQueries) || NumberOfQueries <= 0)
            //    {
            //        Console.WriteLine("Invalid input.");
            //        continue;
            //    }
            //    break;
            //}

            //int[] arr = new int[Size];
            //Console.WriteLine($"Enter yout numbers: ");
            //do
            //{
            //    string[] input = Console.ReadLine().Split();

            //    if (input.Length != Size)
            //    {
            //        Console.WriteLine("Invalid input.");
            //        continue;
            //    }

            //    bool valid = true;
            //    for (int i = 0; i < Size; i++)
            //    {
            //        if (!int.TryParse(input[i], out arr[i]))
            //        {
            //            Console.WriteLine("Invalid input.");
            //            valid = false;
            //            break;
            //        }
            //    }

            //    if (valid) break;

            //} while (true);

            //Console.WriteLine("Enter Queries: ");
            //int[] queries = new int[NumberOfQueries];

            //for (int i = 0; i < NumberOfQueries; i++)
            //{
            //    do
            //    {
            //        if (int.TryParse(Console.ReadLine(), out queries[i]))
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Inalid inpuy");
            //            continue;
            //        }
            //    } while (true);

            //}

            //Console.WriteLine("Output:");
            //for (int i = 0; i < NumberOfQueries; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < Size; j++)
            //    {
            //        if (arr[j] > queries[i])
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(count);
            //}

            #endregion

            #region Q2)
            //Given a number N and an array of N numbers. Determine if it's palindrome or not
            //Ex:
            //Input:
            //5
            //1 3 2 3 1
            //Output:
            //YES

            //int N;
            //do
            //{
            //    Console.Write("Please enter N:");
            //} while (!int.TryParse(Console.ReadLine(), out N) || N <= 0);

            //int[] arr = new int[N];
            //bool validInput = false;
            //while (!validInput)
            //{
            //    Console.WriteLine("\nEnter your numbers:");
            //    string[]? input = Console.ReadLine().Split();
            //    if (input.Length != N)
            //    {
            //        Console.WriteLine("Invalid Input");
            //        continue;
            //    }
            //    bool allValid = true;
            //    for (int i = 0; i < N; i++)
            //    {
            //        if (!int.TryParse(input[i], out arr[i]))
            //        {
            //            Console.WriteLine("Invalid Input");
            //            allValid = false;
            //            break;
            //        }
            //    }
            //    if (allValid)
            //    {
            //        validInput = true;
            //    }
            //}

            //bool isPalindrome = true;
            //for (int i = 0; i < N / 2; i++)
            //{
            //    if (arr[i] != arr[N - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine("\nOutput:");
            //Console.WriteLine(isPalindrome ? "Yes" : "No");

            #endregion

            #region Q3)
            //Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //Console.WriteLine("Before Reverse: ");
            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("After Reverse: ");

            //ReverseQueue(queue);
            //foreach (int item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4)
            //Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            //Ex:
            //Input:
            //[()] { }
            //Output:
            //Balanced

            //string? input = null;

            //do
            //{
            //    Console.WriteLine("Input:");
            //    input = Console.ReadLine();

            //    bool isValid = true;
            //    foreach (char c in input)
            //    {
            //        if (c != '(' && c != ')' && c != '{' && c != '}' && c != '[' && c != ']')
            //        {
            //            isValid = false;
            //            break;
            //        }
            //    }

            //    if (string.IsNullOrEmpty(input) || !isValid)
            //    {
            //        Console.WriteLine("Invalid input");
            //        input = null;
            //    }

            //} while (string.IsNullOrEmpty(input));

            //Console.WriteLine("Output:");
            //if (CheckParentheses(input))
            //    Console.WriteLine("Balanced");
            //else
            //    Console.WriteLine("Not Balanced");


            #endregion

            #region Q5)
            //Given an array, implement a function to remove duplicate elements from an array.

            //int[] arr = { 1, 2, 3, 2, 4, 1, 5, 3 };
            //int[] result = RemoveDuplicates(arr);

            //Console.WriteLine("Before removing duplicates:");
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("After removing duplicates:");
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q6)
            //Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList arr = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Before removing duplicates:");
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //arr = RemoveOddNumbers(arr);

            //Console.WriteLine("\nAfter removing duplicates:");

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q7)
            //Implement a queue that can hold different data types.
            //And insert the following data:
            //queue.Enqueue(1)
            //queue.Enqueue(“Apple”)
            //queue.Enqueue(5.28)

            //Queue01 queue = new Queue01();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //queue.ShowQueue();

            //Console.WriteLine($"\n{queue.Dequeue()}");
            //queue.ShowQueue();

            #endregion

            #region Q8)
            //Create a function that pushes a series of integers onto a stack.
            //Then, search for a target integer in the stack. If the target is found,
            //print a message indicating that the target was found how many elements were checked before finding the target
            //(“Target was found successfully and the count = 5”).
            //If the target is not found, print a message indicating that the target was not found(“Target was not found”).
            //Note : take the target as input from the user

            //Stack stack = new Stack();
            //int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //PushOntoStack(stack, numbers);

            //Console.WriteLine("Enter the target to search for in the stack:");
            //int Target;
            //do
            //{

            //    if(int.TryParse(Console.ReadLine(),out Target))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid imput");
            //    }

            //}while(true);
            //FindTarget(stack, Target);

            #endregion

            #region Q9)
            //Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
            //Ex : 
            //Input :
            //5 , 3
            //[1,2,3,4,4] , [10,4,4]
            //Output : 
            //[4,4]
            //Ex : 
            //Input :
            //5 , 3
            //[1,2,3,4,4] , [10,4,4]
            //Output : 
            //[4,4]

            //int Size01, Size02;
            //while (true)
            //{
            //    Console.WriteLine("Enter size of the two array: ");
            //    string[] line = Console.ReadLine().Split(",");

            //    if (line.Length != 2 ||!int.TryParse(line[0], out Size01) || Size01 <= 0 ||!int.TryParse(line[1], out Size02) || Size02 <= 0)
            //    {
            //        Console.WriteLine("Invalid input.");
            //        continue;
            //    }
            //    break;
            //}
            //int[] arr01 = new int[Size01];
            //int[] arr02 = new int[Size02];

            //Console.WriteLine("\nEnter first array:");
            //for (int i = 0; i < Size01; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out arr01[i]))
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Input");
            //        }
            //    } while (true);
            //}

            //Console.WriteLine("\nEnter secound array:");
            //for (int i = 0; i < Size02; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out arr02[i]))
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Input");
            //        }
            //    } while (true);
            //}

            //int[] result = new int[Math.Min(Size01, Size02)];
            //int resIndex = 0;

            //for (int i = 0; i < Size01; i++)
            //{
            //    for (int j = 0; j < Size02; j++)
            //    {
            //        if (arr01[i] == arr02[j])
            //        {
            //            result[resIndex++] = arr01[i];
            //            arr02[j] = int.MinValue;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine("\nOutput:");
            //if (resIndex > 0)
            //{
            //    Console.Write("[");
            //    for (int i = 0; i < resIndex; i++)
            //    {
            //        Console.Write(result[i]);
            //        if (i < resIndex - 1) Console.Write(",");
            //    }
            //    Console.WriteLine("]");
            //}
            //else
            //{
            //    Console.WriteLine("[0,0]");
            //}

            #endregion

            #region Q10)
            //Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target
            //Ex:
            //Input:
            //[1, 2, 3, 7, 5]
            //12
            //Output:
            //[2, 3, 7]

            //int size;
            //while (true)
            //{
            //    Console.Write("Enter size of the array: ");
            //    if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            //        break;
            //    else
            //        Console.WriteLine("Invalid input");
            //}

            //ArrayList arr = new ArrayList();
            //Console.WriteLine("\nEnter array elements:");
            //for (int i = 0; i < size; i++)
            //{
            //    int val;
            //    while (true)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out val))
            //        {
            //            arr.Add(val);
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input");
            //        }
            //    }
            //}

            //int target;
            //while (true)
            //{
            //    Console.Write("\nEnter target sum: ");
            //    if (int.TryParse(Console.ReadLine(), out target))
            //        break;
            //    else
            //        Console.WriteLine("Invalid input");
            //}

            //ArrayList result = FindSublistWithSumUpToTarget(arr, target);

            //if (result != null)
            //{
            //    Console.WriteLine("\nOutput:");
            //    Console.Write("[");
            //    for (int i = 0; i < result.Count; i++)
            //    {
            //        Console.Write(result[i]);
            //        if (i < result.Count - 1) Console.Write(",");
            //    }
            //    Console.WriteLine("]");
            //}
            //else
            //{
            //    Console.WriteLine("\nNo sublist found.");
            //}

            #endregion

            #region Q11)
            //Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order
            //Ex : 
            //Input:
            //[1, 2, 3, 4, 5]
            //K = 3
            //Output:
            //[3, 2, 1, 4, 5]

            //int size;
            //while (true)
            //{
            //    Console.Write("Enter size: ");
            //    if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            //        break;
            //    Console.WriteLine("Invalid input");
            //}

            //Queue<int> queue = new Queue<int>();

            //Console.WriteLine("\nEnter queue :");
            //for (int i = 0; i < size; i++)
            //{
            //    int value;
            //    while (true)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out value))
            //        {
            //            queue.Enqueue(value);
            //            break;
            //        }
            //        Console.WriteLine("Invalid input");
            //    }
            //}

            //int k;
            //while (true)
            //{
            //    Console.Write("\nEnter K: ");
            //    if (int.TryParse(Console.ReadLine(), out k) && k > 0 && k <= size)
            //        break;
            //    Console.WriteLine($"Invalid input");
            //}

            //ReverseFirstKInQueue(queue, k);

            //Console.WriteLine("\nOutput:");
            //Console.Write("[");
            //int count = 0;
            //foreach (var item in queue)
            //{
            //    Console.Write(item);
            //    count++;
            //    if (count < queue.Count)
            //        Console.Write(" , ");
            //}
            //Console.WriteLine("]");



            #endregion

        }
    }
}
