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

            string gameInput;
            Menu menu = new Menu();

            while (gameIsRunning)
            {
                Console.WriteLine("Select from these menu options.");
                
                menu.ShowMenu();

                gameInput = Console.ReadLine();
                            
                if (gameInput == "exit")
                    gameIsRunning = false;
            }
        }
    }
}
