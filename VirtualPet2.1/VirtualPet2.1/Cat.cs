using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    class Cat : Pet, IMission
    {
        public Cat()
        {
            PetName = "Cat";
            PetColor = "Orange";
            PetAge = "3";

            pethud = PetHUD.Cat;

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