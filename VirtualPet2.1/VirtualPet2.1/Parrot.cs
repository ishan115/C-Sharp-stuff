using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    public class Parrot : Pet, IMission
    {
        public static List<ItemType> items = new List<ItemType>()
        {
            ItemType.Bird_Feed,
            ItemType.Voice_Changer,
            ItemType.Water_Bowl
        };

        public Parrot()
        {
            PetName = "Parrot";
            PetColor = "Green";
            PetAge = "7";

            pethud = PetHUD.Parrot;

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