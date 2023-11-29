using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadani
{
    internal class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public Type ItemType { get; set; }

        public Item(string name, int value, Type itemType)
        {
            Name = name;
            Value = value;
            ItemType = itemType;
        }
    }
}
