﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Menu
    {

        string petName = "";
        string petSpecies = "";
        Pet firstPet;              

        public bool ShowMenu()
        {
            Console.WriteLine("Type 1 to create a pet.");
            Console.WriteLine("Type 2 to show pet info.");
            Console.WriteLine("Type 3 to exit");
            string menuInput = Console.ReadLine();

            if (menuInput == "1")
            {
                Console.WriteLine("Enter your pet name:");
                petName = Console.ReadLine();

                Console.WriteLine("Enter your pet species:");
                petSpecies = Console.ReadLine();

                firstPet = new Pet(petName, petSpecies);

                Console.WriteLine(firstPet.Name + " was added to the shelter!");

                return true;

            }
            else if (menuInput == "2")
            {
                Console.WriteLine("Your pet name is " + firstPet.Name + " and your pet is a " + firstPet.Species + ".");

                return true;

            }
            else if (menuInput == "3")
            {
                return false;
            }

            else return true;

           


        }
    }
}
