using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string name = "Steven";

            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }

            int total = 1;
            while (total != 5)
            {
                Console.WriteLine(total);
                total++;
            }


            Console.ReadLine();
        }
    }
}
