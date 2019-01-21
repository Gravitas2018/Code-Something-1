using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Axe:Item
{

    public int dps;

    public Axe(int _dps, string namePassed, string descriptionPassed): base(namePassed, descriptionPassed)
    {
        this.dps = _dps;
    }

}