using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_NumberGuess
{
    class Score
    {
        // No implemented constructor, default will do fine!
        private string name;
        private int guess;

        public int Guess { get => guess; set => guess = value; }
        public string Name { get => name; set => name = value; }
    }
}
