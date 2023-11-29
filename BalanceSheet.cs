using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadani
{
    internal class BalanceSheet
    {
        public List<Item> Items { get; set; }

        public BalanceSheet(List<Item> items)
        {
            Items = items;
        }
        // Should be implemented as a singleton
    }
}
