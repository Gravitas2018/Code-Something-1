using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BetterInventory
{

    public void Inventory() {
    Sword sword1 = new Sword(1, "One Handed Sword", "Hold this shit with one hand");
    Sword sword2 = new Sword(2, "Two Handed Sword", "Hold this shit with two hands");
    Sword sword3 = new Sword(3, "Long Sword", "This shit long");



    Item[,] inventory = new Item[,] { { sword1, sword2, sword3 } };

        Console.WriteLine("\nInventory:");
        foreach (Item item in inventory)
        {
            Console.WriteLine(item.name + " - " + item.description);
        }
    }
}

