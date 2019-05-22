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
        //return true required to stay in game.
        public bool ShowMenu()
        {
           
            
           
            if (firstPet == null)
            {
                //give option one and 9
                Console.WriteLine("Type 1 to create a pet.");
                Console.WriteLine("Type 9 to exit\n");
                 menuInput = Console.ReadLine();
                Console.Clear();
                switch (menuInput)
                {
                    case "1":
                        
                            Console.WriteLine("\nEnter your pet name:");
                            petName = Console.ReadLine();

                            Console.WriteLine("");
                            Console.WriteLine("Enter your pet species:");
                            petSpecies = Console.ReadLine();

                            firstPet = new Pet(petName, petSpecies);

                            Console.WriteLine("");
                            Console.WriteLine(firstPet.Name + " was added to the shelter!\n");

                           
                            break;
                        
                    case "9":
                        
                            return false;
                    default:
                        Console.WriteLine("type 1 or 9");
                        break;
                        
                }
            }
            else
            {
                Console.WriteLine("Type 1 to create a pet.");
                Console.WriteLine("Type 2 to show pet info.");
                Console.WriteLine("Type 3 to show pet status.");
                Console.WriteLine("Type 4 to feed your pet.");
                Console.WriteLine("Type 5 to play with your pet.");
                Console.WriteLine("Type 6 to play with your pet.");
                Console.WriteLine("Type 9 to exit\n");
                menuInput = Console.ReadLine();
                Console.Clear();
            }
            //if (menuInput == "1")
            //{

            //    Console.WriteLine("\nEnter your pet name:");
            //    petName = Console.ReadLine();

            //    Console.WriteLine("");
            //    Console.WriteLine("Enter your pet species:");
            //    petSpecies = Console.ReadLine();

            //    firstPet = new Pet(petName, petSpecies);

            //    Console.WriteLine("");
            //    Console.WriteLine(firstPet.Name + " was added to the shelter!\n");

            return true;

            //}
            //else if (menuInput == "2" && firstPet != null)
            //{
                
            //    firstPet.PetInfo();
                

            //    return true;

            //}
            //else if (menuInput == "3" && firstPet != null)
            //{
            //    firstPet.PetStatus();

            //    return true;
            //}
            //else if(menuInput=="4"&& firstPet !=null)
            //{
            //    firstPet.FeedPet();
            //    return true;
            //}
            //else if (menuInput == "5" && firstPet != null)
            //{
            //    firstPet.PlayWithPet();
            //    return true;
            //}
            //else if (menuInput == "6" && firstPet != null)
            //{
            //    firstPet.VetVisitPet();
            //    return true;
            //}
            //else if (menuInput == "9")
            //{
            //    return false;
            //}

            //else return true;

           


        }
    }
}
