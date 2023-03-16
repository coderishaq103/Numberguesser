using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_guesser
{
    //Main class
    internal class Program
    {
        //Entry point
        static void Main(string[] args)
        {
           
            GetAppInfo(); //funtion/method to get app info

            GreetUser(); //ask for user name and say hello

            while (true)
            {

            

            //init correct number

     
            //create new random object
            //int correctnumber = 7;
            Random random= new Random();

            int correctnumber = random.Next(1, 10);

            //init guess=0

            int guess = 0;


            Console.WriteLine("Guess a number between 1 and 10");

            //while guess is not correct
            while (guess!= correctnumber) {
            //get usr input
            string input= Console.ReadLine();
                //make sure its a number
                if(!int.TryParse(input, out guess)) 
                {
                        ChangeColor(ConsoleColor.Red, "Please enter an actual number");

                    //keep going
                   continue;
                }
                //cast to int and put in guess

                guess = Int32.Parse(input);

                // match guess to correct number

                if (guess != correctnumber)
                {

                ChangeColor(ConsoleColor.Red, "Wrong number, please try again");
                   
                }
            }

                //Output success message

                ChangeColor(ConsoleColor.Yellow, "You are correct");
            
            Console.ReadLine();

                //ask to play again
                Console.WriteLine("Play again? [Y or N]");
                string answer= Console.ReadLine().ToUpper();
                if (answer =="Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }

            }
        }
        static void GetAppInfo() 
        {
            //start here
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Raja Ishaq";

            //change text color

            Console.ForegroundColor = ConsoleColor.Green;

            //write app info

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color

            Console.ResetColor();
        }
        static void GreetUser()
        {
            //ask user name

            Console.WriteLine("What is your name?");

            //get user input

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }
        static void ChangeColor(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //tell user its not a number

            Console.WriteLine(message);
            //reset text color

            Console.ResetColor();
        }
    }
}
