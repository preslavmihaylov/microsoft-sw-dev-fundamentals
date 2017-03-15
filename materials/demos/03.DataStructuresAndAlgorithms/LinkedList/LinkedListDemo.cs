using System;
using System.Collections.Generic;


namespace LinkedList
{
    class LinkedListDemo
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(5);
            list.AddFirst(2);

            LinkedListNode<int> firstEl = list.First;

            list.AddAfter(firstEl, 4);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
