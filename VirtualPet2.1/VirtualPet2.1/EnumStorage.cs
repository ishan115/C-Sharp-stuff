using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    public enum MainHUD
    {
        Player,
        Pet,
        Item,
        Store,
        Exit
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
        Walking_Stick, //$30 , Used only by Cat and Dog
        Voice_Changer, //$200 , Used only by Parrot
        Slide_Whistle, //$150 , Used only by Dog
        Ball, //$25 , Used only by Cat and Dog
        Milk_Bowl, //$50 , Used only by Cat
        Water_Bowl, //$75 , Used only by all
        Bird_Feed, //$100 , Used only by Parrot
    }

    public enum SkillEnum
    {
        Walk,
        Talk,
        Slide,
        RollOver,
        Meow,
        Bark,
        Chirp,
    }
}