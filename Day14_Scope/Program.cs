using System;
using System.Linq;

namespace Day14_Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public int[] a;

        public Difference(int[] a)
        {
            this.a = a;
        }
        // Add your code here
        public void computeDifference()
        {
            maximumDifference = a.Max() - a.Min();
        }

        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
