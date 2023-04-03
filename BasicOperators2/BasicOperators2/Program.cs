using System;


namespace BasicOperators2
{
          class BasicOperators2
          {
            static void Main(string[] args)
            {
                Console.WriteLine("Please enter your gross income!");
                double grossIncome = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your expenses!");
                double expenses = double.Parse(Console.ReadLine());

                double profit = grossIncome - expenses;
                Console.WriteLine("Total profit");
                Console.ReadKey();

                Console.WriteLine("Please enter your cash balance");
                double cashBalance = double.Parse(Console.ReadLine());
                
                
                double totalCashinBusiness = cashBalance + profit;
                Console.WriteLine("Total Cash In Business");
                Console.ReadKey();

                Console.WriteLine("Please enter annual tax rate");
                double percent = double.Parse(Console.ReadLine()) / 100;
                double annualTax = profit * percent;
                Console.WriteLine("Annual Tax Payable");
                Console.WriteLine(annualTax);
                Console.ReadKey();

               
            }
        }
    }

