using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.RPG.src.Entities
{
    public abstract class Hero
    {
        public Hero()
        {

        }

        public Hero(string name, int health, int level, string heroType)
        {
            Name = name;
            Health = health;    
            Level = level;
            HeroType = heroType;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public override string ToString()
        {
            return "Name: " + this.Name +"\nHealth: " + this.Health + "\nLevel: " + this.Level + "\nHero Type: " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a espada quebrada!!!";
        }
    }
}
