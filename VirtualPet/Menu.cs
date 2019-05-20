using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Type 1 to create a cat.");



            if (Console.ReadLine() == "1");
            {
                Console.WriteLine("Enter your cat name:");
                string catName = Console.ReadLine();

                Console.WriteLine("Enter your cat breed:");
                string catBreed = Console.ReadLine();

                Cat firstCat = new Cat(catName, catBreed);

                Console.WriteLine(firstCat.Name + " was added to the shelter!");

            }

            


           


        }
    }
}
