using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Shelter
    {
        Pet firstPet;

        public string Name;

        public Shelter(string name)
        {
            Name = name;
        }

        List<Pet> listOfPets = new List<Pet>();

        


        public void CreateShelter()
        {
            Shelter shelter = new Shelter("Your Shelter");
        }

        public void AddToShelterList()
        {
            listOfPets.Add(firstPet);

        }
        
        public void ViewPetList()
        {
            foreach (Pet element in listOfPets)
            {
                Console.WriteLine(element.Name);
                Console.WriteLine("This line is working");
            }
        }
        
}
}
