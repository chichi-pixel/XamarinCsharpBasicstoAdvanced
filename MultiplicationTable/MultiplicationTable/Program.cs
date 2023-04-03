using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for generating multiplication table");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                int result = number * 1;
                Console.WriteLine("{0} * {1} = {2}", number, 1, result);
            }

            Console.ReadKey();
        }
    }
}
