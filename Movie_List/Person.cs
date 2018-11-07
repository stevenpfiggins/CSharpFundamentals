using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_List
{
    class Person
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public int UserAge { get; set; }
        public List<Movie> MovieList { get; set; }

        public Person(string userFirstName, string userLastName, int userAge, List<Movie> movieList)
        {
            UserFirstName = userFirstName;
            UserLastName = userLastName;
            UserAge = userAge;
            MovieList = movieList;
        }

        public Person()
        {
            MovieList = new List<Movie>();
        }
    }
}
