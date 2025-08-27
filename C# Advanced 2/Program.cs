using System.Collections;

namespace C__Advanced_2
{
    internal class Program
    {
        #region Question 03 Method
        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stk = new Stack<int>();

            while (queue.Count > 0)
            {
                stk.Push(queue.Dequeue());
            }

            while (stk.Count > 0)
            {
                queue.Enqueue(stk.Pop());
            }
        }
        #endregion

        #region Question 04 Method
        public static bool IsBalancedParenthesis(string Parenthesis)
        {
            Stack<char> stk = new Stack<char>();
            foreach (char ch in Parenthesis)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                    stk.Push(ch);
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    char sec = stk.Pop();
                    if ((ch == ')' && sec != '(') ||
                        (ch == '}' && sec != '{') ||
                        (ch == ']' && sec != '['))
                        return false;
                }
            }
            return stk.Count == 0;
        }
        #endregion

        #region Question 11 Method
        public static Queue<int> ReverseFirstKElements(Queue<int> queue, int K)
        {
            Stack<int> stack = new Stack<int>();
            Queue<int> tempQueue = new Queue<int>();
            //Put In Stack (K Elements)
            for (int i = 0; i < K; i++)
            {
                stack.Push(queue.Dequeue());
            }
            //Put In Temp Queue (Stack Elements)
            while (stack.Count > 0)
            {
                tempQueue.Enqueue(stack.Pop());
            }
            //Put In Temp Queue (Remaining Elements)
            while (queue.Count > 0)
            {
                tempQueue.Enqueue(queue.Dequeue());
            }
            return tempQueue;
        } 
        #endregion

        static void Main(string[] args)
        {
            #region Question 01


            #endregion
            #region Question 02
            #endregion
            #region Question 03

            //Queue<int> QueueOfIntegers = new Queue<int>();
            //QueueOfIntegers.Enqueue(10);
            //QueueOfIntegers.Enqueue(20);
            //QueueOfIntegers.Enqueue(30);
            //Console.WriteLine("Arranged Queue : ");
            //foreach(var I in QueueOfIntegers)
            //{
            //    Console.WriteLine(I);
            //}
            //ReverseQueue(QueueOfIntegers);
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Reversed Queue : ");
            //foreach (var I in QueueOfIntegers) {  Console.WriteLine(I); }
            //Console.WriteLine("-------------------------------");
            #endregion
            #region Question 04
            //string? Paranthesis = Console.ReadLine();
            //if (IsBalancedParenthesis(Paranthesis))
            //    Console.WriteLine("The parentheses are balanced.");
            //else
            //    Console.WriteLine("The parentheses are not balanced.");
            #endregion
            #region Question 05
            //int[] arr = { 1, 1, 2, 2, 3, 3, 4, 5, 6, 6, 7 };

            //List<int> ArrayWithoutDuplicates = new List<int>();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    bool IsExist = false;

            //    for (int j = 0; j < ArrayWithoutDuplicates.Count; j++)
            //    {
            //        if (arr[i] == ArrayWithoutDuplicates[j])
            //        {
            //            IsExist = true;
            //            break;
            //        }
            //    }

            //    if (!IsExist)
            //    {
            //        ArrayWithoutDuplicates.Add(arr[i]);
            //    }
            //}

            //foreach (var item in ArrayWithoutDuplicates)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question 06
            //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

            //for (int i = Numbers.Count - 1; i >= 0; i--)  
            /*
                       لفيت علي الارراي بالعكس عشان لما بمسح عنصر من الاول او النص بيحصل شيفت للانديكس 
                        ف كنت عايز اتفادي النقطة دي
            */
            //{
            //    if (Numbers[i] % 2 != 0)
            //    {
            //        Numbers.RemoveAt(i);
            //    }
            //}

            //foreach (var num in Numbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region Question 07
            //Queue<object> queue = new Queue<object>();

            //queue.Enqueue(1);          
            //queue.Enqueue("Apple");    
            //queue.Enqueue(5.28);       

            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question 08
            //Stack<int> STK = new Stack<int>();
            //STK.Push(1);
            //STK.Push(2);
            //STK.Push(3);
            //STK.Push(4);
            //STK.Push(5);
            //STK.Push(6);
            //STK.Push(7);
            //STK.Push(8);
            //int Count = 0;
            //bool IsFound = false;
            //Console.Write("Enter target: ");
            //int Target;
            //int.TryParse(Console.ReadLine(),out Target);
            //foreach (int i in STK)
            //{
            //    Count++;
            //    if (i == Target)
            //    {
            //        Console.WriteLine($"Target found at number {Count}");
            //        IsFound = true;
            //        break;
            //    }
            //}
            //if (!IsFound)
            //    Console.WriteLine("Not found");
            #endregion
            #region Question 09
            //int[] FirstArray = { 1, 2, 3, 4, 4 };
            //int[] SecondArray = { 4, 5, 6 , 2 ,3 ,1 };
            //List<int> Intercetions = new List<int>();
            //bool[] IsCommon = new bool[FirstArray.Length]; 

            //for (int i = 0; i < SecondArray.Length; i++)
            //{
            //    for (int j = 0; j < FirstArray.Length; j++)
            //    {
            //        if (!IsCommon[j] && FirstArray[j] == SecondArray[i])
            //        {
            //            Intercetions.Add(SecondArray[i]);
            //            IsCommon[j] = true; 
            //            break;
            //        }
            //    }
            //}
            //foreach (var item in Intercetions)
            //{
            //    Console.WriteLine(item);
            //}
            //معرفش في طريقة احسن ولا لا بصراحة :)  
            #endregion
            #region Question 10
            #endregion
            #region Question 11
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);
            //queue.Enqueue(7);
            //queue.Enqueue(8);
            //queue.Enqueue(9);
            //queue.Enqueue(10);
            //int K = 3;
            //queue = ReverseFirstKElements(queue, K);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}

