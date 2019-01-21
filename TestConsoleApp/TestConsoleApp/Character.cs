using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Character
{
    public string name;
    public int level;
    public string type;
    public int bagSpace;

    public Character(string name, string type, int level, int bagSpace)
    {
        this.name = name;
        this.type = type;
        if (level <= 0 || bagSpace <= 0)
            {
                throw new System.ArgumentException("1 or more paramaters cannot be <= 0");
            }
            else
            {
                this.level = level;
                this.bagSpace = bagSpace;

            }
        


    }
}

