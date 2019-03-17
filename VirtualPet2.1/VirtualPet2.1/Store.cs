using System;
using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    public class Store
    {
        public Store()
        {
            GetPrice getPrice = BasePrice;
            getPrice += FluctPrice;

            int basePrice = getPrice(new Item(ItemType.Ball));
        }

        public delegate int GetPrice(Item item);

        public static int BasePrice(Item item)
        {
            switch (item.typeOfItem)
            {
                case ItemType.Walking_Stick:
                    return 30;
                case ItemType.Voice_Changer:
                    return 200;
                case ItemType.Slide_Whistle:
                    return 150;
                case ItemType.Ball:
                    return 25;
                case ItemType.Milk_Bowl:
                    return 50;
                case ItemType.Water_Bowl:
                    return 75;
                case ItemType.Bird_Feed:
                    return 100;

                default:
                    return 0;
            }
        }

        public static int FluctPrice(Item item)
        {
            Random rng = new Random();
            int check = rng.Next(0, 100);
            return check;
        }
    }
}