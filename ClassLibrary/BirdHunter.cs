using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BirdHunter
    {
        public int NumberOfEncounters { get; set; }
        public string BirdHunterType { get; set; }
        public BirdHunter() { }
        public BirdHunter(int numberOfEncounters, string birdHunterType)
        {
            NumberOfEncounters = numberOfEncounters;
            BirdHunterType = birdHunterType;
        }
    }
}
