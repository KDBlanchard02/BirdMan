using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdManRepo
{
    public class BirdRepo
    {
        // CRUD

        //Create
        private readonly List<Birds> _birds = new List<Birds>();

        public void AddBirdToDirectory(Birds birds)
        {
            _birds.Add(birds);
        }

        //Read
        public Birds GetBird(string birdType)
        {
            foreach (var typeOfBird in _birds)
            {
                if (typeOfBird.BirdType == birdType)
                {
                    return typeOfBird;
                }  
            }
            return null;
        }
    }
}
