using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = AddWholeNumbers(4, 5);
            string input = Console.ReadLine();

            int choice = ParseInput();
        }

        static int AddWholeNumbers(int number1, int number2)
        {
            int number3 = number1 + number2;
            return number3;
        }

        static int ParseInput()
        {
            string inputString = Console.ReadLine();
            int input = int.Parse(inputString);
            return input;
        }

        static int SubtractWholeNumbers(int number1, int number2)
        {
            int number3 = number1 - number2;
            return number3;
        }
    }
}
