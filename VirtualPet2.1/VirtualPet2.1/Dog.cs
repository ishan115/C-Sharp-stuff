using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    class Dog : Pet, IMission
    {
        public List<ItemType> items = new List<ItemType>()
        {
            ItemType.Ball,
            ItemType.Slide_Whistle,
            ItemType.Walking_Stick,
            ItemType.Water_Bowl
        };

        public Dog()
        {
            PetName = "Dog";
            PetColor = "Brown";
            PetAge = "5";

            pethud = PetHUD.Dog;

            attributes();
        }

        public override void giveItem()
        {
            throw new System.NotImplementedException();
        }

        public override void sendMission()
        {
            throw new System.NotImplementedException();
        }
    }
}