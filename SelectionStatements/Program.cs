using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            int myFave = r.Next(1,1000);
            Console.WriteLine("Guess my favorite number! ");
            int userNum = int.Parse(Console.ReadLine());
            if(userNum < myFave)
            {
                Console.WriteLine("You're too low!");
            }
            else if (userNum > myFave)
            {
                Console.WriteLine("You're too High!");
            }
            else
            {
                Console.WriteLine("You got it!!!");
            }
            Console.WriteLine("What's your favorite school subject?");
            string userFave = Console.ReadLine();
            switch (userFave)
            {
                case "History":
                    Console.WriteLine("History is classic!");
                    break;
                case "Science":
                    Console.WriteLine("Science is experimental!");
                    break;
                case "Math":
                    Console.WriteLine("Math counts!");
                    break;
                case "English":
                    Console.WriteLine("English always tells a story!");
                    break;
                case "Gym":
                    Console.WriteLine("Dodgeball is a hit!");
                    break;
                default:
                    Console.WriteLine("Isnt school great!");
                    break;
            }
            
        }
    }
}