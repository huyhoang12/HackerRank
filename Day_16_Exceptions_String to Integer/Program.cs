using System;

/*
    Task 
    Read a string, , and print its integer value; if  cannot be converted to an integer, print Bad String.
     */
namespace Day_16_Exceptions_String_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
          
                try {
                    int numConvert = Convert.ToInt32(S);
                    Console.WriteLine(numConvert);
                }
                catch
                {
                    Console.WriteLine("Bad String");
                }
            
        }
    }
}
