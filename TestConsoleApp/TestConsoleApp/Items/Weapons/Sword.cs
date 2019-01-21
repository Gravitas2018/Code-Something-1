using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Sword:Item
{

    public int dps;

    public Sword(int _dps, string namePassed, string descriptionPassed): base(namePassed, descriptionPassed)
    {
        this.dps = _dps;
    }

}