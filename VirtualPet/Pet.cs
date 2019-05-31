using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
     
        public string Name;
        public string Species;
        public string PetType;
        public int Boredom;
        
        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Boredom = 50;
            
        }



        public virtual void PlayWithPet()
        {
            Console.Clear();
            Console.WriteLine("\nyou have played with " + this.Name);
            Console.WriteLine("boredom has lowered by 1");
           

            this.Boredom -= 1;


        }



        public void PetStatus()
        {
            Console.Clear();
            //Console.WriteLine("\n" + this.Name + "'s hunger is " + this.Hunger);
            Console.WriteLine(this.Name + "'s boredom is " + this.Boredom);
            //Console.WriteLine(this.Name + "'s health is " + this.Health + "\n");
        }

        public void PetInfo()
        {
            Console.Clear();
            Console.WriteLine("\nYour pet name is " + this.Name + " and your pet is a " + this.PetType + " " + this.Species + ".\n");


        }
        
    }
}
