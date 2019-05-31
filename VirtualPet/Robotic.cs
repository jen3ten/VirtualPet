using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Robotic : Pet
    {
        public int OilLevel;
        public int PerformanceLevel;


        public Robotic(string name, string species) : base(name, species)
        {
            PetType = "Robot";
            OilLevel = 50;
            PerformanceLevel = 75;
        }
        public void OilPet()
        {
            Console.Clear();
            Console.WriteLine("\nyou have oiled " + this.Name);
            Console.WriteLine("oil level has increased by 1\n");
            this.OilLevel += 1;
        }



        public virtual void MechanicVisitPet()
        {
            Console.Clear();
            Console.WriteLine("\nyou have taken " + this.Name + " to the mechanic.");
            Console.WriteLine("Performance level has increased by 1.\n");


            this.PerformanceLevel += 1;

        }
        public override void PlayWithPet()
        {
            base.PlayWithPet();
            Console.WriteLine("Performance level has increased by 1.");
            this.PerformanceLevel += 1;
           


        }
        public void RoboticStatsDecay()
        {
            this.OilLevel -= 1;
            this.Boredom += 1;
            this.PerformanceLevel -= 1;

        }
    }
}
