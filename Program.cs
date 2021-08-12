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
                {55,67,98 }
            };
            int rowsNumber = myNewArray.GetUpperBound(0)+1;
            Console.WriteLine();
            }
        }
    }
}
