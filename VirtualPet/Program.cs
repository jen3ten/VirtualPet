using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pet!");
            Console.WriteLine("Type in start to begin game. At any time, type exit to end game.");
            bool gameIsRunning = false;                                         
            string mainMenu = Console.ReadLine();
            if(mainMenu == "start")
            {
                gameIsRunning = true;
            }

            Menu menu = new Menu();

            while (gameIsRunning)
            {
                Console.WriteLine("Select from these menu options.");
                
                gameIsRunning = menu.ShowMenu();
            }
        }
    }
}
