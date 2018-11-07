using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists_Car_Challenge
{
    class Program
    {
        static List<Person> people = new List<Person>();
        static Person newPerson = new Person();

        static void Main(string[] args)
        {
            bool mainMenuRunning = true;
            while (mainMenuRunning)
            {
                Console.WriteLine("Welcome to Komodo Insurance!\n" +
                    "Please select an option.\n\t" +
                    "1. Register\n\t" +
                    "2. See Users\n\t" +
                    "3. Exit");
                string mainMenuInput = Console.ReadLine();
                switch (mainMenuInput)
                {
                    case "1":
                        Console.Clear();
                        RegisterPerson();
                        Console.Clear();
                        RegisterVehicle();
                        Console.Clear();
                        bool subMenuRunning = true;
                        while (subMenuRunning)
                        {
                            Console.Clear();
                            Console.WriteLine($"Thank you for choosing Komodo Insurance, {newPerson.FirstName}.\n" +
                                $"Please select an option below.\n\t" +
                                $"1. See User Information\n\t" +
                                $"2. Add Vehicle\n\t" +
                                $"3. Remove Vehicle\n\t" +
                                $"4. Sign Out");
                            string subMenuInput = Console.ReadLine();
                            switch (subMenuInput)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine($"User Information\n\t" +
                                        $"User Name: {newPerson.FirstName} {newPerson.LastName}\n\t" +
                                        $"User Age: {newPerson.PersonAge}");
                                    ListVehicles();
                                    Console.ReadLine();
                                    break;
                                case "2":
                                    bool addingVehicles = true;
                                    while (addingVehicles)
                                    {
                                        Console.Clear();
                                        RegisterVehicle();
                                        Console.WriteLine("Would you like to add another vehicle? (y/n)");
                                        addingVehicles = AnswerSelection();
                                    }
                                    break;
                                case "3":
                                    Console.Clear();
                                    ListVehicles();
                                    Console.WriteLine("Please select a vehicle to remove.");
                                    string carRemoveString = Console.ReadLine();
                                    int carRemove = int.Parse(carRemoveString);
                                    newPerson.CarList.RemoveAt(carRemove - 1);
                                    break;
                                case "4":
                                    subMenuRunning = false;
                                    break;
                                default:
                                    Console.WriteLine($"{subMenuInput} is not a valid input. Please try again.");
                                    break;
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("These are the registered users.");
                        int p = 0;
                        foreach (Person person in people)
                        {
                            p++;
                            Console.WriteLine(p + ".\t" + $"Name: {newPerson.FirstName} {newPerson.LastName}");
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        mainMenuRunning = false;
                        break;
                    default:
                        Console.WriteLine($"{mainMenuInput} is not a valid input. Please try again.");
                        break;
                }
            }
        }

        static bool AnswerSelection()
        {
            bool isValid = false;
            while (isValid != true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("That is not a valid input. Please try again.");
                        break;
                }
            }
            return false;
        }

        static void RegisterPerson()
        {
            newPerson = new Person();
            Console.WriteLine("To register as a user, please answer the following questions.");
            Console.WriteLine("What is your first name?");
            newPerson.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            newPerson.LastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            newPerson.PersonAge = ReturnPersonAge();

            people.Add(newPerson);
        }

        static void RegisterVehicle()
        {
            Car newCar = new Car();
            Console.WriteLine("To register a vehicle, please answer the following questions.");
            Console.WriteLine("What is the vehicle make?");
            newCar.CarMake = Console.ReadLine();
            Console.WriteLine("What is the vehicle model?");
            newCar.CarModel = Console.ReadLine();
            Console.WriteLine("What year is the vehicle?");
            newCar.CarAge = ReturnCarAge();
            Console.WriteLine("How many miles on the vehicle?");
            newCar.CarMiles = ReturnCarMiles();

            newPerson.CarList.Add(newCar);
        }

        static int ReturnPersonAge()
        {
            string personAgeString = Console.ReadLine();
            int personAgeInt = int.Parse(personAgeString);
            return personAgeInt;
        }

        static int ReturnCarAge()
        {
            string carAgeString = Console.ReadLine();
            int carAgeInt = int.Parse(carAgeString);
            int carAgeActual = DateTime.Now.Year - carAgeInt;
            return carAgeActual;
        }

        static double ReturnCarMiles()
        {
            string carMilesString = Console.ReadLine();
            double carMilesDouble = double.Parse(carMilesString);
            return carMilesDouble;
        }

        static void ListVehicles()
        {
            int i = 0;
            foreach (Car car in newPerson.CarList)
            {
                i++;
                Console.WriteLine(i + ".\t" + $"Make: {car.CarMake}\n\t" +
                    $"Model: {car.CarModel}\n\t" +
                    $"Age: {car.CarAge}\n\t" +
                    $"Miles: {car.CarMiles}");
                Console.WriteLine();
            }
        }
    }
}
