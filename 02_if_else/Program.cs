using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("How old are you?");
            string ageString = Console.ReadLine();
            int ageInt = int.Parse(ageString);

            if (ageInt < 18)
            {
                Console.WriteLine("Hey there, kid.");
            }

            else
            {
                Console.WriteLine("Hello, peer.");
            }

            Console.ReadLine();*/

            decimal yearCharge;
            decimal mileCharge;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What year is the car?");
            string carAgeString = Console.ReadLine();
            int carAgeInt = int.Parse(carAgeString);
            int carAgeActual = DateTime.Now.Year - carAgeInt;

            Console.WriteLine("How many miles are on the odometer?");
            string carMilesString = Console.ReadLine();
            decimal carMilesDec = decimal.Parse(carMilesString);

            if (carAgeActual > 15)
            {
                yearCharge = 125.00m;
            }

            else if (carAgeActual >=5 && carAgeActual <= 15)
            {
                yearCharge = 100.00m;
            }

            else
            {
                yearCharge = 75.00m;
            }

            if (carMilesDec > 50000.00m)
            {
                mileCharge = 25.00m;
            }

            else
            {
                mileCharge = 0.00m;
            }


            decimal totalCharge = yearCharge + mileCharge;

            Console.WriteLine("Hello, " + name + ". Your monthly premium is $" + yearCharge + " with a mileage charge of $" + mileCharge + " for a total of $" + totalCharge);

            Console.ReadLine();

        }
    }
}
