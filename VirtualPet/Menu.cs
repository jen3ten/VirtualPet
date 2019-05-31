using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Menu
    {
        string menuInput;

        Shelter shelter = new Shelter("Your Shelter");

        bool gameIsRunning = false;

        public bool ShowMenu()
        {
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
                MainMenu();

                foreach (Organic element in shelter.listOfOrganicPets)
                {
                    element.OrganicStatsDecay();
                }

                foreach (Robotic element in shelter.listOfRoboticPets)
                {
                    element.RoboticStatsDecay();
                }
            }
            return true;
        }

        public void MainMenu()
        {
            Console.WriteLine("Type 1 to create a pet.");
            Console.WriteLine("Type 2 to select an individual pet.");
            Console.WriteLine("Type 3 to show shelter pets info.");
            Console.WriteLine("Type 4 to show status of all shelter pets.");
            Console.WriteLine("Type 5 to feed or oil all pets.");
            Console.WriteLine("Type 6 to play with all shelter pets.");
            Console.WriteLine("Type 7 to take all shelter pets to the vet or to the mechanic.");
            Console.WriteLine("Type 9 to exit\n");
            menuInput = Console.ReadLine();
            Console.Clear();

            switch (menuInput)
            {
                case "1": shelter.CreatePet();
                    break;

                case "2": IndividualPetMenu();
                    break;

                case "3": shelter.ViewAllPetList();
                    break;

                case "4": shelter.ViewAllPetStatus();
                    break;

                case "5":
                    Console.Clear();
                    foreach (Organic element in shelter.listOfOrganicPets)
                    {
                        element.FeedPet();
                    }

                    foreach (Robotic element in shelter.listOfRoboticPets)
                    {
                        element.OilPet();
                    }
                    break;

                case "6":
                    Console.Clear();
                    foreach (Organic element in shelter.listOfOrganicPets)
                    {
                        element.PlayWithPet();
                    }

                    foreach (Robotic element in shelter.listOfRoboticPets)
                    {
                        element.PlayWithPet();
                    }
                    break;

                case "7":
                    Console.Clear();
                    foreach (Organic element in shelter.listOfOrganicPets)
                    {
                        element.VetVisitPet();
                    }
                 
                    foreach (Robotic element in shelter.listOfRoboticPets)
                    {
                        element.MechanicVisitPet();
                    }
                    break;

                case "9": gameIsRunning = false;
                    break;

                default:
                    Console.WriteLine("\nplease select a number in the Menu.\n");
                    break;
            }
        }

        public void IndividualPetMenu()
        {
            Console.Clear();
            Console.WriteLine("Type 1 to interact with an organic pet,");
            Console.WriteLine("Type 2 to interact with an robotic pet.");
            string individualPetMenuChoice = Console.ReadLine();

            if (individualPetMenuChoice == "1")
            {   
                Console.WriteLine("Type the number of the pet you would like to choose.");
                shelter.IndividualOrganicPetList();

                int organicPetChoiceIndex = Convert.ToInt32(Console.ReadLine());
                Organic selectedOrganicPet = shelter.listOfOrganicPets[organicPetChoiceIndex - 1];

                while (menuInput == "2" && individualPetMenuChoice == "1")
                {
                    Console.WriteLine("You have selected" + selectedOrganicPet.Name + ".");
                    Console.WriteLine("What would you like to do?");

                    Console.WriteLine("\n 1. See pet info.");
                    Console.WriteLine(" 2. See pet status.");
                    Console.WriteLine(" 3. Feed pet.");
                    Console.WriteLine(" 4. Play with pet.");
                    Console.WriteLine(" 5. Take pet to the vet.");
                    Console.WriteLine(" 6. Adopt pet from shelter");
                    Console.WriteLine(" 7. Choose a different pet.");
                    Console.WriteLine(" 8. Return to main menu.");
                    string secondMenuInput = Console.ReadLine();

                    switch (secondMenuInput)
                    {
                        case "1": selectedOrganicPet.PetInfo();
                            break;

                        case "2": selectedOrganicPet.OrganicPetStatus();
                            break;

                        case "3": Console.Clear();
                                  selectedOrganicPet.FeedPet();
                            break;

                        case "4": Console.Clear();
                                  selectedOrganicPet.PlayWithPet();
                            break;

                        case "5": Console.Clear();
                                  selectedOrganicPet.VetVisitPet();
                            break;

                        case "6": shelter.RemoveFromShelterOrganicList(selectedOrganicPet);
                                  MainMenu();
                            break;

                        case "7": IndividualPetMenu();
                            break;

                        case "8": MainMenu();
                            break;
                    }
                }
            }

            else if (individualPetMenuChoice == "2")
            {
                Console.WriteLine("Type the number of the pet you would like to choose.");
                shelter.IndividualRoboticPetList();
                
                int roboticPetChoiceIndex = Convert.ToInt32(Console.ReadLine());
                Robotic selectedRoboticPet = shelter.listOfRoboticPets[roboticPetChoiceIndex - 1];

                while (menuInput == "2" && individualPetMenuChoice == "2")
                {
                    Console.WriteLine("You have selected" + selectedRoboticPet.Name + ".");
                    Console.WriteLine("What would you like to do?");

                    Console.WriteLine("\n 1. See pet info.");
                    Console.WriteLine(" 2. See pet status.");
                    Console.WriteLine(" 3. Oil pet.");
                    Console.WriteLine(" 4. Play with pet.");
                    Console.WriteLine(" 5. Take pet to the mechanic.");
                    Console.WriteLine(" 6. Adopt pet from shelter");
                    Console.WriteLine(" 7. Choose a different pet.");
                    Console.WriteLine(" 8. Return to main menu.");
                    string secondMenuInput = Console.ReadLine();

                    switch (secondMenuInput)
                    {
                        case "1": selectedRoboticPet.PetInfo();
                            break;

                        case "2": selectedRoboticPet.RoboticPetStatus();
                            break;

                        case "3": Console.Clear();
                                  selectedRoboticPet.OilPet();
                            break;

                        case "4": Console.Clear();
                                  selectedRoboticPet.PlayWithPet();
                            break;

                        case "5": Console.Clear();
                                  selectedRoboticPet.MechanicVisitPet();
                            break;

                        case "6": shelter.RemoveFromShelterRoboticList(selectedRoboticPet);
                                  MainMenu();
                            break;

                        case "7": IndividualPetMenu();
                            break;

                        case "8": MainMenu();
                            break;
                    }
                }
            }
        }
    }
}