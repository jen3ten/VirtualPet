using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Menu
    {
        string petName = "";
        string petSpecies = "";
        string menuInput;
        Pet firstPet;
        Shelter shelter = new Shelter("Your Shelter");
        
        public bool ShowMenu()
        {
            bool gameIsRunning = false;

            Console.WriteLine("Welcome to Virtual Pet!");
            Console.WriteLine("Type in start to begin game. Type exit to end game.");
            string mainMenu = Console.ReadLine();
            Console.Clear();

            if (mainMenu == "start")
            {
                gameIsRunning = true;
            }

            else if (mainMenu == "exit")
            {
                gameIsRunning = false;
            }

            else
            {
                ShowMenu();
            }


            while (gameIsRunning)
            {

                Console.WriteLine("Select from these menu options.");

                if (firstPet == null)
                {

                    Console.WriteLine("Type 1 to create a pet.");
                    Console.WriteLine("Type 9 to exit\n");
                    menuInput = Console.ReadLine();
                    Console.Clear();

                    switch (menuInput)
                    {
                        case "1":

                            Console.WriteLine("\nEnter your pet name:");
                            petName = Console.ReadLine();

                            Console.WriteLine("\nEnter your pet species:");
                            petSpecies = Console.ReadLine();

                            firstPet = new Pet(petName, petSpecies);
                            shelter.AddToShelterList(firstPet);

                            Console.WriteLine("");
                            Console.WriteLine(firstPet.Name + " was added to the shelter!\n");
                            break;

                        case "9":
                            return false;

                        default:
                            Console.WriteLine("Please type a 1 or 9.\n");
                            break;
                    }
                }

                else if (firstPet != null)
                {

                    Console.WriteLine("Type 1 to create a pet.");
                    Console.WriteLine("Type 2 to select an individual pet.");
                    Console.WriteLine("Type 3 to show shelter pets info.");
                    Console.WriteLine("Type 4 to show status of all shelter pets.");
                    Console.WriteLine("Type 5 to feed all pets.");
                    Console.WriteLine("Type 6 to play with all shelter pets.");
                    Console.WriteLine("Type 7 to take all shelter pets to the vet.");
                    Console.WriteLine("Type 9 to exit\n");
                    menuInput = Console.ReadLine();
                    Console.Clear();

                    switch (menuInput)
                    {
                        case "1":

                            Console.WriteLine("\nEnter your pet name:");
                            petName = Console.ReadLine();

                            Console.WriteLine("\nEnter your pet species:");
                            petSpecies = Console.ReadLine();

                            firstPet = new Pet(petName, petSpecies);
                            shelter.AddToShelterList(firstPet);

                            Console.WriteLine("");
                            Console.WriteLine(firstPet.Name + " was added to the shelter!\n");

                            break;

                        case "2":
                            shelter.ViewPetList();
                            break;
                            
                        case "3":
                            firstPet.PetStatus();
                            break;

                        case "4":
                            firstPet.FeedPet();
                            break;

                        case "5":
                            firstPet.PlayWithPet();
                            break;

                        case "6":
                            firstPet.VetVisitPet();
                            break;

                        case "7":
                            IndividualPetMenu();
                            break;

                        case "9":
                            return false;

                        default:
                            Console.WriteLine("\nplease select a number in the Menu.\n");
                            break;

                    }

                }
            }
            return true;
        }
        public void IndividualPetMenu()
        {
            Console.WriteLine("Select which pet you want.");
            shelter.IndividualPetList();
            
            string input = Console.ReadLine();
            switch (input)
            {
               case  
            }

        }
    }
}