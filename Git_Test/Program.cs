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
            int lower;
            int upper;

            Console.WriteLine("I am thinking of a number between x and y...");

            // asks for lower bound
            Console.WriteLine("Please input a value for x: ");
            user_input = Console.ReadLine();
            lower = Convert.ToInt32(user_input);

            // asks for upper bound
            Console.WriteLine("Please input a value for y: ");
            user_input = Console.ReadLine();
            upper = Convert.ToInt32(user_input);

            Console.WriteLine("I am now thinking of a number between " + lower + " and " + upper + "...");

            // seeds rng
            Random rand = new Random();
            rand_num = rand.Next(lower, upper);

            while (int_guess != rand_num)
            {
                Console.Write("Please a guess a number: ");
                user_input = Console.ReadLine();
                int_guess = Convert.ToInt32(user_input);

                if (int_guess < lower || int_guess > upper) // if number is out of bounds
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

            Console.WriteLine("Congratulations! You guessed my number (" + rand_num + ") correctly!");
            Console.Write("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
