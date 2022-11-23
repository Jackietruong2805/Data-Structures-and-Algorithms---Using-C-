using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Sort
    {
        public void selectionsort(int[] A, int n)
        {
            for(int i=0; i<n-1; i++)
            {
                int position = i;
                for(int j=i + 1; j<n; j++)
                {
                    if (A[j] < A[position])
                        position = j;
                }
                int temp = A[i];
                A[i] = A[position];
                A[position] = temp;
            }
        }
        public void display(int[] A, int n)
        {
            for(int i = 0; i <n; i++)
            {
                Console.Write(A[i] + "  ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Sort s = new Sort();
            int[] A = { 3, 5, 8, 9, 5, 2, 8 };
            Console.WriteLine("Original Array: ");
            s.display(A, A.Length);
            s.selectionsort(A, A.Length);
            Console.WriteLine("Sorted Array");
            s.display(A, 6);
            Console.ReadKey();
        }
    }
}