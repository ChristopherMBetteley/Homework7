using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Loop through each value
            If the value is true print:    "Better bring an umbrella"
            If the value is false print:  "No rain today, enjoy the sun!"

            */
            List<bool> boolList = new List<bool>() { true, false, false, true, false };

            foreach (bool tempVar in boolList)
            {
                if (tempVar == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else if (tempVar == false)
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }

            }
            Console.ReadKey();
        }
    }
}
