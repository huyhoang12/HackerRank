using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace Day9_Recursion3
{
    class Program
    {
        // Complete the factorial function below.
        static int factorial(int n)
        {
            int facto=1 ;
            if (n == 0|| n==1)
            {
               facto= 1;
            }
            else
            {
                for(int i=1; i<=n; i++)
                {
                    facto = facto * i;
                    
                }
            }
            return facto;

        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
