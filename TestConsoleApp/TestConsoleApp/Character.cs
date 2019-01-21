using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSomething
{
    public class Character
    {
        public string _name { get; set; }
        public int _level { get; set; }
        public Character(string name, int level)
        {
            _name = name;
            _level = level;
        }
    }
}
