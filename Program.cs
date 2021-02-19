using System;

namespace Gallows
{
    class Program
    {
        static void Main(string[] args)
        {
            var trueWord = "deadline";
            var attempts = 4;
            Console.SetCursorPosition(80, 2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("What we don't like :  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(80, 4);
            Console.WriteLine($"You have {attempts} attempts");
            Console.SetCursorPosition(70, 10);
            var user = Console.ReadLine();
            while (attempts > 0)
            {
                if (user.ToLower() == trueWord)
                {
                    Console.SetCursorPosition(80, 2);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Congrarulations, you guessed it");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    attempts--;    
                    Console.SetCursorPosition(60, 15);
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong. Try again. You have {attempts} attempts : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(70, 10);
                    user = Console.ReadLine();
                }
            }
        }
    }
}
