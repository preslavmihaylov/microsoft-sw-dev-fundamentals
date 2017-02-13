using System;
using System.Collections.Generic;

namespace StackDemo
{
    class PressoStack
    {
        private List<int> numbers = new List<int>();

        public int Count
        {
            get
            {
                return this.numbers.Count;
            }
        }

        public PressoStack()
        {
        }

        public void Push(int number)
        {
            numbers.Add(number);
        }

        public int Pop()
        {
            int number = this.Peek();
            numbers.RemoveAt(numbers.Count - 1);
            return number;
        }

        public int Peek()
        {
            if (numbers.Count <= 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return numbers[numbers.Count - 1];
        }
    }
}
