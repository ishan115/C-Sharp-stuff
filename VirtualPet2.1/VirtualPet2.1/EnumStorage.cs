using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    public enum MainHUD
    {
        Player,
        Pet,
        Item,
        Store
    }

    public enum PetHUD
    {
        Cat,
        Dog,
        Parrot
    }

    public enum StoreHUD
    {
        Buy,
        Sell,
        Exit
    }

    public enum ItemType
    {
        Milk_Bowl, //$50
        Water_Bowl, //$75
        Bird_Feed //$100
    }
}