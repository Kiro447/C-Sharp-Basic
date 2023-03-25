using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        enum Genre
        {
            Rock,
            Hip_hop,
            Techno,
            Classical
        }
        public Song (string title, int length)
        {
            Title = title;
            Length = length;
            
        }

    }
}
