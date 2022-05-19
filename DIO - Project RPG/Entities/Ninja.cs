using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO___Projeto_RPG.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType, int hP, int mP) : base(name, level, heroType, hP, mP)
        {
        }

        public override string Attack()
        {
            return ($"{Name} Atacou com uma Katana!");
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return ($"{Name} Fez um super corte com sua katana, obtendo {bonus} de bônus de ataque!");
            }
            else
            {
                return ($"{Name} Acertou com o lado sem fio da katana, obtendo apenas {bonus} de bônus de ataque!");
            }
        }
    }
}
