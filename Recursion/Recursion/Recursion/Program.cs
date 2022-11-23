using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Recursion
    {
        public void calculateiterative(int n)
        {
            while(n> 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;

            }
        }
        public void calculaterecursive(int n)
        {
            if(n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calculaterecursive(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Recursion r = new Recursion();

            // r.calculateiterative(4);
            r.calculaterecursive(4);

            Console.ReadLine();
        }
    }
}