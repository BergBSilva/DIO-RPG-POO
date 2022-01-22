using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.RPG.src.Entities
{
    internal class Knight : Hero
    {
        public Knight(string name,  int health, int level, string heroType)
        {
            Name = name;
            Health = health;
            Level = level;
            HeroType = heroType;
        }

        public override string Attack()
        {
            return this.Name + " atacou com a espada longa!!!";
        }

        public string Attack(int Bonus)
        {
            Random random = new Random();
            int number = random.Next(10);

            if(number < Bonus)
            {
                return this.Name + " atacou com a espada longa com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " atacou com a espada longa";
            }
        }
    }
}
