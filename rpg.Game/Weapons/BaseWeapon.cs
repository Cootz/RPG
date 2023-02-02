using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities.Weapons
{
    public abstract class BaseWeapon
    {
        protected WeaponStats stats;

        public virtual double GetCurrentDamage() { return Double.NaN; }

        public virtual WeaponStats GetStats()
        {
            return stats;
        }
    }
}
