using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Item
    {
        string name;
        string description;

        public Item()
        {

        }

        public Item(string namePassed, string descriptionPassed)
        {
            this.name = namePassed;
            this.description = descriptionPassed;
        }

        public string printItem()
        {
            Console.WriteLine("The name of the item is = " + name);
            Console.WriteLine("The description of the item is = " + description);

            return "";
   
        }


    }

