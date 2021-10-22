using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a welcome method,
            WelcomeToApp();

            //a method to ask for the user's name
            string firstName = AskQuestion("What is your first name: ");
            string lastName = AskQuestion("What is yout last name: ");

            //and another to tell that user "Hello __".
            WelomeToUser(firstName, lastName); 


            Console.ReadLine();
        }

        private static void WelcomeToApp()
        {
            Console.WriteLine("********** Welcome to this App **********");
        }

        private static string AskQuestion(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }

        private static void WelomeToUser (string firstName, string lastName)
        {
            Console.WriteLine();
            Console.WriteLine($" Hello {firstName} {lastName}.");
        }
    }
}