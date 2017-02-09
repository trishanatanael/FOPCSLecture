using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSLecture
{
    using System;
    class Day4Quiz
    {
        public static void Main(string[] args)
        {
            bool wrongPIN = true;
            int numTries = 0;
            string PIN = "123456";

            Console.WriteLine("Welcome to the Bank of ISS");
            Console.Write("Enter your PIN:");

            while (wrongPIN && numTries < 3)
            {
                Console.Write("Enter your PIN:");
                string input = Console.ReadLine();
                numTries++;

                if (input == PIN)
                {
                    Console.WriteLine("PIN accepted. You can access your account now");
                }
                else
                {
                    Console.WriteLine("Incorrect PIN");
                    if (wrongPIN)
                    {
                    }
                }
            }

        }
    }
}
