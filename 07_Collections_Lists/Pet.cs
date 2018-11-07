using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists
{
    class Pet
    {
        public int LegCount { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public bool IsClean { get; set; }

        public Pet(int legs, string name, string breed, bool clean)
        {
            LegCount = legs;
            Name = name;
            Breed = breed;
            IsClean = clean;
        }
    }
}
