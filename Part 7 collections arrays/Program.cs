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
            bool done = false;
            int[] num = new int [30];
            while (!done)
            {
                
                num[1] = generator.Next(1, 101);
                num[2] = generator.Next(1, 101);
                num[3] = generator.Next(1, 101);
                num[4] = generator.Next(1, 101);
                num[5] = generator.Next(1, 101);
                num[6] = generator.Next(1, 101);
                num[7] = generator.Next(1, 101);
                num[8] = generator.Next(1, 101);
                num[9] = generator.Next(1, 101);
                num[10] = generator.Next(1, 101);
                num[11] = generator.Next(1, 101);
                num[12] = generator.Next(1, 101);
                num[13] = generator.Next(1, 101);
                num[14] = generator.Next(1, 101);
                num[15] = generator.Next(1, 101);
                num[16] = generator.Next(1, 101);
                num[17] = generator.Next(1, 101);
                num[18] = generator.Next(1, 101);
                num[19] = generator.Next(1, 101);
                num[20] = generator.Next(1, 101);
                num[21] = generator.Next(1, 101);
                num[22] = generator.Next(1, 101);
                num[23] = generator.Next(1, 101);
                num[24] = generator.Next(1, 101);
                num[25] = generator.Next(1, 101);
                num[26] = generator.Next(1, 101);
                num[27] = generator.Next(1, 101);
                num[28] = generator.Next(1, 101);
                num[29] = generator.Next(1, 101);
                
                done = true;
            }
            for (int i = 0; i <= 30; i++)
            {
                Console.Write(num[generator.Next(0, 31)] + ", ");
            }
        }
    }
}
