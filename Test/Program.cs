using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] s = Console.ReadLine().Split(' ');
            Array.Sort(s, StringComparer.Ordinal);
           
            int n = s.Length / 3;
            if (s.Length % 3 == 1)
            {
                for (int i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine("{0,-20} {1, -20} {2,20}", s[i], s[i + n], s[i + n + n]);

                }
                Console.WriteLine("{0, 62}", s[s.Length-1]);
            }
            if (s.Length % 3 == 2)
            {
                for (int i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine("{0,-20} {1, -20} {2,20}", s[i], s[i + n], s[i + n + n+1]);

                }
                Console.WriteLine("{0, 22} {1,39}",s[2*n], s[s.Length - 1]);
            }



        }
    }
}
