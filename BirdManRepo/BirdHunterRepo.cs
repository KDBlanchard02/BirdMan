using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary;
using System.Text;
using System.Threading.Tasks;

namespace BirdManRepo
{
    public class BirdHunterRepo
    {
        // CRUD

        //Create
        private readonly List<BirdHunter> _birdHunters = new List<BirdHunter>();

        public void AddBirdToDirectory(BirdHunter birdHunter)
        {
            _birdHunters.Add(birdHunter);
        }

        //Read
        public BirdHunter GetBirdHunter(string birdHunterType)
        {
            foreach (var hunterType in _birdHunters)
            {
                if (hunterType.BirdHunterType == birdHunterType)
                {
                    return hunterType;
                }
            }
            return null;
        }
    }
}
