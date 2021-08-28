using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine.Weapons
{
    public class Enma : Sword
    {
        public Enma()
        {
            stats = new WeaponStats()
            {
                Damage = 40,
                Durability = -1
            };
        }

        public override double GetCurrentDamage()
        {
            return stats.Damage + stats.Damage * 0.66666666666666 * stats.EnchantLevel;
        }

    }
}
