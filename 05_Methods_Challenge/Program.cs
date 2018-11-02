using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Methods_Challenge
{
    class Program
    {
        static decimal ageCharge;
        static decimal mileCharge;
        static decimal accidentCharge;
        static decimal totalCharge;
        static string name;
        static int userAge;
        static decimal carMiles;
        static string accident;
        static string carYear;
        static bool additionalCar;
        static decimal discount;

        static void Main(string[] args)
        {
            Register();
            bool runMenu = true;
            while (runMenu == true)
            {
                Console.Clear();
                Console.WriteLine($"Hello, {name}. Please select an option:");
                Console.WriteLine("1. See Information");
                Console.WriteLine("2. Update Information");
                Console.WriteLine("3. Exit");
                int input = ParseStringToInt();
                switch (input)
                {
                    default:
                        Console.WriteLine($"{input} is not a valid input.\n" +
                            $"Please select again.");
                        break;
                    case 1:
                        SeeInfo();
                        Console.ReadKey();
                        break;
                    case 2:
                        UpdateInfo();
                        Console.ReadKey();
                        break;
                    case 3:
                        runMenu = false;
                        break;
                }
            }
        }

        static int ParseStringToInt()
        {
            string inputString = Console.ReadLine();
            int input = int.Parse(inputString);
            return input;
        }

        static decimal ParseStringToDec()
        {
            string inputString = Console.ReadLine();
            decimal input = decimal.Parse(inputString);
            return input;
        }

        static bool ConvertStringToBool()
        {
            string inputString = Console.ReadLine().ToLower();
            switch (inputString)
            {
                case "yes":
                    return true;
                case "no":
                    return false;
                default:
                    return false;
            }
        }

        static void Register()
        {
            Console.WriteLine("Welcome to Komodo Insurance.\n" +
                "To register your information and calculate your premium, please fill out the following information.");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            userAge = ParseStringToInt();
            Console.WriteLine("What year is this car?");
            carYear = Console.ReadLine();
            Console.WriteLine("How many miles on the odometer?");
            carMiles = ParseStringToDec();
            Console.WriteLine("Has this car been in an accident? (yes/no)");
            accident = Console.ReadLine().ToLower();
            Console.WriteLine($"Do you own another car? (yes/no)");
            additionalCar = ConvertStringToBool();
            GetPremium();
            Console.WriteLine($"Thank you for registering, {name}. Your monthly premium is ${totalCharge}");
        }

        static void UpdateInfo()
        {
            Console.WriteLine($"Welcome, {name}.\n" +
                "To update your information and calculate your new premium, please fill out the following information.");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            userAge = ParseStringToInt();
            Console.WriteLine("What year is your car?");
            carYear = Console.ReadLine();
            Console.WriteLine("How many miles on the odometer?");
            carMiles = ParseStringToDec();
            Console.WriteLine("Have you been in an accident? (yes/no)");
            accident = Console.ReadLine().ToLower();
            Console.WriteLine($"Do you own another car? (yes/no)");
            additionalCar = ConvertStringToBool();
            GetPremium();
            Console.WriteLine($"Thank you for updating your information, {name}. Your monthly premium is ${totalCharge}");
        }

        static void SeeInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {userAge}");
            Console.WriteLine($"Car Year: {carYear}");
            Console.WriteLine($"Age Premium: ${ageCharge}");
            Console.WriteLine($"Car Mileage: {carMiles} miles");
            Console.WriteLine($"Mileage Premium: ${mileCharge}");
            Console.WriteLine($"Accident: {accident}");
            Console.WriteLine($"Accident Premium: ${accidentCharge}");
            Console.WriteLine($"Additional Car Discount: ${discount}");
            Console.WriteLine($"Total Premium: ${totalCharge}");
        }

        static void GetPremium()
        {

            if (userAge >= 25)
            {
                ageCharge = 75.00m;
            }
            else
            {
                ageCharge = 125.00m;
            }
            if (carMiles > 50000.00m && carMiles <= 100000.00m)
            {
                mileCharge = 25.00m;
            }
            else if (carMiles > 100000.00m)
            {
                mileCharge = 50.00m;
            }
            else
            {
                mileCharge = 0m;
            }
            if (accident == "yes")
            {
                accidentCharge = 25.00m;
            }
            else
            {
                accidentCharge = 0m;
            }
            if (additionalCar == true)
            {
                discount = 25.00m;
            }
            else
            {
                discount = 0m;
            }
            totalCharge = ageCharge + mileCharge + accidentCharge - discount;
        }
    }
}
