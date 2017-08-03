//Joshua Pickenpaugh
//August 3rd, 2017
//Guess a Num. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumGame();
        }

        public static void RandomNumGame()
        {
            int intRanNum = 0;
            int intUserGuess = 0;
            char chrUserChoice;
            bool loop = true;

            do
            {
                Random randNum = new Random();
                intRanNum = randNum.Next(10);

                do
                {
                    Console.Write("Guess a number (0-10): ");
                    intUserGuess = Convert.ToInt32(Console.ReadLine());

                    if (intUserGuess == intRanNum)
                    {
                        Console.WriteLine("You guessed it!");
                    }
                    else if (intUserGuess < intRanNum)
                    {
                        Console.WriteLine("Your guess is too low.");
                    }
                    else if (intUserGuess > intRanNum)
                    {
                        Console.WriteLine("Your guess is too high.");
                    }
                } while (intUserGuess != intRanNum);

                //
                Console.Write("Play again? Y or N: ");
                chrUserChoice = Convert.ToChar(Console.ReadLine());
                if (chrUserChoice == 'N' || chrUserChoice == 'n')
                {
                    loop = false;
                }
            }
            while (loop);
        }

    }
}
