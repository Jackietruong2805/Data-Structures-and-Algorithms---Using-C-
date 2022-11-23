using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Search
    {
        public int binarysearch(int[] A, int n, int value)
        {
            int l = 0;
            int r = n - 1;
            while(l <= r)
            {
                int mid = (l + r) / 2;
                if (value == A[mid])
                    return mid;
                else if (value < A[mid])
                    r = mid - 1;
                else if (value > A[mid])
                    l = mid + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Search s = new Search();
            int[] A = { 15, 21, 47, 84, 96 };

            int found = s.binarysearch(A, A.Length, 21);
            Console.WriteLine("Result: " + found);
            Console.ReadKey();
        }
    }
}