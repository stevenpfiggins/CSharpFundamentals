using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_03
{
    class Customer
    {
        public string Name { get; set; }
        public int CustomerAge { get; set; }
        public decimal TotalPremium { get; set; }
        public bool HadAccident { get; set; }

        public Customer(string name, int customerAge, decimal totalPremium, bool hadAccident)
        {
            Name = name;
            CustomerAge = customerAge;
            TotalPremium = totalPremium;
            HadAccident = hadAccident;
        }

        public Customer()
        {

        }
    }
}
