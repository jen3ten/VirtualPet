using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Robotic : Pet
    {
        

        public Robotic(string name, string species) : base(name, species)
        {
            PetType = "Robot";

        }
    }
}
