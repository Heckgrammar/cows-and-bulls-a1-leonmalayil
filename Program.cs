using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random();
            int num;
            do
            {
            num = random.Next(1000, 10000);
            } 
            while (num.ToString().Distinct().Count() < 4 || num.ToString()[0] == '0');
             int cows, bulls;
            do
            {
            Console.WriteLine("Enter a 4 digit number: ");
            string userGuess = Console.ReadLine();
            while (userGuess.Length != 4 || userGuess[0] == '0' || userGuess.Distinct().Count() < 4)
            {
            Console.WriteLine("Invalid guess. Please enter again (4 digits, and don't start with zero): ");
            userGuess = Console.ReadLine();
            }
            cows = 0;
            bulls = 0;
            for (int i = 0; i < 4; i++)
            {
            if (userGuess[i] == num.ToString()[i])
            bulls++;
            else if (num.ToString().Contains(userGuess[i]))
            cows++;
            }
            Console.WriteLine($"Cows: {cows}, Bulls: {bulls}");
            }
            while (bulls != 4);
            Console.WriteLine("Well done! You guessed it right!");
        }
    }
}
