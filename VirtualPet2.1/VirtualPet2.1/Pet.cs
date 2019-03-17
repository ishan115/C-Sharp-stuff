using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    abstract class Pet
    {
        public string PetName;
        public string PetColor;
        public string PetAge;

        public void attributes()
        {
            WriteLine("My name is " + PetName + ", I am " + PetColor + ". I am " + PetAge + " years old.");
        }

        public abstract void giveItem();

        public abstract void sendMission();
    }
}