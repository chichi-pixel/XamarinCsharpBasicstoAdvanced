using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //A class is simply a blueprint that enables us to cretae and object

            Computer myComputer = new Computer("Windows OS", "Acer", 15);
            //myComputer.OS = "Windows";
            //myComputer.Make = "Acer";
            //myComputer.ScreenSize = 15;

            Computer myFriendsComputer = new Computer("Linux", "Lenovo ThinkPad", 15);
            Console.WriteLine(myFriendsComputer.ScreenSize);
            Console.ReadKey();


        }
    }  

   public class Computer
    {
        private string os;
        private string make;
        private double screenSize;

        public string OS { get; set; }

        public string Make { get; set; }

        public double ScreenSize { get; set; }

        public Computer( string OS, string Make, double ScreenSize)
        {
            OS = os;
            Make = make;
            ScreenSize = screenSize;
        }

    }
}

