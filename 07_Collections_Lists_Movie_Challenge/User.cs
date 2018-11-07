using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists_Movie_Challenge
{
    class User
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public List<Video> VideoList { get; set; }

        public User()
        {
            VideoList = new List<Video>();
        }
    }
}
