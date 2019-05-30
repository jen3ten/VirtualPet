using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Shelter
    {
        string petName = "";
        string petSpecies = "";
        string inputPetType = "";
        string petType = "";

        public string Name;

        public Shelter(string name)
        {
            Name = name;
        }

        public List<Pet> listOfPets = new List<Pet>();
        public List <Organic> listOfOrganicPets = new List <Organic>();
        public List <Robotic> listOfRoboticPets = new List <Robotic>();

        public void CreateShelter()
        {
            Shelter shelter = new Shelter("Your Shelter");
        }

        public void CreatePet()
        {
            Pet firstPet;
            Robotic firstRobotPet;
            Organic firstOrganicPet;

            Console.WriteLine("What Type of pet is it?\n" + 
                "Type 1 for Organic\n" + 
                "Type 2 for Robotic");

            inputPetType = Console.ReadLine();

            if (inputPetType == "2")
            {
                petType = "Robot";
                Console.WriteLine("\nEnter your pet name:");
                petName = Console.ReadLine();

                Console.WriteLine("\nEnter your pet species:");
                petSpecies = Console.ReadLine();


                firstRobotPet = new Robotic(petName, petSpecies);
                AddToShelterList(firstRobotPet);


                Console.Clear();
                Console.WriteLine(firstRobotPet.Name + " the Robot " + this.petSpecies + ", was added to the shelter!\n");
            }

            else 
            {
            Console.WriteLine("\nEnter your pet name:");
            petName = Console.ReadLine();

            Console.WriteLine("\nEnter your pet species:");
            petSpecies = Console.ReadLine();


            firstOrganicPet = new Organic(petName, petSpecies);
            AddToShelterList(firstOrganicPet);

            
            Console.Clear();
            Console.WriteLine(firstOrganicPet.Name + " was added to the shelter!\n");
            }
        }


        public void AddToShelterList(Pet firstPet)
        {
            listOfPets.Add(firstPet);

        }

        public void RemoveFromShelterList(Pet selectedPet)
        {
            Console.WriteLine(selectedPet.Name + " has been adopted");
            listOfPets.Remove(selectedPet);
        }
        
        public void ViewAllPetList()
        {
            Console.WriteLine("Here are the pets in your shelter:\n");
            foreach (Pet element in listOfPets)
            {
                Console.WriteLine("Pet Name: " + element.Name);
                Console.WriteLine("Pet Species: " + element.Species);
                Console.WriteLine("Pet Type: " + element.PetType);
                Console.WriteLine("");
            }
        }

        public void ViewAllPetStatus()
        {
            Console.WriteLine("Here are your pets' status:");
            foreach(Pet element in listOfPets)
            {
                Console.WriteLine("");
                Console.WriteLine("Pet name:" + element.Name  );
                Console.WriteLine("Hunger:" + element.Hunger);
                Console.WriteLine("Boredom:" + element.Boredom);
                Console.WriteLine("Health:" + element.Health);
                Console.WriteLine("");
            }
            foreach (Pet element in listOfPets)
            {
                Console.WriteLine("");
                Console.WriteLine("Pet name:" + element.Name);
                Console.WriteLine("Oil Level:" + element.OilLevel);
                Console.WriteLine("Boredom:" + element.Boredom);
                Console.WriteLine("Performance Level:" + element.PerformanceLevel);
                Console.WriteLine("");
            }
        }
        
        public void IndividualPetList()
        {
            int i =0;

            foreach(Pet element in listOfPets)
            {
               i = i + 1;
                Console.WriteLine(i+ " "+element.Name );
            }
            
        }
        
    }

}
