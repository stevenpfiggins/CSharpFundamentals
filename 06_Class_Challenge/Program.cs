using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Class_Challenge
{
    class Program
    {
        static bool additionalCar;
        static bool correct;
        static string selection;
        static bool running;
        static Person person1 = new Person();

        static Car car1 = new Car()
        {
            Owner = person1,
        };

        static Car car2 = new Car()
        {
            Owner = person1,
        };

        static var carsList = new List<Car>
            {
                car1,
                car2
            };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo Insurance.");
            RegisterPersonInfo();
            GetPersonInfoLoop();
            RegisterCarInfo();
            GetCarInfoLoop();
            Console.WriteLine("Do you own an additional car? (y/n)");
            additionalCar = ConvertStringToBool();
            if (additionalCar == true)
            {
                RegisterCarInfo2();
                GetCarInfoLoop();
            }
            else
            {
                Console.Clear();
            }
            Console.Clear();
            running = true;
            while (running == true)
            {
                Console.WriteLine("Please select an option.\n\t" +
                    "1. See User Information\n\t" +
                    "2. See Car Information\n\t" +
                    "3. Update Information\n\t" +
                    "4. Exit");
                selection = Console.ReadLine();
                switch (selection)
                {
                    default:
                        Console.WriteLine("That is not a valid input. Please try again.");
                        break;
                    case "1":
                        SeePersonInfo();
                        break;
                    case "2":
                        SeeCarInfo1();
                        SeeCarInfo2();
                        break;
                    case "3":
                        RegisterPersonInfo();
                        GetPersonInfoLoop();
                        RegisterCarInfo();
                        GetCarInfoLoop();
                        Console.WriteLine("Do you own an additional car? (y/n)");
                        additionalCar = ConvertStringToBool();
                        if (additionalCar == true)
                        {
                            RegisterCarInfo2();
                            GetCarInfoLoop();
                        }
                        else
                        {
                            Console.Clear();
                        }
                        break;
                    case "4":
                        running = false;
                        break;
                }

            }
        }

        static void RegisterPersonInfo()
        {
            Console.WriteLine("Please register by completing the following questions.");
            Console.WriteLine("What is your first name?");
            person1.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            person1.LastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            person1.PersonAge = ParseStringToInt();
            Console.WriteLine("What is your address?");
            person1.Address = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please review your information.");
            SeePersonInfo();
            Console.WriteLine("Is this information correct? (y/n)");
            correct = ConvertStringToBool();
        }

        static void RegisterCarInfo()
        {
            Console.WriteLine("What make is your car?");
            car1.CarMake = Console.ReadLine();
            Console.WriteLine("What model is your car?");
            car1.CarModel = Console.ReadLine();
            Console.WriteLine("What year is your car?");
            car1.CarYear = ParseStringToInt();
            Console.Clear();
            Console.WriteLine("Please review your information.");
            SeeCarInfo1();
            Console.WriteLine("Is this information correct? (y/n)");
            correct = ConvertStringToBool();
        }

        static void RegisterCarInfo2()
        {
            Console.WriteLine("What make is your car?");
            car2.CarMake = Console.ReadLine();
            Console.WriteLine("What model is your car?");
            car2.CarModel = Console.ReadLine();
            Console.WriteLine("What year is your car?");
            car2.CarYear = ParseStringToInt();
            Console.Clear();
            Console.WriteLine("Please review your information.");
            SeeCarInfo2();
            Console.WriteLine("Is this information correct? (y/n)");
            correct = ConvertStringToBool();
        }

        static int ParseStringToInt()
        {
            string inputString = Console.ReadLine();
            int input = int.Parse(inputString);
            return input;
        }

        static bool ConvertStringToBool()
        {
            string inputString = Console.ReadLine().ToLower();
            switch (inputString)
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    return false;
            }
        }

        static void SeePersonInfo()
        {
            Console.WriteLine($"\t" +
                $"First Name: {person1.FirstName}\n\t" +
                $"Last Name: {person1.LastName}\n\t" +
                $"Age: {person1.PersonAge}\n\t" +
                $"Address: {person1.Address}");
        }

        static void SeeCarInfo1()
        {
            Console.WriteLine("\t" +
                $"Car Make: {car1.CarMake}\n\t" +
                $"Car Model: {car1.CarModel}\n\t" +
                $"Car Year: {car1.CarYear}\n\t" +
                $"Car Owner: {car1.Owner.FirstName} {car1.Owner.LastName}");
        }

        static void SeeCarInfo2()
        {
            Console.WriteLine("\t" +
                $"Car Make: {car2.CarMake}\n\t" +
                $"Car Model: {car2.CarModel}\n\t" +
                $"Car Year: {car2.CarYear}\n\t" +
                $"Car Owner: {car2.Owner.FirstName} {car2.Owner.LastName}");
        }

        static void GetPersonInfoLoop()
        {
            while (correct != true)
            {
                RegisterPersonInfo();
            }
        }

        static void GetCarInfoLoop()
        {
            while (correct != true)
            {
                RegisterCarInfo();
            }
        }

        static void AddCarToList()
        {
            

            foreach (Car car in carsList)
            {
                Console.WriteLine(car.Owner);
            }
        }
    }
}
