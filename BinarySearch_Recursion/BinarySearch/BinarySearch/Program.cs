using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Search
    {
        public int binarysearch(int[] A, int value, int l, int r)
        {
            if (l > r)
            {
                return -1;
            }
            else
            {
                int mid = (l + r) / 2;
                if (value == A[mid])
                    return mid;
                else if (value < A[mid])
                    return binarysearch(A, value, l, mid - 1);
                else if (value > A[mid])
                    return binarysearch(A, value, mid + 1, r);
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.Clear();
                Search s = new Search();
            int[] A = { 15, 21, 47, 84, 96 };
            int found = s.binarysearch(A, 100, 0, A.Length - 1);
            Console.WriteLine("Result: " + found);
            Console.ReadKey();
        }
    }
}