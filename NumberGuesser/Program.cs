using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    //Main class
    class Program
    {
        //void is the return type ie no data is being returned
        //static means no instances

        static void Main(string[] args)
        {
            
            //Run Get App info function
            GetAppInfo();

            // Ask user's name
            GreetUser();

            

            while (true)
            {

                //Set correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);


                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number in numerical format");
                        Console.ResetColor();
                    }

                    //Cast to int and put in to guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber) ;
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, please try again");
                        Console.ResetColor();
                    }

                }

                //Output success message
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are correct!");
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    continue;
                }
                else if (answer == "n")
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Yann L.";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
            
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            // Get user's input
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }

        static void PrintColourMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

    }
}
