using System.Collections;
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

            //    if (line.Length != 2 ||
            //        !int.TryParse(line[0], out Size) || Size <= 0 ||
            //        !int.TryParse(line[1], out NumberOfQueries) || NumberOfQueries <= 0)
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
            //Queue01 queue = new Queue01();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //queue.ShowQueue();

            //Console.WriteLine($"\n{queue.Dequeue()}");
            //queue.ShowQueue();

            #endregion

            #region Q8)
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

        }
    }
}
