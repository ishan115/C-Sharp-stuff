﻿using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    class Parrot : Pet, IMission
    {
        public Parrot()
        {
            PetName = "Parrot";
            PetColor = "Green";
            PetAge = "7";

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