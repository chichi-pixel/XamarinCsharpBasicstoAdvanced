using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the weather condition?");
            string weatherCondition = Console.ReadLine();

            if (weatherCondition == "rainy")
            {
                Console.WriteLine("It's raining outside");
            }
            else if (weatherCondition == "sunny")
            {
                Console.WriteLine("The sun shines!");
            }
            else
            {
                Console.WriteLine("It's cloudy");
            }
            Console.ReadKey();
            //if you don't write Console.ReadKey(); - you can not see the result!
        }
    }
}



