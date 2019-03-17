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

        Store store = new Store();

        Item item1 = new Item(ItemType.Ball);
        Item item2 = new Item(ItemType.Bird_Feed);
        Item item3 = new Item(ItemType.Milk_Bowl);
        Item item4 = new Item(ItemType.Slide_Whistle);
        Item item5 = new Item(ItemType.Voice_Changer);
        Item item6 = new Item(ItemType.Walking_Stick);
        Item item7 = new Item(ItemType.Water_Bowl);

        Player player;

        List<INameGet> listOfPet = new List<INameGet>();

        List<string> petnames = new List<string>();

        List<INameGet> listOfItems = new List<INameGet>();

        List<string> itemnames = new List<string>();

        public GameLogic()
        {
            player = new Player();

            listOfPet.Add(dog);
            listOfPet.Add(cat);
            listOfPet.Add(parrot);

            listOfItems.Add(item1);
            listOfItems.Add(item2);
            listOfItems.Add(item3);
            listOfItems.Add(item4);
            listOfItems.Add(item5);
            listOfItems.Add(item6);
            listOfItems.Add(item7);


            while (true)
            {
                int i = tool.menu(Enum.GetNames(typeof(MainHUD)).ToList()); //Goes to enum and looks for the string attached to each number, puts in an array and returns an integer

                if (i == 1)
                {
                    player.outputPlayer();
                } 
                else if (i == 2)
                {
                    int o = tool.menu(GetName(listOfPet)) - 1;

                    int p = tool.menu(GetName(listOfItems)) - 1;

                    switch (((Pet)listOfPet[o]).pethud)
                    {
                        case PetHUD.Dog:


                        if (Dog.items.Contains(((Item)listOfItems[p]).typeOfItem))
                            {
                                WriteLine("You can use this item");
                                listOfItems.Remove((Item)listOfItems[p]);
                            }
                            else
                            {
                                WriteLine("You cannot use this item");
                            }
                            break;

                        case PetHUD.Cat:
                            if (Cat.items.Contains(((Item)listOfItems[p]).typeOfItem))
                            {
                                WriteLine("You can use this item");
                                listOfItems.Remove((Item)listOfItems[p]);
                            }
                            else
                            {
                                WriteLine("You cannot use this item");
                            }
                            break;

                        case PetHUD.Parrot:
                            if (Parrot.items.Contains(((Item)listOfItems[p]).typeOfItem))
                            {
                                WriteLine("You can use this item");
                                listOfItems.Remove((Item)listOfItems[p]);
                            }
                            else
                            {
                                WriteLine("You cannot use this item");
                            }
                            break;
                    }
                }
                else if (i == 3)
                {
                    WriteLine("Inventory: ");
                    foreach (string itemdisplay in GetName(listOfItems))
                    {
                        WriteLine(itemdisplay);
                    }
                }
                else if (i == 4)
                {
                    WriteLine("Welcome to the pet shop. Here you can buy as many toys as you want as long as you have money.");
                    int q = tool.menu(GetName(store.storelist)) - 1;

                    listOfItems.Add((Item)store.storelist[q]);
                }
            }
        }

        public List<string> GetName(List<INameGet> nameGets)
        {
            List<string> function = new List<string>();
            foreach (INameGet pets in nameGets)
            {
                function.Add(tool.Spacer(pets.getName()));
            }

            return function;
        }
    }
}