using static System.Console;
using System.Collections.Generic;

namespace VirtualPet2._1
{
    class Item
    {
        public ItemType typeOfItem;

        public Item(ItemType _item)
        {
            typeOfItem = _item;
        }

        public void method()
        {
            List<Itemm> l = new List<Itemm>();

            foreach (Itemm item in l)
            {
                item.DoShit();
            }
        }
    }

    public interface Itemm
    {
        string GetName();
        void DoShit();
    }

    public interface Entity
    {
        string GetName();
        void DoShit();
    }

    public class BirdFood : Itemm
    {
        public void DoShit()
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            throw new System.NotImplementedException();
        }
    }

}