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
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine(String.Format("{0,3}{1,12}{2,12}", "Number", "Squared", "Cubed"));
                    Console.WriteLine("--------------------------------");
                    for(int i = 1; i <= number; i++)
                    {
                        Console.WriteLine(String.Format("{0,4}{1,12}{2,13}", $"{i}", $"{i*i}", $"{i*i*i}"));
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
                            Console.WriteLine("");
                            Console.WriteLine("Sorry, I dont understand that response. Please try again.");
                            Console.WriteLine("");
                            runningAgain = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("");
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
