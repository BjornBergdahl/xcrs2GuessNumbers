using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_NumberGuess
{
    class GuessNumber
    {
        private static bool runGame;
        
        private HighScore scoreList;

        // constructor with a bool for checking for the game to continue.
        public GuessNumber(bool doRun)
        {
            runGame = doRun;
        }


        public void PlayGame()
        {
            Random random = new Random();
            int theNumber = random.Next(1, 101);
            int guessed = 0;
            Score gameScore = new Score();
            int counter = 0;
            do
            {
                Console.WriteLine("Gissa ett tal mellan 1 och 100: ");

                if(Int32.TryParse(Console.ReadLine(),out int result))
                {
                    guessed = result;
                    counter++;
                    if (guessed < theNumber)
                    {
                        Console.WriteLine("För lågt, gissa igen!");
                    }
                    else if (guessed > theNumber)
                    {
                        Console.WriteLine("För högt, gissa igen!");
                    }
                    else
                    {
                        Console.WriteLine("Grattis, rätt gissat på {0} försök.", guessed);
                    }

                }
                else
                {
                    Console.WriteLine("Det var inte ett tal, prova igen!");
                }
                    

            }
            while (guessed != theNumber);
            Console.WriteLine("Vill du spela igen? ja/nej");
            string ans = Console.ReadLine();
            if (ans.Equals("ja")||ans.Equals("Ja"))
            {
                GuessNumber newGame = new GuessNumber(true);
                gameScore.Name = "";
                newGame.PlayGame();

            }
            else
            {

            }



        }

        
    }



}








        //public static void GissaMer()
        //{
        //    int antalGissningar = 0;
        //    int loops = 0;
        //    String ans;
        //    ArrayList gissade = new ArrayList();
        //    do
        //    {
        //        gissade.Add(GuessNumber(antalGissningar));
        //        Console.WriteLine("Vill du gissa mer? Y/N?");
        //        ans = Console.ReadLine();
        //        loops++;

        //    }
        //    while (!ans.Equals("N"));
        //    if (loops >= 3)
        //    {
        //        Console.WriteLine("Dina matcher");
        //        foreach (int tal in gissade)
        //        {
        //            Console.WriteLine("Antal gissningar: {0}", tal);
        //        }
        //    }


        //}
    }
}
