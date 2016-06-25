using System;

namespace LiveDemo
{

    class LiveDemo
    {
        static int posCount;
        static int[] sequence;

        static void Main()
        {
            int indexToSearch = 4;
            posCount = int.Parse(Console.ReadLine());
            sequence = new int[posCount];

            GeneratePermutation(0);
        }

        static void GeneratePermutation(int pos)
        {
            if (pos >= posCount)
            {
                Print();
                return;
            }

            for (int cnt = 0; cnt < posCount; cnt++)
            {
                sequence[pos] = cnt;
                GeneratePermutation(pos + 1);
            }
        }
        
        static void Print()
        {
            foreach (var num in sequence)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
    }
}
