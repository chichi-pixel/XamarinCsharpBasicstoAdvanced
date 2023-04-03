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
            //Concatenation of Strings
            Console.WriteLine("Total profit = " + profit.ToString() + " " + "USD");
            //Interpolation
            //Console.WriteLine($"Total profit = { grossIncome-expenses} USD");
            Console.ReadKey();

            Console.WriteLine("Please enter your cash balance");
            double cashBalance = double.Parse(Console.ReadLine());

            double totalCashinBusiness = cashBalance + profit;
            //Concatenation of Strings
            //Console.WriteLine("Total Cash In Business = " + totalCashinBusiness.ToString() + " USD");
            //Interpolation
            //Console.WriteLine($"Total Cash In Business= { cashBalance + profit} + USD");
            Console.ReadKey();

            Console.WriteLine("Please enter annual tax rate");
            double percent = double.Parse(Console.ReadLine()) / 100;
            double annualTax = profit * percent;
            //Console.WriteLine("Annual Tax Payable");
            //Console.WriteLine(annualTax);
            //Concatenation of Strings
            Console.WriteLine("Annual Tax Payable = " + annualTax.ToString() + " USD");
            //Interpolation
            //Console.WriteLine($"Annual Tax Payable = { profit* percent} + USD");
            Console.ReadKey();
        }
    }
}
