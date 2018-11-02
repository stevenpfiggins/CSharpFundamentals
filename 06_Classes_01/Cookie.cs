using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes_01
{
    public class Cookie
    {
        public double SugarAmount { get; set; }
        public double FlourAmount { get; set; }
        public string CookieType { get; set; }
        public string CookieShape { get; set; }
        public bool HasNuts { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
