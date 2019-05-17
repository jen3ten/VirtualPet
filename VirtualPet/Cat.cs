using System;
using System.Collections.Generic;
using System.Text;
/*As a player, I would like to add a pet to the shelter, so there is a pet that I can interact with
Given I'm a player, when I choose to add a pet to the shelter from the main menu, then I am asked for its name and species
*/
namespace VirtualPet
{
    class Cat
    {
        public string Name;
        public string Species;

        Cat(string name, string species)
        {
            Name = name;
            Species = species;
                }
    }
}
    