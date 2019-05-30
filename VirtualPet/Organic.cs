using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Organic : Pet
    {
        public int Hunger;
        public int Health;


        public Organic(string name, string species):base(name,species)
        {
            PetType = "Organic";
            Hunger = 50;
            Health = 75;
        }

        public void FeedPet()
        {
            Console.Clear();
            Console.WriteLine("\nyou have fed " + this.Name);
            Console.WriteLine("hunger has lowered by 1\n");
            this.Hunger -= 1;
        }



        public virtual void VetVisitPet()
        {
            Console.Clear();
            Console.WriteLine("\nyou have taken " + this.Name + " to the Vet");
            Console.WriteLine("Health has increased by 1\n");


            this.Health += 1;

        }
        public override void PlayWithPet()
        {
            base.PlayWithPet();
            Console.WriteLine("Health has increased by 1.");
            this.Health += 1;



        }

    }

}
