using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities.Weapons
{
    public class Enma : Sword
    {
        public Enma()
        {
            stats = new WeaponStats()
            {
                BaseDamage = 40,
                Durability = -1
            };
        }

        public override double GetCurrentDamage()
        {
            return stats.BaseDamage + stats.BaseDamage * 0.66666666666666 * stats.EnchantLevel;
        }

    }
}
