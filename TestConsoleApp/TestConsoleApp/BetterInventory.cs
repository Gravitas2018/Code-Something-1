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

    Axe axe1 = new Axe(1, "One Handed Axe", "Hold this shit with one hand");
    Axe axe2 = new Axe(2, "Two Handed Axe", "Hold this shit with two hands");
    Axe axe3 = new Axe(3, "Kingslayer", "This shit kill kings");



        Item[,] inventory = new Item[,] { { sword1, sword2, sword3 }, { axe1, axe2, axe3 } };

        Console.WriteLine("\nInventory:");
        foreach (Item item in inventory)
        {
            Console.WriteLine(item.name + " - " + item.description);
        }
    }
}

