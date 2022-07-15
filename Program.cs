using System;

//namespace
namespace ConsoleApp1
{
    //Main Class
    internal class Program
    {   
        //Entry Point Method
        static void Main(string[] args)
        {
            //appInfo give information of app
            appInfo();

            // greet the user
            greetUser();
            
            string answer = "Y";
            label:
            while (answer == "Y")
            {
                //Init Correct number
                //int correctNumber = 7;

                //new random number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Guess 
                printColorMsg(ConsoleColor.DarkCyan, "Guess a number between 1 to 10 \n");

                //loop for user to guess
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //validate input
                    if (!int.TryParse(input, out guess))
                    {
                        printColorMsg(ConsoleColor.Red, "Please enter an actual number....");
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        printColorMsg(ConsoleColor.Red, "Wrong number guess again.... ");
                    }

                }

                //Output Success msg
                printColorMsg(ConsoleColor.DarkYellow, "You are CORRECT!....");

                //play again

                while (true)
                {
                    Console.WriteLine("Do you want to play again ? [Y or N]");
                    answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        goto label;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        printColorMsg(ConsoleColor.Red,"Choose Valid option");
                    }
                }
            }

        }

        static void appInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Naman Mehta";

            printColorMsg(ConsoleColor.DarkGreen, "Number Guesser : Version 1.0.0 by Naman Mehta");
        }

        static void greetUser()
        {
            //Ask user input
            Console.WriteLine("What is your name ? ");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hola! {0}, Let play a game.... \n", inputName);
        }

        //print color msg
        static void printColorMsg(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
