using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Repository_Pattern
{
    class StreamingContent
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
        public bool IsMature { get; set; }

        public StreamingContent(string title, string genre, int rating, bool isMature)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            IsMature = isMature;
        }

        public StreamingContent()
        {

        }
    }
}
