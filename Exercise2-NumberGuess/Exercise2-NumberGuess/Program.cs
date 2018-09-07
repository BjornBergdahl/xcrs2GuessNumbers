using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doRun = false;
            GuessNumber newGame = new GuessNumber(doRun);
            newGame.PlayGame();
        }
    }
}
