using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSomething
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tools tools = new Tools();


            Console.WriteLine("Init Line");
            Console.Read();
            

            Item testItem = new Item("Sword", "This is the sword of legends");
            Character testChar = new Character("Vyn", "Archer", 1, 10);

            tools.PrintChar(testChar);
            tools.printItem(testItem);

            Sword newsword = new Sword();




            



        }
    }
}
