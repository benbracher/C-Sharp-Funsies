using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists_Challenge
{
    class StreamContent
    {
        public string ContentName { get; set; }
        public string ContentRating { get; set; }
        public string ContentGenre { get; set; }

        public StreamContent(string contentName, string contentRating, string contentGenre)
        {
            ContentName = contentName;
            ContentRating = contentRating;
            ContentGenre = contentGenre;
        }

        public StreamContent()
        {

        }
    }
}
