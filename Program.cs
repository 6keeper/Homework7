using System;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Insert {i} array element");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(myArray);
            Array.Reverse(myArray);
            foreach (var element in myArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}
