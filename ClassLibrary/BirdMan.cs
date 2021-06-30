using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BirdMan
    {
        public int Score { get; set; }
        public int NumberOfLives { get; set; }

        public BirdMan()
        {

        }

        public BirdMan(int score, int numberOfLives)
        {
            Score = score;
            NumberOfLives = numberOfLives;
        }
    }
}
