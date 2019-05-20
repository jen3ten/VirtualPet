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

       public Pet(string name, string species, int hunger, int boredom, int health )
        {
            Name = name;
            Species = species;
            Hunger = hunger;
            Boredom = boredom;
            Health = health;
                }
    }
}
    