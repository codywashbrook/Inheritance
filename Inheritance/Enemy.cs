using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame
{
    internal class Enemy : GameCharacter // inherits game character
    {
        public Enemy(string name) : base(name)
        {
            Console.WriteLine("c0nstructed");
        }

        public new void ShowStats() //overrides gamecharacter using base
        {
            base.ShowStats();
            Console.WriteLine("Run");
        }
    }
}
