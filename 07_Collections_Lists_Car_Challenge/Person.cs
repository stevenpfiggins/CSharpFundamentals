using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists_Car_Challenge
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonAge { get; set; }
        public bool HadAccident { get; set; }
        public List<Car> CarList { get; set; }

        public Person()
        {
            CarList = new List<Car>();
        }
    }
}
