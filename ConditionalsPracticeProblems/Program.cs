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
                Console.WriteLine("{0} better luck next time!",playersNumber);

            }

            
            //if the test fails print test number
        }
    }
}
