using System;

namespace ChallengeWeekTwo
{

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select choose two whole numbers from 0 to 999 to add together.");

            int firstNumber = number(Console.ReadLine());
            int secondNumber = number(Console.ReadLine());
            int total = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber} = {total}");    
        }
        private static int number(string userInput)
        {
            int numberInput;
            bool numOrNot = int.TryParse(userInput, out numberInput);

            while (numOrNot != true || numberInput >= 1000 || numberInput < 0 || userInput == null)
            {
                Console.WriteLine($"Your choice of number, {userInput}, was an invalid number.\nPlease use a whole number from 0 to 999.");
                userInput = Console.ReadLine();
                numOrNot = int.TryParse(userInput, out numberInput);
            }
               
            return numberInput;
        } 
    }
}
