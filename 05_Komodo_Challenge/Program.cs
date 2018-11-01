using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Komodo_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            decimal ageCharge;
            decimal mileCharge;
            decimal accidentCharge;
            decimal totalCharge;
            string input;
            string name;
            string ageString;
            int ageInt;
            string mileageString;
            decimal mileageDec;
            string accident;
            string carYear;
            //Register
            Console.WriteLine("Welcome to Komodo Car Insurance. Please enter your information to register.");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            ageString = Console.ReadLine();
            ageInt = int.Parse(ageString);
            Console.WriteLine("What is the year of your vehicle?");
            carYear = Console.ReadLine();
            Console.WriteLine("What is the total mileage of your vehicle?");
            mileageString = Console.ReadLine();
            mileageDec = decimal.Parse(mileageString);
            Console.WriteLine("Have you ever been in an accident? (yes/no)");
            accident = Console.ReadLine();
            if (ageInt >= 25)
            {
                ageCharge = 75.00m;
            }
            else
            {
                ageCharge = 125.00m;
            }
            if (mileageDec > 50000.00m && mileageDec <= 100000.00m)
            {
                mileCharge = 25.00m;
            }
            else if (mileageDec > 100000.00m)
            {
                mileCharge = 50.00m;
            }
            else
            {
                mileCharge = 0.00m;
            }
            if (accident == "y")
            {
                accidentCharge = 25.00m;
            }
            else
            {
                accidentCharge = 0.00m;
            }
            totalCharge = ageCharge + mileCharge + accidentCharge;
            Console.WriteLine($"Hello, {name}. Your premium is ${totalCharge}. This was calculated from an age charge of ${ageCharge}, a mile charge of ${mileCharge}, and an accident charge of ${accidentCharge}.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.WriteLine($"Hello, {name}. Please select an option:");
            Console.WriteLine("See Information");
            Console.WriteLine("Update Information");
            Console.WriteLine("Exit");
            Console.WriteLine(" ");
            input = Console.ReadLine().ToLower();
            while (input != "exit")
            {
                switch (input)
                {
                    case "see information":
                        Console.WriteLine($"Name: {name}");
                        Console.WriteLine($"Age: {ageInt}");
                        Console.WriteLine($"Car Year: {carYear}");
                        Console.WriteLine($"Age Premium: ${ageCharge}");
                        Console.WriteLine($"Car Mileage: {mileageDec} miles");
                        Console.WriteLine($"Mileage Premium: ${mileCharge}");
                        Console.WriteLine($"Accident: {accident}");
                        Console.WriteLine($"Accident Premium: ${accidentCharge}");
                        Console.WriteLine($"Total Premium: ${totalCharge}");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case "update information":
                        Console.WriteLine("What is your name?");
                        name = Console.ReadLine();
                        Console.WriteLine("How old are you?");
                        ageString = Console.ReadLine();
                        ageInt = int.Parse(ageString);
                        Console.WriteLine("What is the year of your vehicle?");
                        carYear = Console.ReadLine();
                        Console.WriteLine("What is the total mileage of your vehicle?");
                        mileageString = Console.ReadLine();
                        mileageDec = decimal.Parse(mileageString);
                        Console.WriteLine("Have you ever been in an accident? (y/n)");
                        accident = Console.ReadLine();
                        if (ageInt >= 25)
                        {
                            ageCharge = 75.00m;
                        }
                        else
                        {
                            ageCharge = 125.00m;
                        }
                        if (mileageDec > 50000.00m && mileageDec <= 100000.00m)
                        {
                            mileCharge = 25.00m;
                        }
                        else if (mileageDec > 100000.00m)
                        {
                            mileCharge = 50.00m;
                        }
                        else
                        {
                            mileCharge = 0.00m;
                        }
                        if (accident == "y")
                        {
                            accidentCharge = 25.00m;
                        }
                        else
                        {
                            accidentCharge = 0.00m;
                        }
                        totalCharge = ageCharge + mileCharge + accidentCharge;
                        Console.WriteLine($"Hello, {name}. Your premium is ${totalCharge}. This was calculated from an age charge of ${ageCharge}, a mile charge of ${mileCharge}, and an accident charge of ${accidentCharge}.");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine($"{input} is not a valid input");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine($"Welcome to Komodo Car Insurance, {name}. Please select an option:");
                Console.WriteLine("See Information");
                Console.WriteLine("Update Information");
                Console.WriteLine("Exit");
                Console.WriteLine(" ");
                input = Console.ReadLine().ToLower();
            }

        }
    }
}
