using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdManRepo
{
    public class BirdManRepo
    {
        // CRUD

        //Create
        private readonly List<BirdMan> _birdMan = new List<BirdMan>();
        public void AddNewBirdMan(BirdMan birdMan)
        {
            _birdMan.Add(birdMan);
        }

        //Read 
        public List<BirdMan> GetBirdMan()
        {
            return _birdMan;
        }


    }
}
