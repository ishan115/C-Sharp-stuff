using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    public class Player
    {
        public string PlayerName;
        public string PlayerAge;

        public Player()
        {
            inputPlayer();
            WriteLine();
            outputPlayer();
        }

        public void inputPlayer()
        {
            WriteLine("Please enter your name: ");
            PlayerName = ReadLine();

            WriteLine("Please enter your age: ");
            PlayerAge = ReadLine();
        }

        public void outputPlayer()
        {
            WriteLine("Your name is: " + PlayerName);

            WriteLine("Your age is: " + PlayerAge);
        }
    }
}