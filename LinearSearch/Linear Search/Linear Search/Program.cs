using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Search
    {
        public int linearsearch(int[] A, int n, int value)
        {
            int index = 0;
            while(index < n)
            {
                if (A[index] == value)
                    return index;
                index = index + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Search s = new Search();
            int[] A = { 84, 21, 47, 96, 15 };
            int found = s.linearsearch(A, A.Length, 84);
            Console.WriteLine("Result: " + found);
            Console.ReadKey();

        }
    }
}