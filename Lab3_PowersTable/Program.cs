using System;

namespace Lab3_PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runningProgram = true;
            bool runningAgain;
            bool isANumber;
            string userNumber;
            string userAnswer;


            Console.WriteLine("Welcome to the Powers Table Application!");
            Console.WriteLine("");

            while (runningProgram)
            {
                Console.WriteLine("Enter any whole number to see it's squared and cubed values!");
                Console.Write("Enter your number: ");
                userNumber = Console.ReadLine();
                Console.WriteLine("");
                isANumber = int.TryParse(userNumber, out int number);
                if(isANumber)
                {
                    if(number > 0 && number <= 1290)
                    {
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine(String.Format("{0,3}{1,12}{2,13}", "Number", "Squared", "Cubed"));
                        Console.WriteLine("--------------------------------");
                        for (int i = 1; i <= number; i++)
                        {
                            Console.WriteLine(String.Format("{0,6}{1,12}{2,13}", $"{i}", $"{i * i}", $"{i * i * i}"));
                        }
                        Console.WriteLine("");

                        runningAgain = true;
                        while (runningAgain)
                        {
                            Console.WriteLine("Would you like to do another Powers Table Calculation?");
                            Console.WriteLine("Enter 'y' or 'yes' to calculate again, or 'n' or 'no' to exit.");
                            userAnswer = Console.ReadLine().ToLower();
                            Console.WriteLine("");
                            if (userAnswer == "n" || userAnswer == "no")
                            {
                                runningAgain = false;
                                runningProgram = false;
                            }
                            else if (userAnswer == "y" || userAnswer == "yes")
                            {
                                Console.Clear();
                                runningAgain = false;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, I dont understand that response. Please try again.");
                                Console.WriteLine("");
                                runningAgain = true;
                            }
                        }
                    }
                    else if(number > 1290)
                    {
                        Console.WriteLine("Sorry, that number is too large to have it's cubed value stored in an integer " +
                            "variable! Please try again, making sure to enter a number less than 1291 this time.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, this exercise requires numbers greater than zero. Please try again.");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that doesnt appear to be a whole number. Please try again.");
                    Console.WriteLine("");
                    runningProgram = true;
                }
            }
            Console.WriteLine("Thank you for using the Powers Table Application!");
            Console.WriteLine("Goodbye...");
        }
    }
}
