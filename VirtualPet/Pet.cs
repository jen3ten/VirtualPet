using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Pet
    {
     
        public string Name;
        public string Species;
        public string PetType;
        public int Hunger;
        public int Boredom;
        public int Health;

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            PetType = "Organic";
            Hunger = 50;
            Boredom = 50;
            Health = 75;
        }
        
        public virtual void FeedPet()
        {
            Console.Clear();
            Console.WriteLine("\nyou have fed " + this.Name);
            Console.WriteLine("hunger has lowered by 1\n");
            this.Hunger -= 1;
        }

        public void PlayWithPet()
        {
            Console.Clear();
            Console.WriteLine("\nyou have played with "+ this.Name);
            Console.WriteLine("boredom has lowered by 1");
            Console.WriteLine("Health has increased by 1\n");

            this.Boredom -= 1;
            this.Health += 1;

        }

        public virtual void VetVisitPet()
        {
            Console.Clear();
            Console.WriteLine("\nyou have taken " + this.Name + " to the Vet");
            Console.WriteLine("Health has increased by 1\n");


            this.Health += 1;

        }

        public void PetStatus()
        {
            Console.Clear();
            Console.WriteLine("\n" + this.Name + "'s hunger is " + this.Hunger);
            Console.WriteLine(this.Name + "'s boredom is " + this.Boredom);
            Console.WriteLine(this.Name + "'s health is " + this.Health + "\n");
        }

        public void PetInfo()
        {
            Console.Clear();
            Console.WriteLine("\nYour pet name is " + this.Name + " and your pet is a " + this.PetType + " " + this.Species + ".\n");


        }
        
    }
}
