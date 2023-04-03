using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array is used to collection a Data

            double[] studentHeight = new double[20];

            //first student
            studentHeight[0] = 1.32;

            //second student
            studentHeight[1] = 1.23;

            //third student
            studentHeight[2] = 1.52;

            //Console.WriteLine(studentHeight[1].ToString());
            //Console.ReadKey();

            string[] students = { "Jane", "George", "Mila", "Alisa" };

            Console.WriteLine(students[1] + "'s height = " + studentHeight[1].ToString());
            Console.ReadKey();



        }
    }
}
