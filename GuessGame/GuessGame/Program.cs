using System;
using System.Threading;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Welcome to the Guess Game!!!===========");
            Console.WriteLine("You have to guess a number within 0 and 10");
            Console.WriteLine("You have only five lives! You miss a guess, you lose a life! \n Let's Begin...!!!");
            Thread.Sleep(10000);
            Console.Clear();
            GuessGame();
            
        }
        private static void GuessGame()
        {
            
            Random random = new Random();
            int generated = random.Next(1, 10);
            int points = 0;
            int playOrQuit;
            do
            {
                Console.WriteLine("\nChoose 1 to play, 2 to quit");
                playOrQuit = int.Parse(Console.ReadLine());
                if (playOrQuit == 2) break;
                bool incorrect = true;
                int counter = 5;
                do
                {
                    Console.Write("\nGuess a Number within 1 and 10:");
                    int choice = int.Parse(Console.ReadLine());
                    counter--;
                    if (choice == generated)
                    {
                        incorrect = false;
                    }
                    else
                    {
                        Console.WriteLine("You guessed wrong. You just lost a life. \n You have {0} live(s) left.", counter);
                    }

                } while (incorrect && counter > 0);
                if (counter == 0)
                {
                    Console.WriteLine("YOU LOSE!!! Thanks for playing the game.");
                }
                else
                {
                    Console.WriteLine("Correct! You've earned 5 points");
                    points += 5;
                }
            } while (playOrQuit == 1);
            Console.WriteLine("\nThanks for trying out this game. See you next time");
        }
    }
}
