using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO___Projeto_RPG.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public Hero(string name, int level, string heroType, int hP, int mP)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            HP = hP;
            MP = mP;
        }

        public override string ToString()
        {
            return ($"{Name} \r\n" +
                    $"   Lv. {Level}   {HeroType} \r\n" +
                    $"   HP {HP}/{HP} \r\n" +
                    $"   MP {MP}/{MP}" +
                    $"\r\n");
        }

        public virtual string Attack()
        {
            return "";
        }
    }
}
