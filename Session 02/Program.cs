using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_02
{
    internal class Program
    {
        #region Methods
        static void ReverseQueue(Queue<int> queue)
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

            //Console.WriteLine("Enter size and number of queries: ");
            //string[] Line = Console.ReadLine().Split();
            //int Size, NumberOfQueries;
            //int.TryParse(Line[0], out Size);
            //int.TryParse(Line[1], out NumberOfQueries);

            //Console.WriteLine("Enter your numbers: ");
            //string[] Input = Console.ReadLine().Split();
            //int[] arr = new int[Size];
            //for (int i = 0; i < Size; i++)
            //{
            //    int.TryParse(Input[i], out arr[i]);
            //}

            //Console.WriteLine("Enter Queries: ");
            //int[] queries = new int[NumberOfQueries];
            //for (int i = 0; i < NumberOfQueries; i++)
            //{
            //    string input = Console.ReadLine();
            //    int x;
            //    int.TryParse(input, out x);
            //    queries[i] = x;
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
            //Console.WriteLine("Please enter N:");
            //int.TryParse(Console.ReadLine(), out N);

            //Console.WriteLine("\nEnter your numbers: ");
            //string[] input = Console.ReadLine().Split();
            //int[] arr = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    int.TryParse(input[i], out arr[i]);
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
            //Console.WriteLine(isPalindrome ? "Yes": "No");

            #endregion

            #region Q3
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

        }
    }
}
