using static System.Console;
using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;

namespace VirtualPet2._1
{
    public interface INameGet //Inter
    {
        string getName();
    }

    class GameLogic
    {
        string path = "intro.txt";

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
            string[] readText = File.ReadAllLines(path); //Referenced from MSDN 

            foreach (string s in readText)
            {
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine(s + "\n");
                ResetColor();
            }

            ReadKey();

            Clear();

            player = new Player();

            ReadKey();

            Clear();

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
                Clear();

                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Please select one of the options from below");
                ResetColor();

                int i = tool.menu(Enum.GetNames(typeof(MainHUD)).ToList()); //Goes to enum and looks for the string attached to each number, puts in an array and returns an integer

                if (i == 1)
                {
                    player.outputPlayer();
                    ReadKey();
                    Clear();
                } 
                else if (i == 2)
                {
                    int o = tool.menu(GetName(listOfPet)) - 1; //returns int selected by player when selecting pet

                    int p = tool.menu(GetName(listOfItems)) - 1; //returns int selected by player when selecting items

                    switch (((Pet)listOfPet[o]).pethud)
                    {
                        case PetHUD.Dog:

                        if (Dog.items.Contains(((Item)listOfItems[p]).typeOfItem)) //checks if the selected item matches with a toy that a dog can use
                            {
                                WriteLine("You can use this item");
                                listOfItems.Remove((Item)listOfItems[p]);
                                ReadKey();
                                Clear();
                            }
                            else
                            {
                                WriteLine("You cannot use this item");
                                ReadKey();
                                Clear();
                            }
                            break;

                        case PetHUD.Cat:
                            if (Cat.items.Contains(((Item)listOfItems[p]).typeOfItem)) //checks if the selected item matches with a toy that a cat can use
                            {
                                WriteLine("You can use this item");
                                listOfItems.Remove((Item)listOfItems[p]);
                                ReadKey();
                                Clear();
                            }
                            else
                            {
                                WriteLine("You cannot use this item");
                                ReadKey();
                                Clear();
                            }
                            break;

                        case PetHUD.Parrot:
                            if (Parrot.items.Contains(((Item)listOfItems[p]).typeOfItem)) //checks if the selected item matches with a toy that a parrot can use
                            {
                                WriteLine("You can use this item");
                                listOfItems.Remove((Item)listOfItems[p]);
                                ReadKey();
                                Clear();
                            }
                            else
                            {
                                WriteLine("You cannot use this item");
                                ReadKey();
                                Clear();
                            }
                            break;
                    }
                }
                else if (i == 3)
                {
                    WriteLine("Inventory: "); //displays current inventory of toys
                    foreach (string itemdisplay in GetName(listOfItems))
                    {
                        WriteLine(itemdisplay);
                        ReadKey();
                        Clear();
                    }
                }
                else if (i == 4)
                {
                    WriteLine("Welcome to the pet shop. Here you can buy as many toys as you want as long as you have money.");
                    int q = tool.menu(GetName(store.storelist)) - 1; //returns int selected by player when choosing options within the store

                    listOfItems.Add((Item)store.storelist[q]);
                    ReadKey();
                    Clear();
                }
                else if (i == 5)
                {
                    Environment.Exit(0);
                }
            }
        }

        public List<string> GetName(List<INameGet> nameGets) //creates a list and replaces the '_' with space
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