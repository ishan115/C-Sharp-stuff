﻿using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    class Dog : Pet
    {
        public Dog()
        {
            PetName = "Dog";
            PetColor = "Brown";
            PetAge = "5";

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