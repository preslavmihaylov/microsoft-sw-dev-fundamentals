using System;

namespace StackDemo
{
    class StackDemo
    {
        static void Main()
        {
            PressoStack a = new PressoStack();

            a.Push(10);
            a.Push(11);
            a.Push(12);
            a.Push(13);

            Console.WriteLine(a.Peek());
        }
    }
}
