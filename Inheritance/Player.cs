using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame
{
    internal class Player : GameCharacter // // inherits game character
    {
        public int lives = 3; //fields that enemy wouldn't have so stored here instead of game character

        public Player(string name) :  base(name)
        {
            Console.WriteLine("c)nstructed");
        }
    }
}
