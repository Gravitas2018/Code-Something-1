using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Character
{
    public string name { get; set; }
    public int level { get; set; }
    public Character(string name, int level)
    {
        this.name = name;
        this.level = level;
    }
}

