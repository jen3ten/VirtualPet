using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Organic : Pet
    {
        
        string PetType;
        public Organic(string name, string species):base(name,species)
        {
            PetType = "orgranic";
           
        }
        


    }
}
