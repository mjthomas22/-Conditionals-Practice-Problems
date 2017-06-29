using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsPracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fizz! Buzz! or Bust!!!");
            Console.WriteLine("To play we are going to need you to pick two numbers.");

            //Ask user for 2 numbers 
            Console.WriteLine("Please kindly enter the first number, and remember whole numbers only please.");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Now please enter your second number.");
            int secondNumber = int.Parse(Console.ReadLine());

            //Player picks his number
            Console.WriteLine("Now that you have picked your first two numbers it all comes down to this!");
            Console.WriteLine("Please pick a special number to see if you Fizz! Buzz! or Bust!");
            int playersNumber = int.Parse(Console.ReadLine());

            //assign one for fizz and buzz

            double fizz = playersNumber % firstNumber;
            double buzz = playersNumber % secondNumber;

            //test if numbers are multiples for fizz and buzz
            if (fizz == 0 && buzz == 0)
            {
                Console.WriteLine("FIZZBUZZ!");
            }
            else if (fizz == 0)
            {
                Console.WriteLine("FIZZ!");
            }
            else if (buzz == 0)
            {
                Console.WriteLine("BUZZ!");
            }
            else
            {
                Console.WriteLine("{0} better luck next time!", playersNumber);

            }

            //Code are these numbers equal
            Console.WriteLine("Have you ever been unsure on whether two integers are equal, wonder no more.");

            //Ask the user for two integers
            Console.WriteLine("Please enter the first integer in question.");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second integer in question.");
            int second = int.Parse(Console.ReadLine());

            //check to see if they are equal and inform the user if they are equal or not
            if (first == second)
            {
                Console.WriteLine("The integers {0} and {1} are in fact equal.", first, second);
            }
            else
            {
                Console.WriteLine("The integers {0} and {1} are in fact not equal.", first, second);
            }

            //ask the user for a number
            Console.WriteLine("Please give me a number.");
            double eoNumber = double.Parse(Console.ReadLine());

            double numberCheck = eoNumber % 2;

            if (numberCheck == 0)
            {
                Console.WriteLine("The number {0} is even.", eoNumber);
            }
            else
            {
                Console.WriteLine("The number {0} is odd.", eoNumber);
            }

            //tell them if that number is odd or even

   
        }
    }
}
