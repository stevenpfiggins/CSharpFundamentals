using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling on a scale of 1-5?");
            string feeling = Console.ReadLine();
            int input = int.Parse(feeling);

            switch (input)
            {
                case 1:
                    Console.WriteLine("Oh no, that's terrible");
                    break;
                case 2:
                    Console.WriteLine("Feels bad, man");
                    break;
                case 3:
                    Console.WriteLine("That's chill");
                    break;
                case 4:
                    Console.WriteLine("Niiiice");
                    break;
                case 5:
                    Console.WriteLine("That's awesome");
                    break;
                default:
                    Console.WriteLine("I'm sorry, that doesn't fit in our parameters");
                    break;
            }



            /*if(input == 1)
            {
                Console.WriteLine("That's a bummer, man");
            }

            else if (input == 2)
            {
                Console.WriteLine("I hope things get better!");
            }

            else if (input == 3)
            {
                Console.WriteLine("Sounds pretty chill");
            }

            else if (input == 4)
            {
                Console.WriteLine("Niiiice");
            }

            else if (input == 5)
            {
                Console.WriteLine("Super!");
            }

            else
            {
                Console.WriteLine("I'm sorry, that doesn't fit into our parameters");
            }*/

            Console.ReadLine();
        }
    }
}
