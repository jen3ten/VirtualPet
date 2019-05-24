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
                            IndividualPetMenu();                            
                            break;

                        case "3":
                            shelter.ViewPetList();
                            break;
                        case "4":
                            shelter.ViewPetStatus();
                            break;


                        case "5":
                            foreach(Pet element in shelter.listOfPets)
                            {
                                element.FeedPet();
                            }
                            break;

                        case "6":
                            foreach(Pet element in shelter.listOfPets)
                            {
                                element.PlayWithPet();
                            }
                            break;

                        case "7":
                            foreach(Pet element in shelter.listOfPets)
                            {
                                element.VetVisitPet();
                            }
                            break;
                                                   
                        case "9":
                            return false;

                        default:
                            Console.WriteLine("\nplease select a number in the Menu.\n");
                            break;

                    } //end switch

                }//
            }
            return true;
           
        }
        
        public void IndividualPetMenu()
        {
            Console.WriteLine("Type the number of the pet you want to choose.");
            shelter.IndividualPetList();

            int petChoiceIndex = Convert.ToInt32(Console.ReadLine());
            Pet selectedPet = shelter.listOfPets[petChoiceIndex - 1];
            while (menuInput =="2")
            {

            Console.WriteLine("You have selected" + selectedPet.Name + ".");
            Console.WriteLine("What would you like to do?");

            Console.WriteLine("\n 1. See pet info.");
            Console.WriteLine(" 2. See pet status.");
            Console.WriteLine(" 3. Feed pet.");
            Console.WriteLine(" 4. Play with pet.");
            Console.WriteLine(" 5. Take pet to the vet.");
            Console.WriteLine(" 6. Choose a different pet.");
            Console.WriteLine(" 7. Return to main menu.");


            string secondMenuInput = Console.ReadLine();
            switch (secondMenuInput)
            {
                case "1": selectedPet.PetInfo();
                    break;
                case "2": selectedPet.PetStatus();
                    break;
                case "3": selectedPet.FeedPet();
                    break;
                case "4": selectedPet.PlayWithPet();
                    break;
                case "5": selectedPet.VetVisitPet();
                    break;
                case "6": IndividualPetMenu();
                    break;
                case "7": ShowMenu();
                    break;
            }

            }





        }

      
    }
}