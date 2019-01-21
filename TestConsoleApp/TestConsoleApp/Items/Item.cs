using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Item
    {
        public string name;
        public string description;

        public Item()
        {

        }

        public Item(string namePassed, string descriptionPassed)
        {
            this.name = namePassed;
            this.description = descriptionPassed;
        }

        public void inheritFromParent()
        {
        Console.WriteLine(5 + 5 + " Don't touch this damn method");

        }




}

