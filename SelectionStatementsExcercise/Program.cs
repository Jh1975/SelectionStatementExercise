using System;

namespace SelectionStatementsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 9;

            Console.WriteLine("Guess the favorite.Hint: below 10");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("Too LOW!!!!");
             }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("Too High!!");
            }   
            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("You were correct here is a cookie");
            }
            else
            {
                Console.WriteLine("Nevermind");

                { }
            String subject = "c#";

            Console.WriteLine("Choose a subject");
             String userSubject = Console.ReadLine();
            
            switch (userSubject)
            {
                case "C#":
                    Console.WriteLine("You are in the right class.");
                    break;
                case "Java":
                    Console.WriteLine("C# is better than Java.");
                    break;
                default:
                    Console.WriteLine("We teach coding here.");
                    break;

                }
            }
        }           
    }
}
