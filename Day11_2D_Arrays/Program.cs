using System;

namespace Day11_2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            int sum ;
            int max = int.MinValue;
            // create 2D array, Need to learn about this later
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            for(int i=0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] 
                        + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2] + arr[i + 1][j + 1];

                    if (sum > max)
                        max = sum;
                }
            }
            Console.WriteLine(max);
        }
    }
}
