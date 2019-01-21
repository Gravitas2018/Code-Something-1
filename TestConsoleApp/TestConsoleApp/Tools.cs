using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tools
{
    
    public string PrintChar(Character character)
    {

        Console.WriteLine("Name: " + character.name + "\nLevel: " + character.level + "\nClass: " + character.type + "\nInventory Space: " + character.bagSpace + "\n");

        return "";

    }

    public string printItem(Item item)
    {
        Console.WriteLine("The name of the item is: " + item.name + "\nThe description of the item is: " + item.description);

        return "";

    }
}

