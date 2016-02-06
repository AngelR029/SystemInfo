using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarInt
{
    class Program
    {

        
        public static void PrintLargestDivisibleBy5(params int[] list)
        {

            int largest = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i] >= largest) && (list[i] % 5 == 0))
                {
                    largest = list[i];
                }
            }
            Console.WriteLine(largest);           
        }
        static void Main(string[] args)
        {
            PrintLargestDivisibleBy5(5,5,10,22,50,0);
            Console.ReadLine();
        }
    }
}
