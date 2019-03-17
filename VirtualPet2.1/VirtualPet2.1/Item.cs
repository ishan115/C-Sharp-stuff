using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    class Item : INameGet
    {
        public ItemType typeOfItem;

        public Item(ItemType _item)
        {
            typeOfItem = _item;
        }

        public string getName()
        {
            return typeOfItem.ToString();
        }
    }
}