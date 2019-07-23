using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary of string with string keys 
            Dictionary<string, string> phomeBook = new Dictionary<string, string>();
            // Add 3 elements to dictionary, NO DUPLICARE KEYS
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            // input pair key and value 
            for(int i=0; i<n; i++)
            {
                string [] s = Console.ReadLine().Split(' ');
                phomeBook.Add(s[0], s[1]);
            }
            //check key in dictionary
            for( int i=0; i<n; i++)
            {
                string s = Console.ReadLine();
                if (phomeBook.ContainsKey(s))
                {
                    Console.WriteLine("{0}={1}", s, phomeBook[s]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
