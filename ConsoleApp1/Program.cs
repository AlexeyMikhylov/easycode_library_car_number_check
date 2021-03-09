using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string CarNumber = Console.ReadLine();

            CarNumberCheck cnc = new CarNumberCheck();            

            if (cnc.CarNumber(CarNumber) == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
        }
    }
}
