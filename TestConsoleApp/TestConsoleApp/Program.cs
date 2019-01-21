using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSomething
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Init Line");
            Console.Read();
            

            Item testItem = new Item("Sword", "This is the sword of legends");

            Character testChar = new Character("Noob", 0);

            Console.WriteLine(testChar.name + " " + testChar.level + "\n");

            //Wait
            Console.Read();

            testItem.printItem();

            



        }
    }
}
