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
            stackUsingLL.IsEmpty();
            stackUsingLL.Display();
            QueueUsingLL queueUsingLL = new QueueUsingLL();
            queueUsingLL.Enqueue(56);
            queueUsingLL.Enqueue(30);
            queueUsingLL.Enqueue(70);
            Console.WriteLine("Queue Structure- ");
            queueUsingLL.Display();
            queueUsingLL.Dequeue();
            Console.WriteLine("New Queue Structure- ");
            queueUsingLL.Display();
        }
    }
}
