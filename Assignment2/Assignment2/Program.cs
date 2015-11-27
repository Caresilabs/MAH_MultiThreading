
using System;

namespace Assignment2
{
    /// <summary>
    /// A program that showcases on how to synchronize threads.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Reader/Writer Thread Synchronization";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
           
            var menu = new MainMenu();

            // Run main menu
            while (menu.Start());

            Console.ReadLine();
        }
    }
}
