using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool isTall = true;
            int age = 23;
            float floating = 123.4123f;
            double number = 939.494d;
            decimal number2 = 12345.1234567789m;
            //Int16 == short
            //Int64 == long
            long number3 = 123;

            char character = 'a';
            string word = "This is a string";

            Console.WriteLine("How old are you?");
            string yourAge = Console.ReadLine();
            Console.WriteLine("You entered the age " + yourAge);
            Console.ReadLine();*/

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            string ageString = Console.ReadLine();
            int ageInt = int.Parse(ageString);

            Console.WriteLine("What is your email address?");
            string email = Console.ReadLine();

            if (ageInt < 18)
            {
                Console.WriteLine("I'm sorry. You are not old enough to view this content.");
            }

            else
            {
                Console.WriteLine("Hello, " + firstName + " " + lastName + ". You are " + ageInt + " years old, and you can be contacted at " + email + ".");
            }

            Console.ReadLine();


        }
    }
}
