using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO___Projeto_RPG.Entities
{
    internal class Knight : Hero
    {
        public Knight(string name, int level, string heroType, int hP, int mP) : base(name, level, heroType, hP, mP)
        {
        }

        public override string Attack()
        {
            return ($"{Name} Atacou com espada");
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return ($"{Name} Acertou em cheio com sua espada, obtendo {bonus} de bônus de ataque!");
            }
            else
            {
                return ($"{Name} Não segurou a espada direito, obtendo apenas {bonus} de bônus de ataque!");
            }
        }
    }
}
