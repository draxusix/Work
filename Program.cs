using PracovniZadani;
using Type = PracovniZadani.Type;

class Program
{
    static void Main()
    {
        Type asset = new Type(name: "assets", equation: "x/y");

        Type equity = new Type(name: "equities", equation: "???");

        Type PL = new Type(name: "PLs", equation: "???");

        Type Liability = new Type(name: "Liabilities", equation: "???");

        Item item1 = new Item(name: "item1", value: 100, itemType: asset);

        Item item2 = new Item(name: "item2", value: -20, itemType: equity);

        Item item3 = new Item(name: "item3", value: -30, itemType: PL);

        Item item4 = new Item(name: "item4", value: -50, itemType: Liability);

        BalanceSheet balanceSheet = new BalanceSheet(items: new List<Item> { item1 });
    }
}

