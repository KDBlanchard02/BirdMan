using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Birds
    {
        public string BirdType { get; set; }
        public int BirdScoreValue { get; set; }
        public Birds() { }

        public Birds(string birdType, int birdScoreValue)
        {
            BirdType = birdType;
            BirdScoreValue = birdScoreValue;
        }
    }
}
