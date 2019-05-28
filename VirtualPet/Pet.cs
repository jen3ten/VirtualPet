using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Pet
    {
        //Shelter shelter;
        //string petName = "";
        //string petSpecies = "";
     
        public string Name;
        public string Species;
        public int Hunger;
        public int Boredom;
        public int Health;

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 50;
            Boredom = 50;
            Health = 75;
        }
        //public void CreatePet()
        //{
            
        //    Pet firstPet;
            
        //    Console.WriteLine("\nEnter your pet name:");
        //    petName = Console.ReadLine();

        //    Console.WriteLine("\nEnter your pet species:");
        //    petSpecies = Console.ReadLine();

        //    firstPet =new Pet(petName, petSpecies);
        //    shelter.AddToShelterList(firstPet);

        //    Console.WriteLine("");
        //    Console.WriteLine(firstPet.Name + " was added to the shelter!\n");
        //}
        public void FeedPet()
        {
            Console.WriteLine("\nyou have fed your pet");
            Console.WriteLine("hunger has lowered by 1\n");
            this.Hunger -= 1;
        }
        public void PlayWithPet()
        {
            Console.WriteLine("\nyou have played with your pet");
            Console.WriteLine("boredom has lowered by 1");
            Console.WriteLine("Health has increased by 1\n");

            this.Boredom -= 1;
            this.Health += 1;

        }
        public void VetVisitPet()
        {
            Console.WriteLine("\nyou have taken your pet to the Vet");
            Console.WriteLine("Health has increased by 1\n");


            this.Health += 1;

        }
        public void PetStatus()
        {
            Console.WriteLine("\n" + this.Name + "'s hunger is " + this.Hunger);
            Console.WriteLine(this.Name + "'s boredom is " + this.Boredom);
            Console.WriteLine(this.Name + "'s health is " + this.Health + "\n");
        }

        public void PetInfo()
        {
            Console.WriteLine("\nYour pet name is " + this.Name + " and your pet is a " + this.Species + ".\n");


        }
        
    }
}
