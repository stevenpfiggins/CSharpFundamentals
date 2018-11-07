using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists
{
    class Program
    {

        static Person firstPerson = new Person();

        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            firstPerson.FullName = Console.ReadLine();

            Console.WriteLine("Do you have a car? (y/n)");
            string input = Console.ReadLine();
            bool addingCars = true;
            switch (input)
            {
                case "y":
                    RegisterCar();
                    break;
                case "n":
                    addingCars = false;
                    break;
                default:
                    addingCars = false;
                    break;
            }

            while (addingCars == true)
            {
                Console.WriteLine("Do you want to add another car? (y/n)");
                input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        RegisterCar();
                        break;
                    case "n":
                        addingCars = false;
                        break;
                    default:
                        addingCars = false;
                        break;
                }
            }

            Console.ReadLine();

            //List<string> listOfStrings = new List<string>();

            //List<Pet> listOfPets = new List<Pet>();
            //Pet firstPet = new Pet(25, "Ouch", "???", false);
            //Pet secondPet = new Pet(1000, "Milly", "Millipede", false);
            //Pet thirdPet = new Pet(1, "Doug", "Unicycle", true);

            //listOfPets.Add(firstPet);
            //listOfPets.Add(secondPet);
            //listOfPets.Add(thirdPet);

            //listOfPets.Remove(firstPet);

            //foreach (Pet pet in listOfPets)
            //{
            //    Console.WriteLine(pet.Name);
            //}

            //Console.ReadLine();

        }

        static void RegisterCar()
        {
            Car newCar = new Car();
            Console.WriteLine("What is the make of your car?");
            newCar.CarMake = Console.ReadLine();
            Console.WriteLine("What is the model of your car?");
            newCar.CarModel = Console.ReadLine();
            firstPerson.CarList.Add(newCar);
        }

        static void CheckAnswer()
        {

        }
    }
}
