using System;

namespace Day10_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // imput number need to convert
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0, k=0;
            int count = 0; 
            // array contain the binary 
            int[] a= new int[100] ;
            while (n > 0)
            {
                a[i] = n % 2;
                n = n / 2;
                i++;
            }
         
            for ( int j=0; j<a.Length; j++)
            {
                if (a[j] == 1)
                {
                    count += 1;
                }
                else
                {
                    if(count > k)
                    {
                        k = count;
                    }
                    count = 0;
                }

            }
            Console.WriteLine(k);
        }
    }
}
