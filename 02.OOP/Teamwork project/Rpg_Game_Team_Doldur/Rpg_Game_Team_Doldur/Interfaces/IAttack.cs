using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Team_Doldur.Interfaces
{
    public interface IAttack
    {
        int Damage { get; set; }

        void Attack(ICharacter enemy);
    }
}
