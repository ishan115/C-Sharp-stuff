using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{

    public class Tools
    {
        public string playerInput;

        public Tools()
        {
           

        }

        public int menu(List<string> options) //generic menu to display HUD
        {
            //If list isn't called
            if (options.Count == 0)
            {
                return 0;
            }

            int a = 1;

            foreach (string displaying in options) //prints each list element
            {
                Write(a + ". ");
                Write(displaying + "\n");
                a++;

            }

            while (true) //ask for player input and returns an int
            {
                playerInput = ReadLine();

                int input;

                if (int.TryParse(playerInput, out input))
                {
                    if (input <= options.Count && input > 0)
                    {
                        return input;
                    }
                }
            }
        }

        public string Spacer(string space)
        {
            return space.Replace('_', ' ');
        }
    }
}