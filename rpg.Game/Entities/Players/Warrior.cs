using rpg.Game.Entities.BaseInterfases;
using rpg.Game.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities.Players
{
    public class Warrior : Player, IHealth, IMana, IStamina, IAttack
    {
        private Sword mainWeapon;

        public Warrior(Sword weapon) : base(10000)
        {
            mainWeapon = weapon;
            sp = 1000;
            name = "Sword man";
        }
    }
}
