using System;

namespace Homework7
{
    class Program
    {
            static void Main(string[] args)
        {
            int[,] myNewArray = new int[3, 3]
            {
                {4,28,80},
                {32,12,36},
                {55,67,98}
            };
            int max = 0;
            int i = 0;
            int rowsNumber = myNewArray.GetUpperBound(0)+1;
            int colNumber = myNewArray.Length / rowsNumber;
            int[] result = new int[rowsNumber];
            while ( i < rowsNumber)
            {
                for (int j = 0; j < colNumber; j++)
                {
                    if (myNewArray[i,j]>max)
                    {
                       max = myNewArray[i, j];
                    }
                }
                result[i] = max;
                max = 0;
                i++;
            }
            for (int k = 0; k < result.Length; k++)
            {
                Console.WriteLine($"{k+1} row max element is {result[k]}");
            }
        }
    }
}
