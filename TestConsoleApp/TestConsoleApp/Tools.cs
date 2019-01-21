using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tools
{
    
    public string PrintChar(Character character)
    {

        Console.Write("Name: " + character.name + "\nLevel: " + character.level + "\nClass: " + character.type + "\nInventory Space: " + character.bagSpace + "\n");

        return "";

    }
}

