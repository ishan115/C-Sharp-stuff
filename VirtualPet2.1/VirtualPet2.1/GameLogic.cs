using static System.Console;
using System.Collections.Generic;
using System;
using System.Linq;

namespace VirtualPet2._1
{
    public interface INameGet
    {
        string getName();
    }

    class GameLogic
    {
        Tools tool = new Tools();
        Dog dog = new Dog();
        Cat cat = new Cat();
        Parrot parrot = new Parrot();
        Player player;

        List<Pet> listOfPet = new List<Pet>();

        List<string> petnames = new List<string>();

        List<Item> listOfItems = new List<Item>();

        List<string> itemnames = new List<string>();

        public GameLogic()
        {
            player = new Player();

            listOfPet.Add(dog);
            listOfPet.Add(cat);
            listOfPet.Add(parrot);

            while (true)
            {
                int i = tool.menu(Enum.GetNames(typeof(MainHUD)).ToList()); //Goes to enum and looks for the string attached to each number, puts in an array and returns an integer

                if (i == 1)
                {
                    player.outputPlayer();
                } 
                else if (i == 2)
                {
                    int o = tool.menu(GetPetNames());

                    int p = tool.menu(listOfItems());

                    switch (listOfPet[o].pethud)
                    {
                        case PetHUD.Dog:

                        case PetHUD.Cat:

                        case PetHUD.Parrot:

                        break;
                    }
                }
            }

        }

        public List<string> GetPetNames(List<INameGet> nameGets)
        {
            List<string> function = new List<string>();
            foreach (INameGet pets in nameGets)
            {
                function.Add(pets.getName());
            }

            return function;
        }


    }

}