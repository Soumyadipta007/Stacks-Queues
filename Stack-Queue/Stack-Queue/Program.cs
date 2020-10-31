using System;

namespace Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLL stackUsingLL = new StackUsingLL();
            stackUsingLL.Push(70);
            stackUsingLL.Push(30);
            stackUsingLL.Push(56);
            Console.WriteLine("Stack Structure- ");
            stackUsingLL.Display();
        }
    }
}
