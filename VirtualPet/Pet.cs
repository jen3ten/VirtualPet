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
            Hunger = 0;
            Boredom = 0;
            Health = 100;
       }


    }
}
    