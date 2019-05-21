using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Pet
    {
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
        public void FeedPet()
        {
            Console.WriteLine("you have fed your pet")
            Console.WriteLine("hunger has lowered by 1");
            this.Hunger -= 1;
        }

    }
}
    