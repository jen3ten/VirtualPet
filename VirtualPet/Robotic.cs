using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Robotic : Pet
    {
        public int OilLevel;
        public int PerformanceLevel;


        public Robotic(string name, string species) : base(name, species)
        {
            PetType = "Robot";
            OilLevel = 50;
            PerformanceLevel = 75;
        }
    }
}
