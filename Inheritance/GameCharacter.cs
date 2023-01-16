using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGame
{
    internal abstract class GameCharacter // to give player and enemy its info
    {
        //fields
        public int health = 100;
        public string name;

        //method

        public GameCharacter(string name) //constructor + string name // base = parent
        {
            this.name = name;
            Console.WriteLine("Con$tructed");
        }

        public void TakeDamage(int hp)
        {
            health -= hp;
            if (health < 0) health = 0;

        }

        public void Heal(int hp)
        {
            health += hp;
            if (health > 100) health = 100;
        }

        public void ShowStats()
        {
            Console.WriteLine("health = " + health);
        }
    }
}
