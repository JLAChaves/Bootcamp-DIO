using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO___Projeto_RPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType, int hP, int mP) : base(name, level, heroType, hP, mP)
        {
        }

        public override string Attack()
        {
            return ($"{Name} Lançou magia");
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return ($"{Name} lançou magia super efetiva com {bonus} de bônus de ataque!");    
            }
            else
            {
                return ($"{Name} lançou uma magia fraca com {bonus} de bônus de ataque!");
            }            
        }

    }
}
