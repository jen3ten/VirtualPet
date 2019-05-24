using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Shelter
    {
        
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

        public void AddToShelterList(Pet firstPet)
        {
            listOfPets.Add(firstPet);

        }
        
        public void ViewPetList()
        {
            Console.WriteLine("Here are the pets in your shelter:\n");
            foreach (Pet element in listOfPets)
            {
                Console.WriteLine("Pet Name: " + element.Name);
                Console.WriteLine("Pet Species: " + element.Species);
                Console.WriteLine("");
            }
        }
        
        public void IndividualPetList()
        {
            int i =0;
            int j = listOfPets.Count;

            foreach(Pet element in listOfPets)
            {
               i = i + 1;
                Console.WriteLine(i+ " "+element.Name );
                    
            }
            Console.WriteLine("Input the number of your pet to access it.");
            Console.ReadLine();
        }
        
}
}
