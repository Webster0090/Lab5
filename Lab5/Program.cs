using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            Console.WriteLine("Welcome to the factorial calculator!");
            do
            {
                
                Console.Write("Please enter a number between 1-10: ");
                long userNum = long.Parse(Console.ReadLine());

                Console.WriteLine("{0} factored out is {1}.", userNum, getFactorial(userNum));

                Console.Write("Would you like to continue (y/n): ");
                response = Console.ReadLine().ToLower();


            }
            while (YesOrNo(response));
            Console.ReadLine();

        }

        public static bool YesOrNo(string response)
        {

            while (response == "y")
            {
                return true;
            }

            if (response == "n")
            {
                Console.WriteLine("Exiting program...");
                return false;
            }
            else
            {
                Console.WriteLine("Not a valid entry, please try again later.");
                response = Console.ReadLine().ToLower();
                return false;
            }

        }

        public static long getFactorial(long num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * getFactorial(num - 1);



        }
    }
}
