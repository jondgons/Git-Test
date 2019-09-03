using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_input;
            int int_guess = -1;
            int rand_num;

            Console.WriteLine("I am thinking of a number between 0 and 100...");

            Random rand = new Random();
            rand_num = rand.Next(0, 100);

            while (int_guess != rand_num)
            {
                Console.Write("Please a guess a number: ");
                user_input = Console.ReadLine();
                int_guess = Convert.ToInt32(user_input);

                if (int_guess < 0 || int_guess > 100) // if number is out of bounds
                {
                    Console.WriteLine("Your number is out of bounds, please try again.");
                }
                else if (int_guess < rand_num) // if number is lower
                {
                    Console.WriteLine("Your guess is LOWER than my number.");
                }
                else if (int_guess > rand_num) //if number is higher
                {
                    Console.WriteLine("Your guess is HIGHER than my number.");
                }

            }

            Console.WriteLine("Congratulations! You guessed my number correctly!");
            Console.Write("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
