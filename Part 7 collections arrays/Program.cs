using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_7_collections_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] numbers = new int [30];
            int evenNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = generator.Next(1, 101);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int j = 0; j < numbers.Length; j++)
            {
                numbers[j] = generator.Next(1, 101);
                Console.Write(numbers[j] + " ");
                if (numbers[j] % 2 == 0)
                {
                    evenNum += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"There are {evenNum} even numbers.");
            Console.WriteLine();
            Console.WriteLine();
            for (int k = 0;  k < numbers.Length; k++)
            {
                numbers[k] = generator.Next(1, 101);
                if (numbers[k] % 5 == 0)
                {
                    Console.Write(numbers[k] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int l = 0; l < numbers.Length; l += 2)
            {
                numbers[l] = generator.Next(1, 101);
                numbers[l] *= 2;
                Console.Write(numbers[l] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int m = 0; m < numbers.Length; m++)
            {
                Console.Write(numbers[m] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Array.Sort(numbers);
            Console.WriteLine($"Min: {numbers[0]} Max: {numbers[numbers.Length - 1]}");
            //You get an error.
            //Won't work.
            //Gets set to zero.
            //No.
        }
    }
}
