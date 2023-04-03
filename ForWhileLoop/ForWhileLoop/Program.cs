using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int cups = 0; cups <= 10; cups++)
            //{
            //    Console.WriteLine("Number of Cups = " + cups.ToString());
            //}

            //Console.ReadKey();

            int cups = 1;

            while(cups<11)
            {
                Console.WriteLine("Number of Cups = " + cups.ToString());

                cups++;

            }
            Console.ReadKey();
        }
    }
}
